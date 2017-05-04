namespace TeknikServis
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLoginTemp = new System.Windows.Forms.Panel();
            this.pnlSifremiUnuttum = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnk_giriseGeriDon = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_EmaileSifreGonder = new DevExpress.XtraEditors.SimpleButton();
            this.txt_emailGonder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.btn_girisYap = new DevExpress.XtraEditors.SimpleButton();
            this.txt_sifre = new DevExpress.XtraEditors.TextEdit();
            this.lbl_email = new DevExpress.XtraEditors.LabelControl();
            this.txt_email = new DevExpress.XtraEditors.TextEdit();
            this.lbl_sifre = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lnk_sifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.pnlLoginTemp.SuspendLayout();
            this.pnlSifremiUnuttum.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginTemp
            // 
            this.pnlLoginTemp.Controls.Add(this.pnlSifremiUnuttum);
            this.pnlLoginTemp.Controls.Add(this.pnlGiris);
            this.pnlLoginTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginTemp.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginTemp.Name = "pnlLoginTemp";
            this.pnlLoginTemp.Size = new System.Drawing.Size(1348, 697);
            this.pnlLoginTemp.TabIndex = 0;
            // 
            // pnlSifremiUnuttum
            // 
            this.pnlSifremiUnuttum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlSifremiUnuttum.Controls.Add(this.panel1);
            this.pnlSifremiUnuttum.Controls.Add(this.btn_EmaileSifreGonder);
            this.pnlSifremiUnuttum.Controls.Add(this.txt_emailGonder);
            this.pnlSifremiUnuttum.Controls.Add(this.label1);
            this.pnlSifremiUnuttum.Location = new System.Drawing.Point(391, 186);
            this.pnlSifremiUnuttum.Name = "pnlSifremiUnuttum";
            this.pnlSifremiUnuttum.Size = new System.Drawing.Size(552, 318);
            this.pnlSifremiUnuttum.TabIndex = 2;
            this.pnlSifremiUnuttum.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lnk_giriseGeriDon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 76);
            this.panel1.TabIndex = 3;
            // 
            // lnk_giriseGeriDon
            // 
            this.lnk_giriseGeriDon.AutoSize = true;
            this.lnk_giriseGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnk_giriseGeriDon.Location = new System.Drawing.Point(380, 4);
            this.lnk_giriseGeriDon.Name = "lnk_giriseGeriDon";
            this.lnk_giriseGeriDon.Size = new System.Drawing.Size(164, 16);
            this.lnk_giriseGeriDon.TabIndex = 1;
            this.lnk_giriseGeriDon.TabStop = true;
            this.lnk_giriseGeriDon.Text = "<< Giriş Ekranına Geri Dön";
            this.lnk_giriseGeriDon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_giriseGeriDon_LinkClicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(125, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Emailine Şifreni Gönder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_EmaileSifreGonder
            // 
            this.btn_EmaileSifreGonder.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btn_EmaileSifreGonder.Appearance.Image")));
            this.btn_EmaileSifreGonder.Appearance.Options.UseImage = true;
            this.btn_EmaileSifreGonder.Image = ((System.Drawing.Image)(resources.GetObject("btn_EmaileSifreGonder.Image")));
            this.btn_EmaileSifreGonder.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_EmaileSifreGonder.Location = new System.Drawing.Point(261, 200);
            this.btn_EmaileSifreGonder.Name = "btn_EmaileSifreGonder";
            this.btn_EmaileSifreGonder.Size = new System.Drawing.Size(148, 59);
            this.btn_EmaileSifreGonder.TabIndex = 2;
            this.btn_EmaileSifreGonder.Text = "Gönder";
            this.btn_EmaileSifreGonder.Click += new System.EventHandler(this.btn_EmaileSifreGonder_Click);
            // 
            // txt_emailGonder
            // 
            this.txt_emailGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_emailGonder.Location = new System.Drawing.Point(191, 139);
            this.txt_emailGonder.Name = "txt_emailGonder";
            this.txt_emailGonder.Size = new System.Drawing.Size(218, 26);
            this.txt_emailGonder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(115, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // pnlGiris
            // 
            this.pnlGiris.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlGiris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGiris.Controls.Add(this.btn_girisYap);
            this.pnlGiris.Controls.Add(this.txt_sifre);
            this.pnlGiris.Controls.Add(this.lbl_email);
            this.pnlGiris.Controls.Add(this.txt_email);
            this.pnlGiris.Controls.Add(this.lbl_sifre);
            this.pnlGiris.Controls.Add(this.panel3);
            this.pnlGiris.Controls.Add(this.lnk_sifremiUnuttum);
            this.pnlGiris.Location = new System.Drawing.Point(409, 105);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(523, 436);
            this.pnlGiris.TabIndex = 1;
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_girisYap.Appearance.Options.UseFont = true;
            this.btn_girisYap.Image = ((System.Drawing.Image)(resources.GetObject("btn_girisYap.Image")));
            this.btn_girisYap.Location = new System.Drawing.Point(214, 302);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(197, 57);
            this.btn_girisYap.TabIndex = 17;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.EditValue = "123";
            this.txt_sifre.Location = new System.Drawing.Point(214, 214);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_sifre.Properties.Appearance.Options.UseFont = true;
            this.txt_sifre.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txt_sifre.Properties.PasswordChar = '*';
            this.txt_sifre.Properties.UseSystemPasswordChar = true;
            this.txt_sifre.Size = new System.Drawing.Size(197, 26);
            this.txt_sifre.TabIndex = 16;
            // 
            // lbl_email
            // 
            this.lbl_email.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_email.Location = new System.Drawing.Point(110, 168);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(51, 19);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.EditValue = "eyup@gevenim.com";
            this.txt_email.Location = new System.Drawing.Point(214, 161);
            this.txt_email.Name = "txt_email";
            this.txt_email.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_email.Properties.Appearance.Options.UseFont = true;
            this.txt_email.Size = new System.Drawing.Size(197, 26);
            this.txt_email.TabIndex = 15;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(110, 217);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(56, 20);
            this.lbl_sifre.TabIndex = 14;
            this.lbl_sifre.Text = "Parola:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 83);
            this.panel3.TabIndex = 12;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.CadetBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(521, 83);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Giriş Yap";
            // 
            // lnk_sifremiUnuttum
            // 
            this.lnk_sifremiUnuttum.AutoSize = true;
            this.lnk_sifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnk_sifremiUnuttum.Location = new System.Drawing.Point(303, 252);
            this.lnk_sifremiUnuttum.Name = "lnk_sifremiUnuttum";
            this.lnk_sifremiUnuttum.Size = new System.Drawing.Size(108, 17);
            this.lnk_sifremiUnuttum.TabIndex = 11;
            this.lnk_sifremiUnuttum.TabStop = true;
            this.lnk_sifremiUnuttum.Text = "Şifremi Unuttum";
            this.lnk_sifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_sifremiUnuttum_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 697);
            this.Controls.Add(this.pnlLoginTemp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "Giriş Formu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLoginTemp.ResumeLayout(false);
            this.pnlSifremiUnuttum.ResumeLayout(false);
            this.pnlSifremiUnuttum.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginTemp;
        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.LinkLabel lnk_sifremiUnuttum;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txt_sifre;
        private DevExpress.XtraEditors.LabelControl lbl_email;
        private DevExpress.XtraEditors.TextEdit txt_email;
        private DevExpress.XtraEditors.LabelControl lbl_sifre;
        private DevExpress.XtraEditors.SimpleButton btn_girisYap;
        private System.Windows.Forms.Panel pnlSifremiUnuttum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnk_giriseGeriDon;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_EmaileSifreGonder;
        private System.Windows.Forms.TextBox txt_emailGonder;
        private System.Windows.Forms.Label label1;
    }
}