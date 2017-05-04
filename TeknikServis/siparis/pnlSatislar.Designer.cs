namespace TeknikServis
{
    partial class pnlSatislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlSatislar));
            this.pnlSatisTemp = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btn_bekleyen = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_eski = new DevExpress.XtraEditors.SimpleButton();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSatisTemp
            // 
            this.pnlSatisTemp.Location = new System.Drawing.Point(247, 0);
            this.pnlSatisTemp.Name = "pnlSatisTemp";
            this.pnlSatisTemp.Size = new System.Drawing.Size(1101, 646);
            this.pnlSatisTemp.TabIndex = 5;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btn_bekleyen);
            this.pnlMenu.Controls.Add(this.simpleButton1);
            this.pnlMenu.Controls.Add(this.btn_eski);
            this.pnlMenu.Location = new System.Drawing.Point(1, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 649);
            this.pnlMenu.TabIndex = 4;
            // 
            // btn_bekleyen
            // 
            this.btn_bekleyen.Image = ((System.Drawing.Image)(resources.GetObject("btn_bekleyen.Image")));
            this.btn_bekleyen.Location = new System.Drawing.Point(23, 35);
            this.btn_bekleyen.Name = "btn_bekleyen";
            this.btn_bekleyen.Size = new System.Drawing.Size(196, 62);
            this.btn_bekleyen.TabIndex = 12;
            this.btn_bekleyen.Text = "Teslim Edilmemiş Siparişler";
            this.btn_bekleyen.Click += new System.EventHandler(this.btn_bekleyen_Click);
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
            // btn_eski
            // 
            this.btn_eski.Image = ((System.Drawing.Image)(resources.GetObject("btn_eski.Image")));
            this.btn_eski.Location = new System.Drawing.Point(23, 117);
            this.btn_eski.Name = "btn_eski";
            this.btn_eski.Size = new System.Drawing.Size(196, 62);
            this.btn_eski.TabIndex = 9;
            this.btn_eski.Text = "Eski Şiparişler";
            this.btn_eski.Click += new System.EventHandler(this.btn_eski_Click);
            // 
            // pnlSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSatisTemp);
            this.Controls.Add(this.pnlMenu);
            this.Name = "pnlSatislar";
            this.Size = new System.Drawing.Size(1348, 649);
            this.Load += new System.EventHandler(this.pnlSatislar_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSatisTemp;
        private System.Windows.Forms.Panel pnlMenu;
        private DevExpress.XtraEditors.SimpleButton btn_bekleyen;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_eski;
    }
}
