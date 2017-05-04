namespace TeknikServis
{
    partial class pnlSekreter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlSekreter));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_auKayit = new DevExpress.XtraEditors.SimpleButton();
            this.pnlSekreterTemp = new DevExpress.XtraEditors.PanelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_servistekiler = new DevExpress.XtraEditors.SimpleButton();
            this.btn_eskiKayitlar = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSekreterTemp)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btn_auKayit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 649);
            this.panel2.TabIndex = 4;
            // 
            // btn_auKayit
            // 
            this.btn_auKayit.Image = ((System.Drawing.Image)(resources.GetObject("btn_auKayit.Image")));
            this.btn_auKayit.Location = new System.Drawing.Point(55, 26);
            this.btn_auKayit.Name = "btn_auKayit";
            this.btn_auKayit.Size = new System.Drawing.Size(198, 62);
            this.btn_auKayit.TabIndex = 4;
            this.btn_auKayit.Text = "Yeni Cihaz Kayıt";
            this.btn_auKayit.Click += new System.EventHandler(this.btn_auKayit_Click);
            // 
            // pnlSekreterTemp
            // 
            this.pnlSekreterTemp.AutoSize = true;
            this.pnlSekreterTemp.Location = new System.Drawing.Point(291, 3);
            this.pnlSekreterTemp.Name = "pnlSekreterTemp";
            this.pnlSekreterTemp.Size = new System.Drawing.Size(786, 643);
            this.pnlSekreterTemp.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btn_servistekiler);
            this.panel3.Controls.Add(this.btn_eskiKayitlar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1083, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 649);
            this.panel3.TabIndex = 5;
            // 
            // btn_servistekiler
            // 
            this.btn_servistekiler.Image = ((System.Drawing.Image)(resources.GetObject("btn_servistekiler.Image")));
            this.btn_servistekiler.Location = new System.Drawing.Point(35, 26);
            this.btn_servistekiler.Name = "btn_servistekiler";
            this.btn_servistekiler.Size = new System.Drawing.Size(188, 62);
            this.btn_servistekiler.TabIndex = 8;
            this.btn_servistekiler.Text = "Servistekiler";
            this.btn_servistekiler.Click += new System.EventHandler(this.btn_servistekiler_Click);
            // 
            // btn_eskiKayitlar
            // 
            this.btn_eskiKayitlar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eskiKayitlar.Image")));
            this.btn_eskiKayitlar.Location = new System.Drawing.Point(35, 118);
            this.btn_eskiKayitlar.Name = "btn_eskiKayitlar";
            this.btn_eskiKayitlar.Size = new System.Drawing.Size(188, 62);
            this.btn_eskiKayitlar.TabIndex = 7;
            this.btn_eskiKayitlar.Text = "Eski Kayıtlar";
            this.btn_eskiKayitlar.Click += new System.EventHandler(this.btn_eskiKayitlar_Click);
            // 
            // pnlSekreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSekreterTemp);
            this.Controls.Add(this.panel3);
            this.Name = "pnlSekreter";
            this.Size = new System.Drawing.Size(1334, 649);
            this.Load += new System.EventHandler(this.pnlSekreter_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSekreterTemp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_auKayit;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btn_eskiKayitlar;
        private DevExpress.XtraEditors.SimpleButton btn_servistekiler;
        public DevExpress.XtraEditors.PanelControl pnlSekreterTemp;
    }
}
