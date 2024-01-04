using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IEIFrontendRoig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region unused
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion


        //busqueda
        private async void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<Centro> l = new List<Centro>();
            String cp = scp.Text;
            String lon = slongitud.Text;
            String lat = slatitud.Text;
            String com = scomunidad.Text;
            if (scp.Text == "") { cp = "0"; }
            if (slongitud.Text == "") { lon = "69.420"; }
            if (slatitud.Text == "") { lat = "69.420"; }

            var response = await HttpGetAsync("http://"+ urltxt.Text+"/lookupCentro?nombre=" + snombre.Text +
                    "&tipo=" + stipo.Text +
                    "&direccion=" + sdireccion.Text +
                    "&codigoPostal=" + cp +
                    "&longitud=" + lon +
                    "&latitud=" + lat +
                    "&telefono=" + stelefono.Text +
                    "&descripcion=" + sdescripcion.Text +
                    "&localidad=" + slocalidad.Text +
                    "&comunidad=" + scomunidad.Text);
            l = JsonConvert.DeserializeObject<List<Centro>>(response);

            foreach (Centro i in l) {
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

                listView1.Items.Add(lvi);
            }
            MessageBox.Show("Procedimiento acabado", "Resultado");
        }



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

        private async void button2_Click(object sender, EventArgs e)//insertar
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)//all
            {
                var response = await HttpGetAsync("http://"+ urltxt.Text+"/dunkALL?filenameMUR=" + murtxt.Text +
                    "&filenameCV=" + cvtxt.Text +
                    "&filenameCAT=" + cattxt.Text);
                MessageBox.Show(response, "Resultado");
            }
            else if (checkBox1.Checked && checkBox2.Checked)//cv + mur
            {
                var response = await HttpGetAsync("http://"+ urltxt.Text+"/dunkMUR_CV?filenameMUR=" + murtxt.Text +
                    "&filenameCV=" + cvtxt.Text);
                MessageBox.Show(response, "Resultado");
            }
            else if (checkBox2.Checked && checkBox3.Checked)//mur + cat
            {
                var response = await HttpGetAsync("http://"+ urltxt.Text+"/dunkMUR_CAT?filenameMUR=" + murtxt.Text +
                    "&filenameCAT=" + cattxt.Text);
                MessageBox.Show(response, "Resultado");
            }
            else if (checkBox1.Checked && checkBox3.Checked)//cv + cat
            {
                var response = await HttpGetAsync("http://"+ urltxt.Text+"/dunkCV_CAT?" +
                    "filenameCV=" + cvtxt.Text +
                    "&filenameCAT=" + cattxt.Text);
                MessageBox.Show(response, "Resultado");
            }
            else if (checkBox1.Checked)//cv
            {
                var response = await HttpGetAsync("http://"+ urltxt.Text+"/dunkCV?filename=" + cvtxt.Text);
                MessageBox.Show(response, "Resultado");
            }
            else if (checkBox2.Checked)//mur
            {
                var response = await HttpGetAsync("http://"+ urltxt.Text+"/dunkMUR?filename=" + murtxt.Text);
                MessageBox.Show(response, "Resultado");
            }
            else if (checkBox3.Checked)//cat
            {
                var response = await HttpGetAsync("http://"+ urltxt.Text+"/dunkCAT?filename=" + cattxt.Text);
                MessageBox.Show(response, "Resultado");
            }
        }

    }
}
