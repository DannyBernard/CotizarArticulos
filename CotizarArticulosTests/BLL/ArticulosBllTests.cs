using Microsoft.VisualStudio.TestTools.UnitTesting;
using CotizarArticulos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizarArticulos.Entidades;

namespace CotizarArticulos.BLL.Tests
{
    [TestClass()]
    public class ArticulosBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();

            articulo.ID = 0;
            articulo.FechaDeVencimiento = DateTime.Now;
            articulo.Descripcion = "Esto fue excelente";
            articulo.Precio = 159;
            articulo.Exitencia = 9;
            articulo.Cantidad = 4;

            paso = ArticulosBll.Guardar(articulo);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();

            articulo.ID = 0;
            articulo.FechaDeVencimiento = DateTime.Now;
            articulo.Descripcion = "Esto fue excelente";
            articulo.Precio = 159;
            articulo.Exitencia = 9;
            articulo.Cantidad = 4;

            paso = ArticulosBll.Modificar(articulo);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();

              paso = ArticulosBll.Eliminar(1);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
          
            // paso = ArticulosBll.Buscar(1);


           // Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            Articulos articulo = new Articulos();

            articulo.ID = 0;
            articulo.FechaDeVencimiento = DateTime.Now;
            articulo.Descripcion = "Esto fue excelente";
            articulo.Precio = 159;
            articulo.Exitencia = 9;
            articulo.Cantidad = 4;

            paso = ArticulosBll.Guardar(articulo);


            Assert.AreEqual(paso, true);
        }
    }
}