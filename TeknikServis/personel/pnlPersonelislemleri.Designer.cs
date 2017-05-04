namespace TeknikServis
{
    partial class pnlPersonelislemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlPersonelislemleri));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btn_anaSayfayaGeriDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelGoruntule = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.pnlPersonelIslemTemp = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btn_anaSayfayaGeriDon);
            this.pnlMenu.Controls.Add(this.btnPersonelGoruntule);
            this.pnlMenu.Controls.Add(this.btnPersonelEkle);
            this.pnlMenu.Location = new System.Drawing.Point(3, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 649);
            this.pnlMenu.TabIndex = 0;
            // 
            // btn_anaSayfayaGeriDon
            // 
            this.btn_anaSayfayaGeriDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_anaSayfayaGeriDon.Image")));
            this.btn_anaSayfayaGeriDon.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_anaSayfayaGeriDon.Location = new System.Drawing.Point(17, 555);
            this.btn_anaSayfayaGeriDon.Name = "btn_anaSayfayaGeriDon";
            this.btn_anaSayfayaGeriDon.Size = new System.Drawing.Size(198, 60);
            this.btn_anaSayfayaGeriDon.TabIndex = 2;
            this.btn_anaSayfayaGeriDon.Text = "Anasayfa";
            this.btn_anaSayfayaGeriDon.Click += new System.EventHandler(this.btn_anaSayfayaGeriDon_Click);
            // 
            // btnPersonelGoruntule
            // 
            this.btnPersonelGoruntule.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelGoruntule.Image")));
            this.btnPersonelGoruntule.Location = new System.Drawing.Point(17, 102);
            this.btnPersonelGoruntule.Name = "btnPersonelGoruntule";
            this.btnPersonelGoruntule.Size = new System.Drawing.Size(198, 62);
            this.btnPersonelGoruntule.TabIndex = 1;
            this.btnPersonelGoruntule.Text = "Personel Görüntüleme";
            this.btnPersonelGoruntule.Click += new System.EventHandler(this.btnPersonelGoruntule_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelEkle.Image")));
            this.btnPersonelEkle.Location = new System.Drawing.Point(17, 25);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(198, 62);
            this.btnPersonelEkle.TabIndex = 0;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // pnlPersonelIslemTemp
            // 
            this.pnlPersonelIslemTemp.Location = new System.Drawing.Point(249, 0);
            this.pnlPersonelIslemTemp.Name = "pnlPersonelIslemTemp";
            this.pnlPersonelIslemTemp.Size = new System.Drawing.Size(1101, 646);
            this.pnlPersonelIslemTemp.TabIndex = 1;
            // 
            // pnlPersonelislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPersonelIslemTemp);
            this.Controls.Add(this.pnlMenu);
            this.Name = "pnlPersonelislemleri";
            this.Size = new System.Drawing.Size(1350, 649);
            this.Load += new System.EventHandler(this.pnlPersonelislemleri_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlPersonelIslemTemp;
        private DevExpress.XtraEditors.SimpleButton btnPersonelEkle;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGoruntule;
        private DevExpress.XtraEditors.SimpleButton btn_anaSayfayaGeriDon;
    }
}
