using CotizarArticulos.UI.Consultas;
using CotizarArticulos.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizarArticulos
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RArticulos rArticulos = new RArticulos();

            rArticulos.Show();
            rArticulos.MdiParent = this;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RConsulta rConsulta = new RConsulta();
            rConsulta.Show();
            rConsulta.MdiParent = this;
        }

       
    }
}
