using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Text;

namespace IEIFrontendRoig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //inicializamos el mapa
            InicializarMapa();
        }

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;


        //busqueda
        private async void Buscar(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            markerOverlay.Clear();
            List<Centro> l = new List<Centro>();
            String cp = scp.Text;
            String lon = slongitud.Text;
            String lat = slatitud.Text;
            String com = scomunidad.Text;
            //valores por defecto, vienen de la documentación de la API del backend
            //int y double no admiten nulos o "" asi que tenemos unos valores por defecto
            if (scp.Text == "") { cp = "0"; }
            if (slongitud.Text == "") { lon = "69.420"; }
            if (slatitud.Text == "") { lat = "69.420"; }

            var response = await HttpGetAsync("http://localhost:8080/lookupCentro?nombre=" + snombre.Text +
                    "&tipo=" + stipo.Text +
                    "&direccion=" + sdireccion.Text +
                    "&codigoPostal=" + cp +
                    "&longitud=" + lon +
                    "&latitud=" + lat +
                    "&telefono=" + stelefono.Text +
                    "&descripcion=" + sdescripcion.Text +
                    "&localidad=" + slocalidad.Text +
                    "&comunidad=" + scomunidad.Text);
            //convertimos el JSON a una lista de Centros
            l = JsonConvert.DeserializeObject<List<Centro>>(response);
            //añadimos cada uno a la tabla y al mapa
            foreach (Centro i in l)
            {
                ListViewItem lvi = new ListViewItem(i.nombre);
                lvi.SubItems.Add(i.tipo);
                lvi.SubItems.Add(i.direccion);
                lvi.SubItems.Add(i.codigoPostal + "");
                lvi.SubItems.Add(i.longitud + "");
                lvi.SubItems.Add(i.latitud + "");
                lvi.SubItems.Add(i.telefono + "");
                lvi.SubItems.Add(i.descripcion);
                lvi.SubItems.Add(i.localidad + "");
                lvi.SubItems.Add(com);

                PonerMarca(i.longitud, i.latitud);
                listView1.Items.Add(lvi);
            }
            
            MessageBox.Show("Procedimiento acabado", "Resultado");
        }

        //Método GET HTTP Async
        public async static Task<string> HttpGetAsync(string uri)
        {
            string content = null;

            var client = new HttpClient();
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsStringAsync();
            }

            return content;
        }

        //Método POST HTTP Async
        public async static Task<string> HttpPostAsync(string uri, Dictionary<string, string> values)
        {
            string content = null;
            var jsonData = JsonConvert.SerializeObject(values);
            var requestContent2 = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var response = await client.PostAsync(uri, requestContent2);
            if (response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsStringAsync();
            }
            return content;
        }


        private async void Insertar(object sender, EventArgs e)
        {
            String murtxt = "", cattxt = "", cvtxt = "";

            if (checkBox1.Checked) cvtxt = "CV.csv";
            if (checkBox2.Checked) murtxt = "MUR.json";
            if (checkBox3.Checked) cattxt = "CAT.xml";

            var data = new Dictionary<string, string>
            {
            {"filenameMUR", murtxt},
            {"filenameCAT", cattxt },
            {"filenameCV", cvtxt }
            };
            var response = await HttpPostAsync("http://localhost:8080/dunk", data);
            MessageBox.Show(response, "Resultado");
        }

        private void InicializarMapa() {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(39.73530153247731, 0.3365800521561152);
            gMapControl1.MinZoom = 6;
            gMapControl1.MaxZoom = 8;
            gMapControl1.Zoom = 6;
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void PonerMarca(double lon, double lat)
        {
            //Crea el marcador
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
            //Lo añade a la capa de marcadores
            markerOverlay.Markers.Add(marker);
        }

        private void SeleccionarCentro(object sender, EventArgs e)
        {
            try
            {
                double lon = Convert.ToDouble(listView1.SelectedItems[0].SubItems[4].Text);
                double lat = Convert.ToDouble(listView1.SelectedItems[0].SubItems[5].Text);

                markerOverlay.Clear();
                PonerMarca(lon, lat);
            }
            catch (Exception f) { }

        }
    }
}
