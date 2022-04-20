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
    public partial class CP_Veterinarios : Form
    {
        public CP_Veterinarios()
        {
            InitializeComponent();
            mostrarvet();
        }

        private void mostrarvet()
        {
            CN_Veterinarios objeto = new CN_Veterinarios();
            dataGridView1.DataSource = objeto.MostrarVet();
        }

        private void buscarvet(string id)
        {
            CN_Veterinarios obj = new CN_Veterinarios();
            dataGridView1.DataSource = obj.BuscarVet(id);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarvet(textBox1.Text);
        }
    }
}
