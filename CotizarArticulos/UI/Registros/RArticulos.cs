using CotizarArticulos.BLL;
using CotizarArticulos.DAL;
using CotizarArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizarArticulos.UI.Registros
{
    public partial class RArticulos : Form
    {
        public RArticulos()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            textBoxPrecio.Text = string.Empty;
            ExitenciatextBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            FechaVencidodateTimePicker.Value = DateTime.Now;  
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private bool Validar()
        {
            bool paso = true;
            if (FechaVencidodateTimePicker.Value < DateTime.Now)
            {
                errorProvider1.SetError(FechaVencidodateTimePicker, "La Fecha es invalida");
                paso = false;
            }
            if (CantidadnumericUpDown.Value <=0)
            {
                errorProvider1.SetError(CantidadnumericUpDown, "Campo esta vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ExitenciatextBox.Text))
            {
                errorProvider1.SetError(ExitenciatextBox, "Campo esta vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxPrecio.Text))
            {
                errorProvider1.SetError(textBoxPrecio, "Campo esta vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Campo esta vacio");
                paso = false;
            }
            return paso;
        }
        private Articulos LlenarClase()
        {
            Articulos articulos = new Articulos();
            articulos.ID = Convert.ToInt32(IDnumericUpDown.Value);
            articulos.Descricion = DescripciontextBox.Text;
            articulos.Precio = Convert.ToSingle(textBoxPrecio.Text);
            articulos.Exitencia = Convert.ToInt32(ExitenciatextBox.Text);
            articulos.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            articulos.FechaDeVencimiento = FechaVencidodateTimePicker.Value;
            return articulos;


        }
        private bool ExiteEnlaBaseDeDatos()
        {
            Articulos articulos = ArticulosBll.Buscar((int)IDnumericUpDown.Value);
            return (articulos != null);
        }        

        

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Articulos articulos;
            Contexto contexto = new Contexto();

            if (!Validar())
                return;
               articulos = LlenarClase();
            try
            {
                if (IDnumericUpDown.Value == 0)
                    paso = ArticulosBll.Guardar(articulos);
                else
                {
                    if (!ExiteEnlaBaseDeDatos())
                    {
                        MessageBox.Show("No se puede modificar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    paso = ArticulosBll.Modificar(articulos);
                }
                if (paso)
                    MessageBox.Show("Guardado con exito", "Guardo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(" no Guardado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception)
            {
                throw;
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int id;

            int.TryParse(IDnumericUpDown.Text, out id);
            if (ArticulosBll.Eliminar(id))
                MessageBox.Show("Eliminado");
                 Limpiar();
            errorProvider1.SetError(IDnumericUpDown,"no se puede eliminar");

        }
        private void LlenarCampo()
        {
            Articulos articulos = new Articulos();

            IDnumericUpDown.Value = articulos.ID;
            DescripciontextBox.Text = articulos.Descricion;
            articulos.Precio = Convert.ToSingle(textBoxPrecio);
            articulos.Exitencia = Convert.ToInt32(ExitenciatextBox);
            CantidadnumericUpDown.Value = articulos.Cantidad;
            FechaVencidodateTimePicker.Value = articulos.FechaDeVencimiento;


        }
        
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Articulos articulos = new Articulos();
            int.TryParse(IDnumericUpDown.Text,out id);

            articulos = ArticulosBll.Buscar(id);

            if(articulos != null)
            {
                MessageBox.Show("Encotrado");
                LlenarCampo();

            }
            else
            {
                MessageBox.Show("No Exite");
            }


        }
    }

}
