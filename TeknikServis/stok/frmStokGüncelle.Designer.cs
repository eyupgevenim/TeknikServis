namespace TeknikServis
{
    partial class frmStokGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokGüncelle));
            this.gBox_stokGuncelle = new System.Windows.Forms.GroupBox();
            this.nUd_stokAdeti = new System.Windows.Forms.NumericUpDown();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_gelisfiyat = new System.Windows.Forms.TextBox();
            this.lbl_gelisfiyat = new System.Windows.Forms.Label();
            this.dT_tarih = new System.Windows.Forms.DateTimePicker();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.cBox_marka = new System.Windows.Forms.ComboBox();
            this.cBox_katagori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBox_stokGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_stokAdeti)).BeginInit();
            this.SuspendLayout();
            // 
            // gBox_stokGuncelle
            // 
            this.gBox_stokGuncelle.BackColor = System.Drawing.Color.Silver;
            this.gBox_stokGuncelle.Controls.Add(this.nUd_stokAdeti);
            this.gBox_stokGuncelle.Controls.Add(this.btn_Kaydet);
            this.gBox_stokGuncelle.Controls.Add(this.txt_gelisfiyat);
            this.gBox_stokGuncelle.Controls.Add(this.lbl_gelisfiyat);
            this.gBox_stokGuncelle.Controls.Add(this.dT_tarih);
            this.gBox_stokGuncelle.Controls.Add(this.txt_model);
            this.gBox_stokGuncelle.Controls.Add(this.cBox_marka);
            this.gBox_stokGuncelle.Controls.Add(this.cBox_katagori);
            this.gBox_stokGuncelle.Controls.Add(this.label5);
            this.gBox_stokGuncelle.Controls.Add(this.label4);
            this.gBox_stokGuncelle.Controls.Add(this.label3);
            this.gBox_stokGuncelle.Controls.Add(this.label1);
            this.gBox_stokGuncelle.Controls.Add(this.label2);
            this.gBox_stokGuncelle.Location = new System.Drawing.Point(12, 12);
            this.gBox_stokGuncelle.Name = "gBox_stokGuncelle";
            this.gBox_stokGuncelle.Size = new System.Drawing.Size(392, 536);
            this.gBox_stokGuncelle.TabIndex = 0;
            this.gBox_stokGuncelle.TabStop = false;
            this.gBox_stokGuncelle.Text = "Stok Güncelleme";
            // 
            // nUd_stokAdeti
            // 
            this.nUd_stokAdeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUd_stokAdeti.Location = new System.Drawing.Point(156, 255);
            this.nUd_stokAdeti.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nUd_stokAdeti.Name = "nUd_stokAdeti";
            this.nUd_stokAdeti.Size = new System.Drawing.Size(156, 24);
            this.nUd_stokAdeti.TabIndex = 43;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Appearance.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Kaydet.Appearance.BackColor2 = System.Drawing.Color.MintCream;
            this.btn_Kaydet.Appearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_Kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Kaydet.Appearance.Options.UseBackColor = true;
            this.btn_Kaydet.Appearance.Options.UseBorderColor = true;
            this.btn_Kaydet.Appearance.Options.UseFont = true;
            this.btn_Kaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_Kaydet.Location = new System.Drawing.Point(223, 462);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(127, 44);
            this.btn_Kaydet.TabIndex = 42;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txt_gelisfiyat
            // 
            this.txt_gelisfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_gelisfiyat.Location = new System.Drawing.Point(156, 330);
            this.txt_gelisfiyat.Name = "txt_gelisfiyat";
            this.txt_gelisfiyat.Size = new System.Drawing.Size(156, 24);
            this.txt_gelisfiyat.TabIndex = 41;
            // 
            // lbl_gelisfiyat
            // 
            this.lbl_gelisfiyat.AutoSize = true;
            this.lbl_gelisfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gelisfiyat.Location = new System.Drawing.Point(65, 337);
            this.lbl_gelisfiyat.Name = "lbl_gelisfiyat";
            this.lbl_gelisfiyat.Size = new System.Drawing.Size(84, 18);
            this.lbl_gelisfiyat.TabIndex = 40;
            this.lbl_gelisfiyat.Text = "Geliş Fiyatı:";
            // 
            // dT_tarih
            // 
            this.dT_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dT_tarih.Location = new System.Drawing.Point(156, 411);
            this.dT_tarih.Name = "dT_tarih";
            this.dT_tarih.Size = new System.Drawing.Size(156, 24);
            this.dT_tarih.TabIndex = 39;
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_model.Location = new System.Drawing.Point(156, 170);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(156, 24);
            this.txt_model.TabIndex = 37;
            // 
            // cBox_marka
            // 
            this.cBox_marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_marka.FormattingEnabled = true;
            this.cBox_marka.Location = new System.Drawing.Point(156, 92);
            this.cBox_marka.Name = "cBox_marka";
            this.cBox_marka.Size = new System.Drawing.Size(156, 26);
            this.cBox_marka.TabIndex = 36;
            // 
            // cBox_katagori
            // 
            this.cBox_katagori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_katagori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_katagori.FormattingEnabled = true;
            this.cBox_katagori.Location = new System.Drawing.Point(156, 19);
            this.cBox_katagori.Name = "cBox_katagori";
            this.cBox_katagori.Size = new System.Drawing.Size(156, 26);
            this.cBox_katagori.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(62, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Kayıt Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Stok Adeti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Katagori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Marka:";
            // 
            // frmStokGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 560);
            this.Controls.Add(this.gBox_stokGuncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStokGüncelle";
            this.Text = "Stok Güncelle";
            this.Load += new System.EventHandler(this.frmStokGüncelle_Load);
            this.gBox_stokGuncelle.ResumeLayout(false);
            this.gBox_stokGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_stokAdeti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_stokGuncelle;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private System.Windows.Forms.TextBox txt_gelisfiyat;
        private System.Windows.Forms.Label lbl_gelisfiyat;
        private System.Windows.Forms.DateTimePicker dT_tarih;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.ComboBox cBox_marka;
        private System.Windows.Forms.ComboBox cBox_katagori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUd_stokAdeti;
    }
}