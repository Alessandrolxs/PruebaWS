﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void BuscarProductos(string id)
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.BuscarProd(id);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar==false)
            {
            try
            {
                objetoCN.InsertarProd(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                MessageBox.Show("Datos insertados correctamente!!");
                MostrarProductos();
                    limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no insertados correctamente!!!" + ex);
            }
            }
            if (Editar== true)
            {
                try
                {
                    objetoCN.EditarProd(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                    MessageBox.Show("Datos editados correctamente !");
                    MostrarProductos();
                    limpiar();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede insertar los datos por: " + ex);
                }
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

                objetoCN.ElimProd(idProducto);
                MessageBox.Show("Datos eliminados correctamente !");
                MostrarProductos();
                limpiar();

            }
            else
            {
                MessageBox.Show("Seleccione una fila !");
            }
        }

        private void limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarProductos(txtbuscar.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
