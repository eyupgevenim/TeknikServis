namespace TeknikServis
{
    partial class pnlTeknikServisTakibi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlTeknikServisTakibi));
            this.pnlArizaTemp = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btn_servistebulunan = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_eskiKayitlar = new DevExpress.XtraEditors.SimpleButton();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArizaTemp
            // 
            this.pnlArizaTemp.Location = new System.Drawing.Point(247, 0);
            this.pnlArizaTemp.Name = "pnlArizaTemp";
            this.pnlArizaTemp.Size = new System.Drawing.Size(1101, 646);
            this.pnlArizaTemp.TabIndex = 3;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btn_servistebulunan);
            this.pnlMenu.Controls.Add(this.simpleButton1);
            this.pnlMenu.Controls.Add(this.btn_eskiKayitlar);
            this.pnlMenu.Location = new System.Drawing.Point(1, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 649);
            this.pnlMenu.TabIndex = 2;
            // 
            // btn_servistebulunan
            // 
            this.btn_servistebulunan.Image = ((System.Drawing.Image)(resources.GetObject("btn_servistebulunan.Image")));
            this.btn_servistebulunan.Location = new System.Drawing.Point(23, 35);
            this.btn_servistebulunan.Name = "btn_servistebulunan";
            this.btn_servistebulunan.Size = new System.Drawing.Size(196, 62);
            this.btn_servistebulunan.TabIndex = 12;
            this.btn_servistebulunan.Text = "Serviste Bulunanlar";
            this.btn_servistebulunan.Click += new System.EventHandler(this.btn_servistebulunan_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(23, 561);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(196, 62);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Ana Menü";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_eskiKayitlar
            // 
            this.btn_eskiKayitlar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eskiKayitlar.Image")));
            this.btn_eskiKayitlar.Location = new System.Drawing.Point(23, 117);
            this.btn_eskiKayitlar.Name = "btn_eskiKayitlar";
            this.btn_eskiKayitlar.Size = new System.Drawing.Size(196, 62);
            this.btn_eskiKayitlar.TabIndex = 9;
            this.btn_eskiKayitlar.Text = "Eski Kayıtlar";
            this.btn_eskiKayitlar.Click += new System.EventHandler(this.btn_eskiKayitlar_Click);
            // 
            // pnlTeknikServisTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlArizaTemp);
            this.Controls.Add(this.pnlMenu);
            this.Name = "pnlTeknikServisTakibi";
            this.Size = new System.Drawing.Size(1348, 649);
            this.Load += new System.EventHandler(this.pnlTeknikServisTakibi_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_eskiKayitlar;
        private DevExpress.XtraEditors.SimpleButton btn_servistebulunan;
        public System.Windows.Forms.Panel pnlArizaTemp;
    }
}
