namespace TeknikServis
{
    partial class pnlStokislem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlStokislem));
            this.pnlStokİslemTemp = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btn_tumUrunListe = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunArama = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunlEkle = new DevExpress.XtraEditors.SimpleButton();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStokİslemTemp
            // 
            this.pnlStokİslemTemp.Location = new System.Drawing.Point(247, 0);
            this.pnlStokİslemTemp.Name = "pnlStokİslemTemp";
            this.pnlStokİslemTemp.Size = new System.Drawing.Size(1101, 646);
            this.pnlStokİslemTemp.TabIndex = 3;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btn_tumUrunListe);
            this.pnlMenu.Controls.Add(this.simpleButton1);
            this.pnlMenu.Controls.Add(this.btnUrunArama);
            this.pnlMenu.Controls.Add(this.btnUrunlEkle);
            this.pnlMenu.Location = new System.Drawing.Point(1, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 649);
            this.pnlMenu.TabIndex = 2;
            // 
            // btn_tumUrunListe
            // 
            this.btn_tumUrunListe.Image = ((System.Drawing.Image)(resources.GetObject("btn_tumUrunListe.Image")));
            this.btn_tumUrunListe.Location = new System.Drawing.Point(17, 130);
            this.btn_tumUrunListe.Name = "btn_tumUrunListe";
            this.btn_tumUrunListe.Size = new System.Drawing.Size(198, 62);
            this.btn_tumUrunListe.TabIndex = 13;
            this.btn_tumUrunListe.Text = "Tüm Ürün Listesi";
            this.btn_tumUrunListe.Click += new System.EventHandler(this.btn_tumUrunListe_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(19, 564);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(196, 62);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Ana Menü";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnUrunArama
            // 
            this.btnUrunArama.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunArama.Image")));
            this.btnUrunArama.Location = new System.Drawing.Point(17, 231);
            this.btnUrunArama.Name = "btnUrunArama";
            this.btnUrunArama.Size = new System.Drawing.Size(198, 62);
            this.btnUrunArama.TabIndex = 1;
            this.btnUrunArama.Text = "Arama";
            this.btnUrunArama.Click += new System.EventHandler(this.btnUrunArama_Click);
            // 
            // btnUrunlEkle
            // 
            this.btnUrunlEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunlEkle.Image")));
            this.btnUrunlEkle.Location = new System.Drawing.Point(17, 25);
            this.btnUrunlEkle.Name = "btnUrunlEkle";
            this.btnUrunlEkle.Size = new System.Drawing.Size(198, 62);
            this.btnUrunlEkle.TabIndex = 0;
            this.btnUrunlEkle.Text = "Ürün Ekle";
            this.btnUrunlEkle.Click += new System.EventHandler(this.btnUrunlEkle_Click);
            // 
            // pnlStokislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStokİslemTemp);
            this.Controls.Add(this.pnlMenu);
            this.Name = "pnlStokislem";
            this.Size = new System.Drawing.Size(1348, 649);
            this.Load += new System.EventHandler(this.pnlStokislem_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStokİslemTemp;
        private System.Windows.Forms.Panel pnlMenu;
        private DevExpress.XtraEditors.SimpleButton btnUrunArama;
        private DevExpress.XtraEditors.SimpleButton btnUrunlEkle;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_tumUrunListe;
    }
}
