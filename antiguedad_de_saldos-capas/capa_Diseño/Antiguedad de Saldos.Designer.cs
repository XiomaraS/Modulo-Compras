namespace Antiguedad_de_saldos
{
    partial class saldos
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
            this.informacionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDeSaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiguedadDeSaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDeSaldosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.antiguedadDeSaldosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDeClientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // informacionDeClientesToolStripMenuItem
            // 
            this.informacionDeClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónDeSaldosToolStripMenuItem});
            this.informacionDeClientesToolStripMenuItem.Name = "informacionDeClientesToolStripMenuItem";
            this.informacionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.informacionDeClientesToolStripMenuItem.Text = "Clientes";
            // 
            // informaciónDeSaldosToolStripMenuItem
            // 
            this.informaciónDeSaldosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antiguedadDeSaldosToolStripMenuItem});
            this.informaciónDeSaldosToolStripMenuItem.Name = "informaciónDeSaldosToolStripMenuItem";
            this.informaciónDeSaldosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.informaciónDeSaldosToolStripMenuItem.Text = "Información de Saldos";
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
            this.informaciónDeSaldosToolStripMenuItem1});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // informaciónDeSaldosToolStripMenuItem1
            // 
            this.informaciónDeSaldosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antiguedadDeSaldosToolStripMenuItem1});
            this.informaciónDeSaldosToolStripMenuItem1.Name = "informaciónDeSaldosToolStripMenuItem1";
            this.informaciónDeSaldosToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.informaciónDeSaldosToolStripMenuItem1.Text = "Información de Saldos";
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
            this.porClientesToolStripMenuItem.Name = "porClientesToolStripMenuItem";
            this.porClientesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.porClientesToolStripMenuItem.Text = "Condensado";
            this.porClientesToolStripMenuItem.Click += new System.EventHandler(this.porClientesToolStripMenuItem_Click);
            // 
            // porProveedoresToolStripMenuItem
            // 
            this.porProveedoresToolStripMenuItem.Name = "porProveedoresToolStripMenuItem";
            this.porProveedoresToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.porProveedoresToolStripMenuItem.Text = "General";
            // 
            // saldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 342);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "saldos";
            this.Text = "Antiguedad de Saldos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informacionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDeSaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiguedadDeSaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDeSaldosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem antiguedadDeSaldosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porProveedoresToolStripMenuItem;
    }
}

