namespace TeknikServis
{
    partial class pnlSiparisBasla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlSiparisBasla));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nUd_adet = new System.Windows.Forms.NumericUpDown();
            this.btn_sepeteEkle = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cBox_model = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBox_marka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_katagori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(366, 104);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(711, 424);
            this.gridControl1.TabIndex = 64;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // nUd_adet
            // 
            this.nUd_adet.Location = new System.Drawing.Point(169, 245);
            this.nUd_adet.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nUd_adet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUd_adet.Name = "nUd_adet";
            this.nUd_adet.Size = new System.Drawing.Size(149, 20);
            this.nUd_adet.TabIndex = 63;
            this.nUd_adet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_sepeteEkle
            // 
            this.btn_sepeteEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_sepeteEkle.Appearance.Options.UseFont = true;
            this.btn_sepeteEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_sepeteEkle.Image")));
            this.btn_sepeteEkle.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_sepeteEkle.Location = new System.Drawing.Point(169, 408);
            this.btn_sepeteEkle.Name = "btn_sepeteEkle";
            this.btn_sepeteEkle.Size = new System.Drawing.Size(167, 120);
            this.btn_sepeteEkle.TabIndex = 62;
            this.btn_sepeteEkle.Text = "Sepete Ekle";
            this.btn_sepeteEkle.Click += new System.EventHandler(this.btn_sepeteEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label10.Location = new System.Drawing.Point(83, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Ürün Adeti:";
            // 
            // cBox_model
            // 
            this.cBox_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_model.FormattingEnabled = true;
            this.cBox_model.Location = new System.Drawing.Point(169, 197);
            this.cBox_model.Name = "cBox_model";
            this.cBox_model.Size = new System.Drawing.Size(149, 21);
            this.cBox_model.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(83, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Ürün modeli:";
            // 
            // cBox_marka
            // 
            this.cBox_marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_marka.FormattingEnabled = true;
            this.cBox_marka.Location = new System.Drawing.Point(169, 147);
            this.cBox_marka.Name = "cBox_marka";
            this.cBox_marka.Size = new System.Drawing.Size(149, 21);
            this.cBox_marka.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(83, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Marka Seç:";
            // 
            // cBox_katagori
            // 
            this.cBox_katagori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_katagori.FormattingEnabled = true;
            this.cBox_katagori.Location = new System.Drawing.Point(169, 101);
            this.cBox_katagori.Name = "cBox_katagori";
            this.cBox_katagori.Size = new System.Drawing.Size(149, 21);
            this.cBox_katagori.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(83, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Katagori Seç:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(993, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tamamlama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(733, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Fırsat Notları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(447, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Müşteri Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(192, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Sepete Ekleme";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.EditValue = "20";
            this.progressBarControl1.Location = new System.Drawing.Point(33, 54);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.progressBarControl1.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.progressBarControl1.Size = new System.Drawing.Size(1044, 22);
            this.progressBarControl1.TabIndex = 50;
            // 
            // pnlSiparisBasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.nUd_adet);
            this.Controls.Add(this.btn_sepeteEkle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cBox_model);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBox_marka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBox_katagori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarControl1);
            this.Name = "pnlSiparisBasla";
            this.Size = new System.Drawing.Size(1110, 566);
            this.Load += new System.EventHandler(this.pnlSiparisBasla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.NumericUpDown nUd_adet;
        public DevExpress.XtraEditors.SimpleButton btn_sepeteEkle;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cBox_model;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cBox_marka;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cBox_katagori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    }
}
