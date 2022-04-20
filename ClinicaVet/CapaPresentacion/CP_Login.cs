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
    public partial class CP_Login : Form
    {

        CapaEntidad.Class1 obje = new CapaEntidad.Class1();
        CapaNegocio.CN_Login objn = new CapaNegocio.CN_Login();
        public CP_Login()
        {
            InitializeComponent();

            Bitmap img = new Bitmap(Application.StartupPath + @"/img/dog.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void CP_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            obje.usu1 = txtusuario.Text;
            obje.pas1 = txtcontra.Text;
            dt = objn.N_Login(obje);

            if (dt.Rows.Count > 0)
            {

                obje.usu1 = dt.Rows[0][0].ToString();
                obje.pas1 = dt.Rows[0][1].ToString();
                MessageBox.Show("Bienvenido " + obje.usu1);

                this.Hide();
                CP_MenuPrin pri = new CP_MenuPrin();
                pri.Show();
            }
            else
            {
                MessageBox.Show("Error al Inicar Session !!");
            }
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            txtusuario.Clear();
            txtcontra.Clear();
            txtusuario.Select();
        }
    }
}
