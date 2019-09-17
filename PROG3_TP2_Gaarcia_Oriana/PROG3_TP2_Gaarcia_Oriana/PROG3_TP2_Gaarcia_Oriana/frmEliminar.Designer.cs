namespace PROG3_TP2_Gaarcia_Oriana
{
    partial class frmEliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(185, 47);
            this.txbCodigo.Multiline = true;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(129, 24);
            this.txbCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(404, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Enabled = false;
            this.txbPrecio.Location = new System.Drawing.Point(185, 362);
            this.txbPrecio.Multiline = true;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(129, 24);
            this.txbPrecio.TabIndex = 8;
            // 
            // txbCategoria
            // 
            this.txbCategoria.Enabled = false;
            this.txbCategoria.Location = new System.Drawing.Point(185, 240);
            this.txbCategoria.Multiline = true;
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(129, 24);
            this.txbCategoria.TabIndex = 9;
            // 
            // txbMarca
            // 
            this.txbMarca.Enabled = false;
            this.txbMarca.Location = new System.Drawing.Point(185, 182);
            this.txbMarca.Multiline = true;
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(129, 24);
            this.txbMarca.TabIndex = 10;
            // 
            // txbNombre
            // 
            this.txbNombre.Enabled = false;
            this.txbNombre.Location = new System.Drawing.Point(185, 109);
            this.txbNombre.Multiline = true;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(129, 24);
            this.txbNombre.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(404, 360);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txbDesc
            // 
            this.txbDesc.Enabled = false;
            this.txbDesc.Location = new System.Drawing.Point(185, 280);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(129, 63);
            this.txbDesc.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripcion";
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(404, 99);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(75, 39);
            this.btnArticulos.TabIndex = 15;
            this.btnArticulos.Text = "Listado de Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click);
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCodigo);
            this.Name = "frmEliminar";
            this.Text = "Eliminar Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnArticulos;
    }
}