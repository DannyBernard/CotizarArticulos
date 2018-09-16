using CotizarArticulos.BLL;
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

namespace CotizarArticulos.UI.Consultas
{
    public partial class RConsulta : Form
    {
        public RConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listado = new List<Articulos>();
            if(CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedItem)
                {
                    case 0:
                        listado = ArticulosBll.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = ArticulosBll.GetList(p => p.ID == id);
                        break;
                    case 3:
                        listado = ArticulosBll.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                        break;
                    case 4:
                        decimal precio = Convert.ToDecimal(CriteriotextBox.Text);
                        listado = ArticulosBll.GetList(p => p.Precio == precio);
                        break;
                    case 5:
                        int exitencia = Convert.ToInt32(CriteriotextBox.Text);
                        listado = ArticulosBll.GetList(p => p.Exitencia == exitencia);
                        break;
                    case 6:
                        int cantidad = Convert.ToInt32(CriteriotextBox.Text);
                        listado = ArticulosBll.GetList(p => p.Cantidad == cantidad);
                        break;
                   
                }
                listado = listado.Where(c =>  c.FechaDeVencimiento >= DesdedateTimePicker.Value.Date && c.FechaDeVencimiento <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = ArticulosBll.GetList(p => true);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
        }
    }
}
