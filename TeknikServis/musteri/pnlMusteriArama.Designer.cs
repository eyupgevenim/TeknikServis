namespace TeknikServis
{
    partial class pnlMusteriArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlMusteriArama));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ara = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_firmasil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_firmaguncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.btn_temizle);
            this.panelControl2.Controls.Add(this.btn_ara);
            this.panelControl2.Controls.Add(this.txt_ara);
            this.panelControl2.Location = new System.Drawing.Point(3, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(239, 546);
            this.panelControl2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adı:";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.Location = new System.Drawing.Point(18, 93);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(89, 38);
            this.btn_temizle.TabIndex = 9;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Image = ((System.Drawing.Image)(resources.GetObject("btn_ara.Image")));
            this.btn_ara.Location = new System.Drawing.Point(129, 93);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(89, 38);
            this.btn_ara.TabIndex = 8;
            this.btn_ara.Text = "Ara";
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ara.Location = new System.Drawing.Point(18, 47);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(200, 26);
            this.txt_ara.TabIndex = 7;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(259, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(839, 546);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // btn_firmasil
            // 
            this.btn_firmasil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(151)))), ((int)(((byte)(209)))));
            this.btn_firmasil.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(151)))), ((int)(((byte)(209)))));
            this.btn_firmasil.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(151)))), ((int)(((byte)(209)))));
            this.btn_firmasil.Appearance.Options.UseBackColor = true;
            this.btn_firmasil.Appearance.Options.UseBorderColor = true;
            this.btn_firmasil.Image = ((System.Drawing.Image)(resources.GetObject("btn_firmasil.Image")));
            this.btn_firmasil.Location = new System.Drawing.Point(983, 556);
            this.btn_firmasil.Name = "btn_firmasil";
            this.btn_firmasil.Size = new System.Drawing.Size(109, 40);
            this.btn_firmasil.TabIndex = 39;
            this.btn_firmasil.Text = "Sil";
            this.btn_firmasil.Click += new System.EventHandler(this.btn_firmasil_Click);
            // 
            // btn_firmaguncelle
            // 
            this.btn_firmaguncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_firmaguncelle.Image")));
            this.btn_firmaguncelle.Location = new System.Drawing.Point(850, 555);
            this.btn_firmaguncelle.Name = "btn_firmaguncelle";
            this.btn_firmaguncelle.Size = new System.Drawing.Size(109, 41);
            this.btn_firmaguncelle.TabIndex = 38;
            this.btn_firmaguncelle.Text = "Güncelle";
            this.btn_firmaguncelle.Click += new System.EventHandler(this.btn_firmaguncelle_Click);
            // 
            // pnlMusteriArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_firmasil);
            this.Controls.Add(this.btn_firmaguncelle);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Location = new System.Drawing.Point(3, 10);
            this.Name = "pnlMusteriArama";
            this.Size = new System.Drawing.Size(1101, 649);
            this.Load += new System.EventHandler(this.pnlMusteriArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txt_ara;
        private DevExpress.XtraEditors.SimpleButton btn_ara;
        private DevExpress.XtraEditors.SimpleButton btn_temizle;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btn_firmasil;
        private DevExpress.XtraEditors.SimpleButton btn_firmaguncelle;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
