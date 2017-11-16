namespace capa_Diseño
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeSaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiguedadDeSaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeSaldosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.antiguedadDeSaldosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientes,
            this.proveedoresToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientes
            // 
            this.clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDeSaldosToolStripMenuItem});
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(61, 20);
            this.clientes.Text = "Clientes";
            // 
            // informacionDeSaldosToolStripMenuItem
            // 
            this.informacionDeSaldosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antiguedadDeSaldosToolStripMenuItem});
            this.informacionDeSaldosToolStripMenuItem.Name = "informacionDeSaldosToolStripMenuItem";
            this.informacionDeSaldosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.informacionDeSaldosToolStripMenuItem.Text = "Informacion de Saldos";
            // 
            // antiguedadDeSaldosToolStripMenuItem
            // 
            this.antiguedadDeSaldosToolStripMenuItem.Name = "antiguedadDeSaldosToolStripMenuItem";
            this.antiguedadDeSaldosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.antiguedadDeSaldosToolStripMenuItem.Text = "Antiguedad de Saldos";
            this.antiguedadDeSaldosToolStripMenuItem.Click += new System.EventHandler(this.antiguedadDeSaldosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDeSaldosToolStripMenuItem1});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // informacionDeSaldosToolStripMenuItem1
            // 
            this.informacionDeSaldosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antiguedadDeSaldosToolStripMenuItem1});
            this.informacionDeSaldosToolStripMenuItem1.Name = "informacionDeSaldosToolStripMenuItem1";
            this.informacionDeSaldosToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.informacionDeSaldosToolStripMenuItem1.Text = "Informacion de Saldos";
            // 
            // antiguedadDeSaldosToolStripMenuItem1
            // 
            this.antiguedadDeSaldosToolStripMenuItem1.Name = "antiguedadDeSaldosToolStripMenuItem1";
            this.antiguedadDeSaldosToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.antiguedadDeSaldosToolStripMenuItem1.Text = "Antiguedad de Saldos";
            this.antiguedadDeSaldosToolStripMenuItem1.Click += new System.EventHandler(this.antiguedadDeSaldosToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porClientesToolStripMenuItem,
            this.porProveedoresToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // porClientesToolStripMenuItem
            // 
            this.porClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.porClientesToolStripMenuItem.Name = "porClientesToolStripMenuItem";
            this.porClientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.porClientesToolStripMenuItem.Text = "Condensado";
            // 
            // porProveedoresToolStripMenuItem
            // 
            this.porProveedoresToolStripMenuItem.Name = "porProveedoresToolStripMenuItem";
            this.porProveedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.porProveedoresToolStripMenuItem.Text = "General";
            this.porProveedoresToolStripMenuItem.Click += new System.EventHandler(this.porProveedoresToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 342);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Antiguedad de Saldos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientes;
        private System.Windows.Forms.ToolStripMenuItem informacionDeSaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiguedadDeSaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDeSaldosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem antiguedadDeSaldosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
    }
}

