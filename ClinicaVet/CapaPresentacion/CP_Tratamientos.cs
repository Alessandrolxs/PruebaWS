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
    public partial class CP_Tratamientos : Form
    {
        public CP_Tratamientos()
        {
            InitializeComponent();
            mostrartrat();
        }

        private void mostrartrat()
        {
            CN_Tratamientos objeto = new CN_Tratamientos();
            dataGridView1.DataSource = objeto.MostrarTrat();
        }

        private void buscartrat(string id)
        {
            CN_Tratamientos obj = new CN_Tratamientos();
            dataGridView1.DataSource = obj.BuscarTrat(id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscartrat(textBox1.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
