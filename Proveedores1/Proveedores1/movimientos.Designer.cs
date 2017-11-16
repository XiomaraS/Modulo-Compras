namespace Proveedores1
{
    partial class movimientos
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmb_nomprov = new System.Windows.Forms.ComboBox();
            this.Cmb_prov = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_saldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_pago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_codTran = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha_venc = new System.Windows.Forms.DateTimePicker();
            this.Cmb_nom = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento Movimiento Proveedores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmb_nomprov);
            this.groupBox1.Controls.Add(this.Cmb_prov);
            this.groupBox1.Location = new System.Drawing.Point(35, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // Cmb_nomprov
            // 
            this.Cmb_nomprov.FormattingEnabled = true;
            this.Cmb_nomprov.Location = new System.Drawing.Point(267, 20);
            this.Cmb_nomprov.Name = "Cmb_nomprov";
            this.Cmb_nomprov.Size = new System.Drawing.Size(166, 21);
            this.Cmb_nomprov.TabIndex = 1;
            // 
            // Cmb_prov
            // 
            this.Cmb_prov.FormattingEnabled = true;
            this.Cmb_prov.Location = new System.Drawing.Point(124, 20);
            this.Cmb_prov.Name = "Cmb_prov";
            this.Cmb_prov.Size = new System.Drawing.Size(89, 21);
            this.Cmb_prov.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cmb_nom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fecha_ingreso);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_saldo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Txt_pago);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Cmb_codTran);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(35, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimiento";
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.CustomFormat = "MM/DD/YYYY";
            this.fecha_ingreso.Location = new System.Drawing.Point(102, 123);
            this.fecha_ingreso.Name = "fecha_ingreso";
            this.fecha_ingreso.Size = new System.Drawing.Size(122, 20);
            this.fecha_ingreso.TabIndex = 10;
            this.fecha_ingreso.Value = new System.DateTime(2017, 11, 6, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "fecha";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Txt_saldo
            // 
            this.Txt_saldo.Location = new System.Drawing.Point(124, 83);
            this.Txt_saldo.Name = "Txt_saldo";
            this.Txt_saldo.Size = new System.Drawing.Size(100, 20);
            this.Txt_saldo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saldo";
            // 
            // Txt_pago
            // 
            this.Txt_pago.Location = new System.Drawing.Point(364, 83);
            this.Txt_pago.Name = "Txt_pago";
            this.Txt_pago.Size = new System.Drawing.Size(120, 20);
            this.Txt_pago.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago";
            // 
            // Cmb_codTran
            // 
            this.Cmb_codTran.FormattingEnabled = true;
            this.Cmb_codTran.Location = new System.Drawing.Point(124, 36);
            this.Cmb_codTran.Name = "Cmb_codTran";
            this.Cmb_codTran.Size = new System.Drawing.Size(89, 21);
            this.Cmb_codTran.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cod. Transaccion";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(55, 49);
            this.navegador1.Name = "navegador1";
            this.navegador1.nombreBD = null;
            this.navegador1.nombreTabla = null;
            this.navegador1.pass = null;
            this.navegador1.servidor = null;
            this.navegador1.Size = new System.Drawing.Size(559, 47);
            this.navegador1.TabIndex = 3;
            this.navegador1.usuario = null;
            this.navegador1.InsertReceive += new System.EventHandler(this.navegador1_InsertReceive);
            this.navegador1.UpdateReceive += new System.EventHandler(this.navegador1_UpdateReceive);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Vencimiento";
            // 
            // fecha_venc
            // 
            this.fecha_venc.Location = new System.Drawing.Point(399, 357);
            this.fecha_venc.Name = "fecha_venc";
            this.fecha_venc.Size = new System.Drawing.Size(144, 20);
            this.fecha_venc.TabIndex = 12;
            // 
            // Cmb_nom
            // 
            this.Cmb_nom.FormattingEnabled = true;
            this.Cmb_nom.Location = new System.Drawing.Point(256, 36);
            this.Cmb_nom.Name = "Cmb_nom";
            this.Cmb_nom.Size = new System.Drawing.Size(148, 21);
            this.Cmb_nom.TabIndex = 12;
            // 
            // movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(653, 504);
            this.Controls.Add(this.fecha_venc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "movimientos";
            this.Text = "6202 Mantenimiento Movimiento Proveedores";
            this.Load += new System.EventHandler(this.movimientos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Navegador.Navegador navegador1;
        public System.Windows.Forms.DateTimePicker fecha_ingreso;
        public System.Windows.Forms.TextBox Txt_saldo;
        public System.Windows.Forms.TextBox Txt_pago;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox Cmb_prov;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox Cmb_nomprov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fecha_venc;
        public System.Windows.Forms.ComboBox Cmb_codTran;
        public System.Windows.Forms.ComboBox Cmb_nom;
    }
}