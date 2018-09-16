using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizarArticulos.Entidades
{
   public class Articulos
    {
        [key]
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Exitencia { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaDeVencimiento { get; set; }


        public Articulos()
        {
            ID = 0;
            Descripcion = string.Empty;
            FechaDeVencimiento = DateTime.Now;
            Precio = 0;
            Exitencia = 0;
            Cantidad = 0;
        }
        
    }
}
