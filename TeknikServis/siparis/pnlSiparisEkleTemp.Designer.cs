//using System;

namespace TeknikServis
{
    partial class pnlSiparisEkleTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlSiparisEkleTemp));
            this.btn_ileri = new DevExpress.XtraEditors.SimpleButton();
            this.btn_geri = new DevExpress.XtraEditors.SimpleButton();
            this.btn_tamam = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_degistir= new DevExpress.XtraEditors.SimpleButton();
            this.pnlSiparisEkle2 = new TeknikServis.pnlSiparisEkle2();
            this.pnlSiparisEkle3 = new TeknikServis.pnlSiparisEkle3();
            this.pnlSiparisEkle4 = new TeknikServis.pnlSiparisEkle4();
            this.pnlSiparisBasla = new TeknikServis.pnlSiparisBasla();
            this.SuspendLayout();
            // 
            // btn_ileri
            // 
            this.btn_ileri.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_ileri.Appearance.Options.UseFont = true;
            this.btn_ileri.Image = ((System.Drawing.Image)(resources.GetObject("btn_ileri.Image")));
            this.btn_ileri.Location = new System.Drawing.Point(910, 582);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(134, 46);
            this.btn_ileri.TabIndex = 41;
            this.btn_ileri.Text = "İleri";
            this.btn_ileri.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_geri.Appearance.Options.UseFont = true;
            this.btn_geri.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.Image")));
            this.btn_geri.Location = new System.Drawing.Point(85, 582);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(138, 46);
            this.btn_geri.TabIndex = 47;
            this.btn_geri.Text = "Geri";
            this.btn_geri.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_tamam
            // 
            this.btn_tamam.Image = ((System.Drawing.Image)(resources.GetObject("btn_tamam.Image")));
            this.btn_tamam.Location = new System.Drawing.Point(910, 582);
            this.btn_tamam.Name = "btn_tamam";
            this.btn_tamam.Size = new System.Drawing.Size(143, 46);
            this.btn_tamam.TabIndex = 48;
            this.btn_tamam.Text = "Tamamla";
            this.btn_tamam.Click += new System.EventHandler(this.btn_teslim_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.Location = new System.Drawing.Point(910, 583);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(143, 43);
            this.btn_kaydet.TabIndex = 52;
            this.btn_kaydet.Text = "Siparişi Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(btn_kaydet_tiklama);
            // 
            // btn_degistir
            // 
            this.btn_degistir.Image = ((System.Drawing.Image)(resources.GetObject("btn_degistir.Image")));
            this.btn_degistir.Location = new System.Drawing.Point(530, 583);// burası ayarlanmalı
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(143, 43);
            this.btn_degistir.TabIndex = 54;
            this.btn_degistir.Text = "Siparişi Değiştir";
            this.btn_degistir.Click += new System.EventHandler(btn_degistir_tiklama);
            // 
            // pnlSiparisEkle2
            // 
            this.pnlSiparisEkle2.Location = new System.Drawing.Point(3, 0);
            this.pnlSiparisEkle2.Name = "pnlSiparisEkle2";
            this.pnlSiparisEkle2.Size = new System.Drawing.Size(1090, 566);
            this.pnlSiparisEkle2.TabIndex = 51;
            // 
            // pnlSiparisEkle3
            // 
            this.pnlSiparisEkle3.Location = new System.Drawing.Point(3, 0);
            this.pnlSiparisEkle3.Name = "pnlSiparisEkle3";
            this.pnlSiparisEkle3.Size = new System.Drawing.Size(1090, 566);
            this.pnlSiparisEkle3.TabIndex = 50;
            // 
            // pnlSiparisEkle4
            // 
            this.pnlSiparisEkle4.Location = new System.Drawing.Point(3, 3);
            this.pnlSiparisEkle4.Name = "pnlSiparisEkle4";
            this.pnlSiparisEkle4.Size = new System.Drawing.Size(1092, 566);
            this.pnlSiparisEkle4.TabIndex = 49;
            // 
            // pnlSiparisBasla
            // 
            this.pnlSiparisBasla.Location = new System.Drawing.Point(1, 2);
            this.pnlSiparisBasla.Name = "pnlSiparisBasla";
            this.pnlSiparisBasla.Size = new System.Drawing.Size(1092, 556);
            this.pnlSiparisBasla.TabIndex = 53;
            // 
            // pnlSiparisEkleTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_degistir);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.pnlSiparisBasla);
            this.Controls.Add(this.pnlSiparisEkle2);
            this.Controls.Add(this.pnlSiparisEkle3);
            this.Controls.Add(this.pnlSiparisEkle4);
            this.Controls.Add(this.btn_tamam);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_ileri);
            this.Name = "pnlSiparisEkleTemp";
            this.Size = new System.Drawing.Size(1098, 643);
            this.Load += new System.EventHandler(this.pnlSiparisEkleTemp_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_ileri;
        private DevExpress.XtraEditors.SimpleButton btn_geri;
        private DevExpress.XtraEditors.SimpleButton btn_tamam;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_degistir;
        private pnlSiparisEkle4 pnlSiparisEkle4;
        private pnlSiparisEkle3 pnlSiparisEkle3;
        private pnlSiparisEkle2 pnlSiparisEkle2;
        private pnlSiparisBasla pnlSiparisBasla;
        
        
    }
}
