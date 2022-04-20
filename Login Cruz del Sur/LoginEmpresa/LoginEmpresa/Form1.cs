using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginEmpresa
{
    public partial class Form1 : Form
    {
        SQLControl sqlControl = new SQLControl();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int result = sqlControl.Login(txtUsuario.Text, txtPass.Text);

            if (result == 1)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
            }
            else if (result == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
