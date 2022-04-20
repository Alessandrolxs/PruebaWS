using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CP_MenuPrin : Form
    {
        public CP_MenuPrin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CP_Login form = new CP_Login();
            form.Show();

        }

        private Form formactivado = null;
        private void abrirform(Form hijo)
        {
            if (formactivado != null)
                formactivado.Close();
            formactivado = hijo;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            wrapper.Controls.Add(hijo);
            wrapper.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirform(new CP_Propietarios());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirform(new CP_Mascotas());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirform(new CP_Citas());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirform(new CP_Tratamientos());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirform(new CP_Veterinarios());
        }
    }
}
