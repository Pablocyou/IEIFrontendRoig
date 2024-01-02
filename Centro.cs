using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEIFrontendRoig
{
    internal class Centro
    {
        public String nombre { get; }
        public String tipo { get; }
        public String direccion { get; }
        public int codigoPostal { get; }
        public double longitud { get; }
        public double latitud { get; }
        public String telefono { get; }
        public String descripcion { get; }
        public String localidad { get; }
        public Centro(String nombre, String tipo, String direccion, int codigoPostal, double longitud, double latitud, String telefono, String descripcion, String localidad)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.direccion = direccion;
            this.codigoPostal = codigoPostal;
            this.longitud = longitud;
            this.latitud = latitud;
            this.telefono = telefono;
            this.descripcion = descripcion;
            this.localidad = localidad;
        }

    }
}
