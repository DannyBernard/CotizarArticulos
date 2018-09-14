using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizarArticulos.Entidades
{
    class Articulos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descricion { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public float Precio { get; set; }
        public int Exitencia { get; set; }
        public int Cantidad { get; set; }

        public Articulos()
        {
            ID = 0;
            Nombre = string.Empty;
            Descricion = string.Empty;
            FechaDeVencimiento = DateTime.Now;
            Precio = 0;
            Exitencia = 0;
            Cantidad = 0;
        }
    }
}
