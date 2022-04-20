using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class CP_Citas : Form
    {
        CN_Propiertarios objetoCN = new CN_Propiertarios();
        public CP_Citas()
        {
            InitializeComponent();
            mostrarcitas();
        }

        private void mostrarcitas()
        {
            CN_Citas objeto = new CN_Citas();
            dataGridView1.DataSource = objeto.MostrarCit();
        }

        private void buscarcitas(string id)
        {
            CN_Citas objeto = new CN_Citas();
            dataGridView1.DataSource = objeto.BuscarCit(id);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarcitas(textBox1.Text);
        }
    }
}
