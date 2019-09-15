namespace PROG3_TP2_Gaarcia_Oriana
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_articulos = new System.Windows.Forms.ToolStripSplitButton();
            this.item_agregar = new System.Windows.Forms.ToolStripMenuItem();
            this.item_modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.item_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_listados = new System.Windows.Forms.ToolStripDropDownButton();
            this.pORPRECIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_busquedas = new System.Windows.Forms.ToolStripDropDownButton();
            this.pORCODIGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btn_articulos,
            this.toolStripSeparator2,
            this.btn_listados,
            this.toolStripSeparator3,
            this.btn_busquedas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // btn_articulos
            // 
            this.btn_articulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_articulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_agregar,
            this.item_modificar,
            this.item_eliminar});
            this.btn_articulos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_articulos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_articulos.Name = "btn_articulos";
            this.btn_articulos.Size = new System.Drawing.Size(143, 34);
            this.btn_articulos.Text = "ARTICULOS";
            this.btn_articulos.ToolTipText = "ARTICULOS";
            // 
            // item_agregar
            // 
            this.item_agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_agregar.Name = "item_agregar";
            this.item_agregar.Size = new System.Drawing.Size(190, 30);
            this.item_agregar.Text = "AGREGAR";
            this.item_agregar.Click += new System.EventHandler(this.Item_agregar_Click);
            // 
            // item_modificar
            // 
            this.item_modificar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_modificar.Name = "item_modificar";
            this.item_modificar.Size = new System.Drawing.Size(190, 30);
            this.item_modificar.Text = "MODIFICAR";
            this.item_modificar.Click += new System.EventHandler(this.Item_modificar_Click);
            // 
            // item_eliminar
            // 
            this.item_eliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_eliminar.Name = "item_eliminar";
            this.item_eliminar.Size = new System.Drawing.Size(190, 30);
            this.item_eliminar.Text = "ELIMINAR";
            this.item_eliminar.Click += new System.EventHandler(this.Item_eliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // btn_listados
            // 
            this.btn_listados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_listados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pORPRECIOToolStripMenuItem});
            this.btn_listados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_listados.Name = "btn_listados";
            this.btn_listados.Size = new System.Drawing.Size(96, 34);
            this.btn_listados.Text = "LISTAR";
            this.btn_listados.Click += new System.EventHandler(this.Btn_listados_Click);
            // 
            // pORPRECIOToolStripMenuItem
            // 
            this.pORPRECIOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pORPRECIOToolStripMenuItem.Name = "pORPRECIOToolStripMenuItem";
            this.pORPRECIOToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.pORPRECIOToolStripMenuItem.Text = "TODOS LOS ARTICULOS";
            this.pORPRECIOToolStripMenuItem.Click += new System.EventHandler(this.PORPRECIOToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // btn_busquedas
            // 
            this.btn_busquedas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_busquedas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pORCODIGOToolStripMenuItem});
            this.btn_busquedas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busquedas.Image = ((System.Drawing.Image)(resources.GetObject("btn_busquedas.Image")));
            this.btn_busquedas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_busquedas.Name = "btn_busquedas";
            this.btn_busquedas.Size = new System.Drawing.Size(108, 34);
            this.btn_busquedas.Text = "BUSCAR";
            // 
            // pORCODIGOToolStripMenuItem
            // 
            this.pORCODIGOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pORCODIGOToolStripMenuItem.Name = "pORCODIGOToolStripMenuItem";
            this.pORCODIGOToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pORCODIGOToolStripMenuItem.Text = "POR CODIGO";
            this.pORCODIGOToolStripMenuItem.Click += new System.EventHandler(this.PORCODIGOToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Gestor de Articulos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton btn_articulos;
        private System.Windows.Forms.ToolStripMenuItem item_agregar;
        private System.Windows.Forms.ToolStripMenuItem item_modificar;
        private System.Windows.Forms.ToolStripMenuItem item_eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton btn_listados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton btn_busquedas;
        private System.Windows.Forms.ToolStripMenuItem pORPRECIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pORCODIGOToolStripMenuItem;
    }
}

