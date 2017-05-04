namespace TeknikServis
{
    partial class frmSekreter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreter));
            this.panel2 = new System.Windows.Forms.Panel();
            this.drpD_kullanici = new DevExpress.XtraEditors.DropDownButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlSekreterTemp = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.drpD_kullanici);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1348, 80);
            this.panel2.TabIndex = 5;
            // 
            // drpD_kullanici
            // 
            this.drpD_kullanici.Dock = System.Windows.Forms.DockStyle.Right;
            this.drpD_kullanici.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.drpD_kullanici.Image = ((System.Drawing.Image)(resources.GetObject("drpD_kullanici.Image")));
            this.drpD_kullanici.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.drpD_kullanici.Location = new System.Drawing.Point(1224, 0);
            this.drpD_kullanici.Name = "drpD_kullanici";
            this.drpD_kullanici.Size = new System.Drawing.Size(124, 80);
            this.drpD_kullanici.TabIndex = 10;
            this.drpD_kullanici.Text = "Kullanıcı Adı";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(14, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 61);
            this.panel5.TabIndex = 9;
            // 
            // pnlSekreterTemp
            // 
            this.pnlSekreterTemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSekreterTemp.Location = new System.Drawing.Point(0, 79);
            this.pnlSekreterTemp.Name = "pnlSekreterTemp";
            this.pnlSekreterTemp.Size = new System.Drawing.Size(1348, 646);
            this.pnlSekreterTemp.TabIndex = 4;
            // 
            // frmSekreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 725);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSekreterTemp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSekreter";
            this.Text = "Sekreter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSekreter_FormClosing);
            this.Load += new System.EventHandler(this.frmSekreter_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.DropDownButton drpD_kullanici;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel pnlSekreterTemp;
    }
}