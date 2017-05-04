namespace TeknikServis
{
    partial class frmArizaliMusteriSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArizaliMusteriSec));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.rBtn_satis = new System.Windows.Forms.RadioButton();
            this.rBtn_ariza = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ara = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.btn_sec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(250, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(622, 430);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.rBtn_satis);
            this.panelControl2.Controls.Add(this.rBtn_ariza);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.btn_temizle);
            this.panelControl2.Controls.Add(this.btn_ara);
            this.panelControl2.Controls.Add(this.txt_ara);
            this.panelControl2.Location = new System.Drawing.Point(5, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(239, 430);
            this.panelControl2.TabIndex = 10;
            // 
            // rBtn_satis
            // 
            this.rBtn_satis.AutoSize = true;
            this.rBtn_satis.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtn_satis.Location = new System.Drawing.Point(18, 56);
            this.rBtn_satis.Name = "rBtn_satis";
            this.rBtn_satis.Size = new System.Drawing.Size(117, 22);
            this.rBtn_satis.TabIndex = 14;
            this.rBtn_satis.TabStop = true;
            this.rBtn_satis.Text = "Satış Müşterisi";
            this.rBtn_satis.UseVisualStyleBackColor = true;
            // 
            // rBtn_ariza
            // 
            this.rBtn_ariza.AutoSize = true;
            this.rBtn_ariza.Checked = true;
            this.rBtn_ariza.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtn_ariza.Location = new System.Drawing.Point(18, 18);
            this.rBtn_ariza.Name = "rBtn_ariza";
            this.rBtn_ariza.Size = new System.Drawing.Size(118, 22);
            this.rBtn_ariza.TabIndex = 13;
            this.rBtn_ariza.TabStop = true;
            this.rBtn_ariza.Text = "Arıza Müşterisi";
            this.rBtn_ariza.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adı:";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.Location = new System.Drawing.Point(18, 157);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(89, 38);
            this.btn_temizle.TabIndex = 9;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Image = ((System.Drawing.Image)(resources.GetObject("btn_ara.Image")));
            this.btn_ara.Location = new System.Drawing.Point(129, 157);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(89, 38);
            this.btn_ara.TabIndex = 8;
            this.btn_ara.Text = "Ara";
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ara.Location = new System.Drawing.Point(18, 111);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(200, 26);
            this.txt_ara.TabIndex = 7;
            // 
            // btn_sec
            // 
            this.btn_sec.Image = ((System.Drawing.Image)(resources.GetObject("btn_sec.Image")));
            this.btn_sec.Location = new System.Drawing.Point(753, 439);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(119, 36);
            this.btn_sec.TabIndex = 11;
            this.btn_sec.Text = "Seç";
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // frmArizaliMusteriSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 478);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.btn_sec);
            this.Name = "frmArizaliMusteriSec";
            this.Text = "frmArizaliMusteriSec";
            this.Load += new System.EventHandler(this.frmArizaliMusteriSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_temizle;
        private DevExpress.XtraEditors.SimpleButton btn_ara;
        private System.Windows.Forms.TextBox txt_ara;
        private DevExpress.XtraEditors.SimpleButton btn_sec;
        private System.Windows.Forms.RadioButton rBtn_satis;
        private System.Windows.Forms.RadioButton rBtn_ariza;
    }
}