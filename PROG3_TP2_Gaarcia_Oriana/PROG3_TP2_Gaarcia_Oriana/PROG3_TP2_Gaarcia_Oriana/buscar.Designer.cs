namespace PROG3_TP2_Gaarcia_Oriana
{
    partial class buscar
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.dgvBuscarDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(386, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(180, 26);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(176, 20);
            this.txbBusqueda.TabIndex = 1;
            // 
            // dgvBuscarDatos
            // 
            this.dgvBuscarDatos.AllowUserToAddRows = false;
            this.dgvBuscarDatos.AllowUserToDeleteRows = false;
            this.dgvBuscarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarDatos.Location = new System.Drawing.Point(35, 66);
            this.dgvBuscarDatos.MultiSelect = false;
            this.dgvBuscarDatos.Name = "dgvBuscarDatos";
            this.dgvBuscarDatos.ReadOnly = true;
            this.dgvBuscarDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarDatos.Size = new System.Drawing.Size(737, 264);
            this.dgvBuscarDatos.TabIndex = 2;
            // 
            // buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBuscarDatos);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Name = "buscar";
            this.Text = "buscar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.DataGridView dgvBuscarDatos;
    }
}