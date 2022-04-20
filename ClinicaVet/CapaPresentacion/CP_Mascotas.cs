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
    public partial class CP_Mascotas : Form
    {
        public CP_Mascotas()
        {
            InitializeComponent();
            mostrarmascotas();
        }

        private void mostrarmascotas()
        {
            CN_Mascotas objeto = new CN_Mascotas();
            dataGridView1.DataSource = objeto.MostrarMas();
        }

        private void buscaramas(string id)
        {
            CN_Mascotas obj = new CN_Mascotas();
            dataGridView1.DataSource = obj.BuscarMas(id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscaramas(textBox1.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
