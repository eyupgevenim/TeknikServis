namespace TeknikServis
{
    partial class frmPersonelGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelGuncelle));
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_İptal = new DevExpress.XtraEditors.SimpleButton();
            this.gC_kisiselBilgiler = new DevExpress.XtraEditors.GroupControl();
            this.nUd_maas = new System.Windows.Forms.NumericUpDown();
            this.cBox_unvan = new System.Windows.Forms.ComboBox();
            this.cBox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.dE_dogumTarih = new DevExpress.XtraEditors.DateEdit();
            this.lbl_dogumtarih = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.lbl_adısoyadı = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_tcno = new System.Windows.Forms.Label();
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.lbl_maas = new System.Windows.Forms.Label();
            this.lbl_egitimDurumu = new System.Windows.Forms.Label();
            this.cBox_egitimDurumu = new System.Windows.Forms.ComboBox();
            this.lbl_unvan = new System.Windows.Forms.Label();
            this.gC_iletisimBilgiler = new DevExpress.XtraEditors.GroupControl();
            this.cBox_ilce = new System.Windows.Forms.ComboBox();
            this.cBox_il = new System.Windows.Forms.ComboBox();
            this.lbl_ilce = new System.Windows.Forms.Label();
            this.lbl_il = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.rTxt_adresi = new System.Windows.Forms.RichTextBox();
            this.lbl_tel1 = new System.Windows.Forms.Label();
            this.lbl_tel2 = new System.Windows.Forms.Label();
            this.txt_tel2 = new System.Windows.Forms.TextBox();
            this.txt_tel1 = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gC_kisiselBilgiler)).BeginInit();
            this.gC_kisiselBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_maas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dE_dogumTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dE_dogumTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_iletisimBilgiler)).BeginInit();
            this.gC_iletisimBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.BackColor = System.Drawing.Color.Green;
            this.btn_kaydet.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.btn_kaydet.Appearance.Options.UseBackColor = true;
            this.btn_kaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_kaydet.Location = new System.Drawing.Point(474, 9);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(125, 48);
            this.btn_kaydet.TabIndex = 86;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_İptal
            // 
            this.btn_İptal.Appearance.BackColor = System.Drawing.Color.Red;
            this.btn_İptal.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_İptal.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_İptal.Appearance.Options.UseBackColor = true;
            this.btn_İptal.Appearance.Options.UseBorderColor = true;
            this.btn_İptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_İptal.Location = new System.Drawing.Point(260, 9);
            this.btn_İptal.Name = "btn_İptal";
            this.btn_İptal.Size = new System.Drawing.Size(125, 48);
            this.btn_İptal.TabIndex = 85;
            this.btn_İptal.Text = "İptal";
            this.btn_İptal.Click += new System.EventHandler(this.btn_İptal_Click);
            // 
            // gC_kisiselBilgiler
            // 
            this.gC_kisiselBilgiler.Controls.Add(this.nUd_maas);
            this.gC_kisiselBilgiler.Controls.Add(this.cBox_unvan);
            this.gC_kisiselBilgiler.Controls.Add(this.cBox_cinsiyet);
            this.gC_kisiselBilgiler.Controls.Add(this.lbl_cinsiyet);
            this.gC_kisiselBilgiler.Controls.Add(this.dE_dogumTarih);
            this.gC_kisiselBilgiler.Controls.Add(this.lbl_dogumtarih);
            this.gC_kisiselBilgiler.Controls.Add(this.lbl_soyad);
            this.gC_kisiselBilgiler.Controls.Add(this.txt_soyad);
            this.gC_kisiselBilgiler.Controls.Add(this.lbl_adısoyadı);
            this.gC_kisiselBilgiler.Controls.Add(this.txt_ad);
            this.gC_kisiselBilgiler.Controls.Add(this.lbl_tcno);
            this.gC_kisiselBilgiler.Controls.Add(this.txt_tcno);
            this.gC_kisiselBilgiler.Controls.Add(this.lbl_maas);
            this.gC_kisiselBilgiler.Controls.Add(this.lbl_egitimDurumu);
            this.gC_kisiselBilgiler.Controls.Add(this.cBox_egitimDurumu);
            this.gC_kisiselBilgiler.Controls.Add(this.lbl_unvan);
            this.gC_kisiselBilgiler.Location = new System.Drawing.Point(2, 3);
            this.gC_kisiselBilgiler.Name = "gC_kisiselBilgiler";
            this.gC_kisiselBilgiler.Size = new System.Drawing.Size(290, 411);
            this.gC_kisiselBilgiler.TabIndex = 87;
            this.gC_kisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // nUd_maas
            // 
            this.nUd_maas.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUd_maas.Location = new System.Drawing.Point(127, 373);
            this.nUd_maas.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nUd_maas.Name = "nUd_maas";
            this.nUd_maas.Size = new System.Drawing.Size(139, 26);
            this.nUd_maas.TabIndex = 103;
            // 
            // cBox_unvan
            // 
            this.cBox_unvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_unvan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_unvan.FormattingEnabled = true;
            this.cBox_unvan.Items.AddRange(new object[] {
            "Yönetici Asistanı",
            "Satış Elemanı",
            "Sekreter",
            "Teknik Eleman"});
            this.cBox_unvan.Location = new System.Drawing.Point(127, 275);
            this.cBox_unvan.Name = "cBox_unvan";
            this.cBox_unvan.Size = new System.Drawing.Size(139, 26);
            this.cBox_unvan.TabIndex = 102;
            // 
            // cBox_cinsiyet
            // 
            this.cBox_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_cinsiyet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_cinsiyet.FormattingEnabled = true;
            this.cBox_cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cBox_cinsiyet.Location = new System.Drawing.Point(127, 222);
            this.cBox_cinsiyet.Name = "cBox_cinsiyet";
            this.cBox_cinsiyet.Size = new System.Drawing.Size(139, 26);
            this.cBox_cinsiyet.TabIndex = 101;
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(26, 225);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(62, 18);
            this.lbl_cinsiyet.TabIndex = 100;
            this.lbl_cinsiyet.Text = "Cinsiyet:";
            // 
            // dE_dogumTarih
            // 
            this.dE_dogumTarih.EditValue = null;
            this.dE_dogumTarih.Location = new System.Drawing.Point(127, 171);
            this.dE_dogumTarih.Name = "dE_dogumTarih";
            this.dE_dogumTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dE_dogumTarih.Properties.Appearance.Options.UseFont = true;
            this.dE_dogumTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dE_dogumTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dE_dogumTarih.Size = new System.Drawing.Size(139, 24);
            this.dE_dogumTarih.TabIndex = 99;
            // 
            // lbl_dogumtarih
            // 
            this.lbl_dogumtarih.AutoSize = true;
            this.lbl_dogumtarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dogumtarih.Location = new System.Drawing.Point(26, 178);
            this.lbl_dogumtarih.Name = "lbl_dogumtarih";
            this.lbl_dogumtarih.Size = new System.Drawing.Size(100, 18);
            this.lbl_dogumtarih.TabIndex = 98;
            this.lbl_dogumtarih.Text = "Doğum Tarihi:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.Location = new System.Drawing.Point(26, 76);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(60, 18);
            this.lbl_soyad.TabIndex = 97;
            this.lbl_soyad.Text = "Soyadı :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(127, 73);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(139, 26);
            this.txt_soyad.TabIndex = 96;
            // 
            // lbl_adısoyadı
            // 
            this.lbl_adısoyadı.AutoSize = true;
            this.lbl_adısoyadı.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adısoyadı.Location = new System.Drawing.Point(26, 31);
            this.lbl_adısoyadı.Name = "lbl_adısoyadı";
            this.lbl_adısoyadı.Size = new System.Drawing.Size(37, 18);
            this.lbl_adısoyadı.TabIndex = 88;
            this.lbl_adısoyadı.Text = "Adı :";
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(127, 23);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(139, 26);
            this.txt_ad.TabIndex = 89;
            // 
            // lbl_tcno
            // 
            this.lbl_tcno.AutoSize = true;
            this.lbl_tcno.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tcno.Location = new System.Drawing.Point(26, 123);
            this.lbl_tcno.Name = "lbl_tcno";
            this.lbl_tcno.Size = new System.Drawing.Size(70, 18);
            this.lbl_tcno.TabIndex = 95;
            this.lbl_tcno.Text = "T.C. No :";
            // 
            // txt_tcno
            // 
            this.txt_tcno.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tcno.Location = new System.Drawing.Point(127, 123);
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(139, 26);
            this.txt_tcno.TabIndex = 94;
            // 
            // lbl_maas
            // 
            this.lbl_maas.AutoSize = true;
            this.lbl_maas.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_maas.Location = new System.Drawing.Point(26, 373);
            this.lbl_maas.Name = "lbl_maas";
            this.lbl_maas.Size = new System.Drawing.Size(53, 18);
            this.lbl_maas.TabIndex = 93;
            this.lbl_maas.Text = "Maaş :";
            // 
            // lbl_egitimDurumu
            // 
            this.lbl_egitimDurumu.AutoSize = true;
            this.lbl_egitimDurumu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_egitimDurumu.Location = new System.Drawing.Point(26, 329);
            this.lbl_egitimDurumu.Name = "lbl_egitimDurumu";
            this.lbl_egitimDurumu.Size = new System.Drawing.Size(113, 18);
            this.lbl_egitimDurumu.TabIndex = 91;
            this.lbl_egitimDurumu.Text = "Eğitim Durumu :";
            // 
            // cBox_egitimDurumu
            // 
            this.cBox_egitimDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_egitimDurumu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_egitimDurumu.FormattingEnabled = true;
            this.cBox_egitimDurumu.Items.AddRange(new object[] {
            "İlkokul",
            "Lise",
            "Üniversite",
            "Yüksek Lisans"});
            this.cBox_egitimDurumu.Location = new System.Drawing.Point(127, 326);
            this.cBox_egitimDurumu.Name = "cBox_egitimDurumu";
            this.cBox_egitimDurumu.Size = new System.Drawing.Size(139, 26);
            this.cBox_egitimDurumu.TabIndex = 92;
            // 
            // lbl_unvan
            // 
            this.lbl_unvan.AutoSize = true;
            this.lbl_unvan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_unvan.Location = new System.Drawing.Point(26, 283);
            this.lbl_unvan.Name = "lbl_unvan";
            this.lbl_unvan.Size = new System.Drawing.Size(60, 18);
            this.lbl_unvan.TabIndex = 90;
            this.lbl_unvan.Text = "Ünvan :";
            // 
            // gC_iletisimBilgiler
            // 
            this.gC_iletisimBilgiler.Controls.Add(this.cBox_ilce);
            this.gC_iletisimBilgiler.Controls.Add(this.cBox_il);
            this.gC_iletisimBilgiler.Controls.Add(this.lbl_ilce);
            this.gC_iletisimBilgiler.Controls.Add(this.lbl_il);
            this.gC_iletisimBilgiler.Controls.Add(this.lbl_adres);
            this.gC_iletisimBilgiler.Controls.Add(this.rTxt_adresi);
            this.gC_iletisimBilgiler.Controls.Add(this.lbl_tel1);
            this.gC_iletisimBilgiler.Controls.Add(this.lbl_tel2);
            this.gC_iletisimBilgiler.Controls.Add(this.txt_tel2);
            this.gC_iletisimBilgiler.Controls.Add(this.txt_tel1);
            this.gC_iletisimBilgiler.Controls.Add(this.txt_email);
            this.gC_iletisimBilgiler.Controls.Add(this.lbl_email);
            this.gC_iletisimBilgiler.Location = new System.Drawing.Point(298, 3);
            this.gC_iletisimBilgiler.Name = "gC_iletisimBilgiler";
            this.gC_iletisimBilgiler.Size = new System.Drawing.Size(332, 411);
            this.gC_iletisimBilgiler.TabIndex = 88;
            this.gC_iletisimBilgiler.Text = "İletişim Bilgileri";
            // 
            // cBox_ilce
            // 
            this.cBox_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_ilce.FormattingEnabled = true;
            this.cBox_ilce.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cBox_ilce.Location = new System.Drawing.Point(118, 150);
            this.cBox_ilce.Name = "cBox_ilce";
            this.cBox_ilce.Size = new System.Drawing.Size(139, 21);
            this.cBox_ilce.TabIndex = 96;
            // 
            // cBox_il
            // 
            this.cBox_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_il.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_il.FormattingEnabled = true;
            this.cBox_il.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cBox_il.Location = new System.Drawing.Point(118, 100);
            this.cBox_il.Name = "cBox_il";
            this.cBox_il.Size = new System.Drawing.Size(139, 26);
            this.cBox_il.TabIndex = 95;
            // 
            // lbl_ilce
            // 
            this.lbl_ilce.AutoSize = true;
            this.lbl_ilce.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilce.Location = new System.Drawing.Point(14, 160);
            this.lbl_ilce.Name = "lbl_ilce";
            this.lbl_ilce.Size = new System.Drawing.Size(41, 18);
            this.lbl_ilce.TabIndex = 94;
            this.lbl_ilce.Text = "İlçe :";
            // 
            // lbl_il
            // 
            this.lbl_il.AutoSize = true;
            this.lbl_il.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_il.Location = new System.Drawing.Point(14, 103);
            this.lbl_il.Name = "lbl_il";
            this.lbl_il.Size = new System.Drawing.Size(26, 18);
            this.lbl_il.TabIndex = 93;
            this.lbl_il.Text = "İl :";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.Location = new System.Drawing.Point(14, 302);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(55, 18);
            this.lbl_adres.TabIndex = 92;
            this.lbl_adres.Text = "Adres :";
            // 
            // rTxt_adresi
            // 
            this.rTxt_adresi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxt_adresi.Location = new System.Drawing.Point(118, 302);
            this.rTxt_adresi.Name = "rTxt_adresi";
            this.rTxt_adresi.Size = new System.Drawing.Size(186, 56);
            this.rTxt_adresi.TabIndex = 91;
            this.rTxt_adresi.Text = "";
            // 
            // lbl_tel1
            // 
            this.lbl_tel1.AutoSize = true;
            this.lbl_tel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tel1.Location = new System.Drawing.Point(14, 205);
            this.lbl_tel1.Name = "lbl_tel1";
            this.lbl_tel1.Size = new System.Drawing.Size(80, 18);
            this.lbl_tel1.TabIndex = 88;
            this.lbl_tel1.Text = "Telefon 1 :";
            // 
            // lbl_tel2
            // 
            this.lbl_tel2.AutoSize = true;
            this.lbl_tel2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tel2.Location = new System.Drawing.Point(14, 256);
            this.lbl_tel2.Name = "lbl_tel2";
            this.lbl_tel2.Size = new System.Drawing.Size(80, 18);
            this.lbl_tel2.TabIndex = 89;
            this.lbl_tel2.Text = "Telefon 2 :";
            // 
            // txt_tel2
            // 
            this.txt_tel2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tel2.Location = new System.Drawing.Point(118, 249);
            this.txt_tel2.Name = "txt_tel2";
            this.txt_tel2.Size = new System.Drawing.Size(139, 26);
            this.txt_tel2.TabIndex = 90;
            // 
            // txt_tel1
            // 
            this.txt_tel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tel1.Location = new System.Drawing.Point(118, 198);
            this.txt_tel1.Name = "txt_tel1";
            this.txt_tel1.Size = new System.Drawing.Size(139, 26);
            this.txt_tel1.TabIndex = 85;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.Location = new System.Drawing.Point(118, 46);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(139, 26);
            this.txt_email.TabIndex = 87;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.Location = new System.Drawing.Point(14, 53);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(56, 18);
            this.lbl_email.TabIndex = 86;
            this.lbl_email.Text = "e-mail :";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_İptal);
            this.panelControl1.Controls.Add(this.btn_kaydet);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 420);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(633, 69);
            this.panelControl1.TabIndex = 89;
            // 
            // frmPersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 489);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gC_iletisimBilgiler);
            this.Controls.Add(this.gC_kisiselBilgiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(350, 100);
            this.Name = "frmPersonelGuncelle";
            this.Text = "Personel Güncelleme";
            this.Load += new System.EventHandler(this.frmPersonelguncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gC_kisiselBilgiler)).EndInit();
            this.gC_kisiselBilgiler.ResumeLayout(false);
            this.gC_kisiselBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_maas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dE_dogumTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dE_dogumTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_iletisimBilgiler)).EndInit();
            this.gC_iletisimBilgiler.ResumeLayout(false);
            this.gC_iletisimBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.SimpleButton btn_İptal;
        private DevExpress.XtraEditors.GroupControl gC_kisiselBilgiler;
        private System.Windows.Forms.NumericUpDown nUd_maas;
        private System.Windows.Forms.ComboBox cBox_unvan;
        private System.Windows.Forms.ComboBox cBox_cinsiyet;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private DevExpress.XtraEditors.DateEdit dE_dogumTarih;
        private System.Windows.Forms.Label lbl_dogumtarih;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label lbl_adısoyadı;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_tcno;
        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.Label lbl_maas;
        private System.Windows.Forms.Label lbl_egitimDurumu;
        private System.Windows.Forms.ComboBox cBox_egitimDurumu;
        private System.Windows.Forms.Label lbl_unvan;
        private DevExpress.XtraEditors.GroupControl gC_iletisimBilgiler;
        private System.Windows.Forms.ComboBox cBox_ilce;
        private System.Windows.Forms.ComboBox cBox_il;
        private System.Windows.Forms.Label lbl_ilce;
        private System.Windows.Forms.Label lbl_il;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.RichTextBox rTxt_adresi;
        private System.Windows.Forms.Label lbl_tel1;
        private System.Windows.Forms.Label lbl_tel2;
        private System.Windows.Forms.TextBox txt_tel2;
        private System.Windows.Forms.TextBox txt_tel1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}