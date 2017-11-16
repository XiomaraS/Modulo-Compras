namespace Proveedores1
{
    partial class reporte
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
            this.ReportMovi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.movimientosproveedores1 = new Proveedores1.movimientosproveedores();
            this.SuspendLayout();
            // 
            // ReportMovi
            // 
            this.ReportMovi.ActiveViewIndex = 0;
            this.ReportMovi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportMovi.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportMovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportMovi.Location = new System.Drawing.Point(0, 0);
            this.ReportMovi.Name = "ReportMovi";
            this.ReportMovi.ReportSource = this.movimientosproveedores1;
            this.ReportMovi.Size = new System.Drawing.Size(755, 382);
            this.ReportMovi.TabIndex = 0;
            this.ReportMovi.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 382);
            this.Controls.Add(this.ReportMovi);
            this.Name = "reporte";
            this.Text = "reporte";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer ReportMovi;
        private movimientosproveedores movimientosproveedores1;
    }
}