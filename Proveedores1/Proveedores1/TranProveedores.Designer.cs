namespace Proveedores1
{
    partial class TranProveedores
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
            this.Dgv_TranProv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TranProv)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_TranProv
            // 
            this.Dgv_TranProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TranProv.Location = new System.Drawing.Point(12, 213);
            this.Dgv_TranProv.Name = "Dgv_TranProv";
            this.Dgv_TranProv.Size = new System.Drawing.Size(628, 150);
            this.Dgv_TranProv.TabIndex = 0;
            this.Dgv_TranProv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_TranProv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transacciones Proveedores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nueva Transaccion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TranProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(672, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_TranProv);
            this.Name = "TranProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "6203 Transacciones Proveedores";
            this.Load += new System.EventHandler(this.TranProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TranProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_TranProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}