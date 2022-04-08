using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Solucion
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NCategoria.Listar();
                this.Formato();
                LblTotal.Text = "Total Registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[3].Width = 400;
            DgvListado.Columns[3].HeaderText = "Descripcion";

            DgvListado.Columns[4].Width = 100;
        }


        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
