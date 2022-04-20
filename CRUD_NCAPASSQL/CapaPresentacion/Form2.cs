using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        private string idProducto = null;
        private bool Editar = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarCli(txtnombre.Text, txtapellido.Text, txttelef.Text, txtnumped.Text, txtidped.Text);
                    MessageBox.Show("Datos insertados correctamente!!");
                    mostrar();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datos no insertados correctamente!!!" + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarCli(txtnombre.Text, txtapellido.Text, txttelef.Text, txtnumped.Text, txtidped.Text, idProducto);
                    MessageBox.Show("Datos editados correctamente !");
                    mostrar();
                    limpiar();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar los datos por: " + ex);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void mostrar()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView1.DataSource = objeto.MostrarCli();
        }

        public void buscar(string id)
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView1.DataSource = objeto.BuscarCli(id);
        }

        private void limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txttelef.Clear();
            txtnumped.Clear();
            txtidped.Clear();
            txtnombre.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtnombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtapellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txttelef.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtnumped.Text = dataGridView1.CurrentRow.Cells["Num_pedido"].Value.ToString();
                txtidped.Text = dataGridView1.CurrentRow.Cells["Id_pedido"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

                objetoCN.ElimCli(idProducto);
                MessageBox.Show("Datos eliminados correctamente !");
                mostrar();
                limpiar();

            }
            else
            {
                MessageBox.Show("Seleccione una fila !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscar(txtbuscar.Text);
        }
    }
}
