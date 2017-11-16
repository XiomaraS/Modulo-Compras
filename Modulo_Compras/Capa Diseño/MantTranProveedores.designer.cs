namespace Proveedores1
{
    partial class MantTranProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantTranProveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_decrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_cuenta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_cod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_accion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // navegador1
            // 
            resources.ApplyResources(this.navegador1, "navegador1");
            this.navegador1.Name = "navegador1";
            this.navegador1.sNombreBD = null;
            this.navegador1.sNombreTabla = null;
            this.navegador1.sPass = null;
            this.navegador1.sResult = null;
            this.navegador1.sServidor = null;
            this.navegador1.sUsuario = null;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Txt_decrip
            // 
            resources.ApplyResources(this.Txt_decrip, "Txt_decrip");
            this.Txt_decrip.Name = "Txt_decrip";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Cmb_cuenta
            // 
            this.Cmb_cuenta.FormattingEnabled = true;
            resources.ApplyResources(this.Cmb_cuenta, "Cmb_cuenta");
            this.Cmb_cuenta.Name = "Cmb_cuenta";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Txt_cod
            // 
            resources.ApplyResources(this.Txt_cod, "Txt_cod");
            this.Txt_cod.Name = "Txt_cod";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Cmb_accion
            // 
            this.Cmb_accion.DisplayMember = "Accion";
            this.Cmb_accion.FormattingEnabled = true;
            this.Cmb_accion.Items.AddRange(new object[] {
            resources.GetString("Cmb_accion.Items"),
            resources.GetString("Cmb_accion.Items1")});
            resources.ApplyResources(this.Cmb_accion, "Cmb_accion");
            this.Cmb_accion.Name = "Cmb_accion";
            this.Cmb_accion.ValueMember = "Accion";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MantTranProveedores
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cmb_accion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_cod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_cuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_decrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "MantTranProveedores";
            this.Load += new System.EventHandler(this.MantTranProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Txt_decrip;
        public System.Windows.Forms.ComboBox Cmb_cuenta;
        public System.Windows.Forms.TextBox Txt_cod;
        public System.Windows.Forms.ComboBox Cmb_accion;
        private System.Windows.Forms.Button button2;
    }
}