namespace TeknikServis
{
    partial class pnlMusteriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlMusteriIslemleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_musteriAra = new DevExpress.XtraEditors.SimpleButton();
            this.btn_anaSayfayaGeriDon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_firmaArama = new DevExpress.XtraEditors.SimpleButton();
            this.btn_firmaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_musteriEkle = new DevExpress.XtraEditors.SimpleButton();
            this.pnlMusteriIslemTemp = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_musteriAra);
            this.panel1.Controls.Add(this.btn_anaSayfayaGeriDon);
            this.panel1.Controls.Add(this.btn_firmaArama);
            this.panel1.Controls.Add(this.btn_firmaEkle);
            this.panel1.Controls.Add(this.btn_musteriEkle);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 649);
            this.panel1.TabIndex = 0;
            // 
            // btn_musteriAra
            // 
            this.btn_musteriAra.Image = ((System.Drawing.Image)(resources.GetObject("btn_musteriAra.Image")));
            this.btn_musteriAra.Location = new System.Drawing.Point(31, 104);
            this.btn_musteriAra.Name = "btn_musteriAra";
            this.btn_musteriAra.Size = new System.Drawing.Size(173, 53);
            this.btn_musteriAra.TabIndex = 4;
            this.btn_musteriAra.Text = "Müşteri Arama";
            this.btn_musteriAra.Click += new System.EventHandler(this.btn_musteriAra_Click);
            // 
            // btn_anaSayfayaGeriDon
            // 
            this.btn_anaSayfayaGeriDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_anaSayfayaGeriDon.Image")));
            this.btn_anaSayfayaGeriDon.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_anaSayfayaGeriDon.Location = new System.Drawing.Point(31, 572);
            this.btn_anaSayfayaGeriDon.Name = "btn_anaSayfayaGeriDon";
            this.btn_anaSayfayaGeriDon.Size = new System.Drawing.Size(173, 51);
            this.btn_anaSayfayaGeriDon.TabIndex = 3;
            this.btn_anaSayfayaGeriDon.Text = "Anasayfa";
            this.btn_anaSayfayaGeriDon.Click += new System.EventHandler(this.btn_anaSayfayaGeriDon_Click);
            // 
            // btn_firmaArama
            // 
            this.btn_firmaArama.Image = ((System.Drawing.Image)(resources.GetObject("btn_firmaArama.Image")));
            this.btn_firmaArama.Location = new System.Drawing.Point(31, 264);
            this.btn_firmaArama.Name = "btn_firmaArama";
            this.btn_firmaArama.Size = new System.Drawing.Size(173, 53);
            this.btn_firmaArama.TabIndex = 2;
            this.btn_firmaArama.Text = "Firmaları Listeleme";
            this.btn_firmaArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btn_firmaEkle
            // 
            this.btn_firmaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_firmaEkle.Image")));
            this.btn_firmaEkle.Location = new System.Drawing.Point(31, 184);
            this.btn_firmaEkle.Name = "btn_firmaEkle";
            this.btn_firmaEkle.Size = new System.Drawing.Size(173, 53);
            this.btn_firmaEkle.TabIndex = 1;
            this.btn_firmaEkle.Text = "Firma Ekle";
            this.btn_firmaEkle.Click += new System.EventHandler(this.btnFirmaekle_Click);
            // 
            // btn_musteriEkle
            // 
            this.btn_musteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_musteriEkle.Image")));
            this.btn_musteriEkle.Location = new System.Drawing.Point(31, 35);
            this.btn_musteriEkle.Name = "btn_musteriEkle";
            this.btn_musteriEkle.Size = new System.Drawing.Size(173, 53);
            this.btn_musteriEkle.TabIndex = 0;
            this.btn_musteriEkle.Text = "Müşteri Ekle";
            this.btn_musteriEkle.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlMusteriIslemTemp
            // 
            this.pnlMusteriIslemTemp.Location = new System.Drawing.Point(249, 3);
            this.pnlMusteriIslemTemp.Name = "pnlMusteriIslemTemp";
            this.pnlMusteriIslemTemp.Size = new System.Drawing.Size(1101, 649);
            this.pnlMusteriIslemTemp.TabIndex = 1;
            // 
            // pnlMusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMusteriIslemTemp);
            this.Controls.Add(this.panel1);
            this.Name = "pnlMusteriIslemleri";
            this.Size = new System.Drawing.Size(1350, 657);
            this.Load += new System.EventHandler(this.pnlMusteriIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_musteriEkle;
        private DevExpress.XtraEditors.SimpleButton btn_firmaEkle;
        private DevExpress.XtraEditors.SimpleButton btn_firmaArama;
        private DevExpress.XtraEditors.SimpleButton btn_anaSayfayaGeriDon;
        private System.Windows.Forms.Panel pnlMusteriIslemTemp;
        private DevExpress.XtraEditors.SimpleButton btn_musteriAra;
    }
}
