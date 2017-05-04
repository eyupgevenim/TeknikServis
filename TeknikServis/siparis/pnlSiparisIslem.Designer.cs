namespace TeknikServis
{
    partial class pnlSiparisIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlSiparisIslem));
            this.pnl_Siparismenu = new System.Windows.Forms.Panel();
            this.btn_anaSayfayaGeriDon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Siparislistele = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Siparisekle = new DevExpress.XtraEditors.SimpleButton();
            this.pnlSiparisIslamTemp = new System.Windows.Forms.Panel();
            this.pnl_Siparismenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Siparismenu
            // 
            this.pnl_Siparismenu.Controls.Add(this.btn_anaSayfayaGeriDon);
            this.pnl_Siparismenu.Controls.Add(this.btn_Siparislistele);
            this.pnl_Siparismenu.Controls.Add(this.btn_Siparisekle);
            this.pnl_Siparismenu.Location = new System.Drawing.Point(3, 3);
            this.pnl_Siparismenu.Name = "pnl_Siparismenu";
            this.pnl_Siparismenu.Size = new System.Drawing.Size(240, 649);
            this.pnl_Siparismenu.TabIndex = 0;
            // 
            // btn_anaSayfayaGeriDon
            // 
            this.btn_anaSayfayaGeriDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_anaSayfayaGeriDon.Image")));
            this.btn_anaSayfayaGeriDon.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_anaSayfayaGeriDon.Location = new System.Drawing.Point(21, 565);
            this.btn_anaSayfayaGeriDon.Name = "btn_anaSayfayaGeriDon";
            this.btn_anaSayfayaGeriDon.Size = new System.Drawing.Size(198, 60);
            this.btn_anaSayfayaGeriDon.TabIndex = 3;
            this.btn_anaSayfayaGeriDon.Text = "Anasayfa";
            this.btn_anaSayfayaGeriDon.Click += new System.EventHandler(this.btn_anaSayfayaGeriDon_Click);
            // 
            // btn_Siparislistele
            // 
            this.btn_Siparislistele.Image = ((System.Drawing.Image)(resources.GetObject("btn_Siparislistele.Image")));
            this.btn_Siparislistele.Location = new System.Drawing.Point(21, 127);
            this.btn_Siparislistele.Name = "btn_Siparislistele";
            this.btn_Siparislistele.Size = new System.Drawing.Size(198, 62);
            this.btn_Siparislistele.TabIndex = 1;
            this.btn_Siparislistele.Text = "Sipariş Listele";
            this.btn_Siparislistele.Click += new System.EventHandler(this.btn_Siparislistele_Click);
            // 
            // btn_Siparisekle
            // 
            this.btn_Siparisekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Siparisekle.Image")));
            this.btn_Siparisekle.Location = new System.Drawing.Point(21, 34);
            this.btn_Siparisekle.Name = "btn_Siparisekle";
            this.btn_Siparisekle.Size = new System.Drawing.Size(198, 62);
            this.btn_Siparisekle.TabIndex = 0;
            this.btn_Siparisekle.Text = "Sipariş Ekle";
            this.btn_Siparisekle.Click += new System.EventHandler(this.btn_Siparisekle_Click);
            // 
            // pnlSiparisIslamTemp
            // 
            this.pnlSiparisIslamTemp.Location = new System.Drawing.Point(249, 3);
            this.pnlSiparisIslamTemp.Name = "pnlSiparisIslamTemp";
            this.pnlSiparisIslamTemp.Size = new System.Drawing.Size(1098, 643);
            this.pnlSiparisIslamTemp.TabIndex = 1;
            // 
            // pnlSiparisIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSiparisIslamTemp);
            this.Controls.Add(this.pnl_Siparismenu);
            this.Name = "pnlSiparisIslem";
            this.Size = new System.Drawing.Size(1350, 649);
            this.Load += new System.EventHandler(this.pnlSiparis_Load);
            this.pnl_Siparismenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Siparismenu;
        private DevExpress.XtraEditors.SimpleButton btn_Siparisekle;
        private DevExpress.XtraEditors.SimpleButton btn_Siparislistele;
        private DevExpress.XtraEditors.SimpleButton btn_anaSayfayaGeriDon;
        public System.Windows.Forms.Panel pnlSiparisIslamTemp;
    }
}
