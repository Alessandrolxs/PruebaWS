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
    public partial class CP_Propietarios : Form
    {
        CN_Propiertarios objetoCN = new CN_Propiertarios();
        public CP_Propietarios()
        {
            InitializeComponent();

        }

        private void MostrarPropietarios()
        {
            CN_Propiertarios objeto = new CN_Propiertarios();
            dataGridView1.DataSource = objeto.MostrarPro();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CP_Propietarios_Load(object sender, EventArgs e)
        {
            MostrarPropietarios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CP_Propietarios_Load_1(object sender, EventArgs e)
        {
            MostrarPropietarios();
        }
    }
}
