namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btnconectar = new System.Windows.Forms.Button();
            this.btnlistar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.gridListar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridListar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO DE TABLA PERSONAS";
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(36, 76);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(49, 13);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "CODIGO";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(36, 145);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(54, 13);
            this.txt2.TabIndex = 2;
            this.txt2.Text = "NOMBRE";
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Location = new System.Drawing.Point(36, 210);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(36, 13);
            this.txt3.TabIndex = 3;
            this.txt3.Text = "SEXO";
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.Location = new System.Drawing.Point(35, 278);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(37, 13);
            this.txt4.TabIndex = 4;
            this.txt4.Text = "EDAD";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(39, 92);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(119, 20);
            this.txtcodigo.TabIndex = 5;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(39, 161);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(119, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(39, 226);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(119, 20);
            this.txtsexo.TabIndex = 7;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(39, 294);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(119, 20);
            this.txtedad.TabIndex = 8;
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(15, 366);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(75, 23);
            this.btnconectar.TabIndex = 9;
            this.btnconectar.Text = "CONECTAR";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(122, 366);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(75, 23);
            this.btnlistar.TabIndex = 10;
            this.btnlistar.Text = "LISTAR";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(226, 366);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 11;
            this.btninsertar.Text = "INSERTAR";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(326, 366);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(428, 366);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 13;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // gridListar
            // 
            this.gridListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListar.Location = new System.Drawing.Point(204, 63);
            this.gridListar.Name = "gridListar";
            this.gridListar.Size = new System.Drawing.Size(479, 284);
            this.gridListar.TabIndex = 14;
            this.gridListar.SelectionChanged += new System.EventHandler(this.gridListar_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridListar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CRUD 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.Label txt4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.DataGridView gridListar;
    }
}

