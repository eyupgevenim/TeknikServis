namespace TeknikServis
{
    partial class pnlFirmaListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlFirmaListeleme));
            this.btn_firmasil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_firmaguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_firmasil
            // 
            this.btn_firmasil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(151)))), ((int)(((byte)(209)))));
            this.btn_firmasil.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(151)))), ((int)(((byte)(209)))));
            this.btn_firmasil.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(151)))), ((int)(((byte)(209)))));
            this.btn_firmasil.Appearance.Options.UseBackColor = true;
            this.btn_firmasil.Appearance.Options.UseBorderColor = true;
            this.btn_firmasil.Image = ((System.Drawing.Image)(resources.GetObject("btn_firmasil.Image")));
            this.btn_firmasil.Location = new System.Drawing.Point(946, 576);
            this.btn_firmasil.Name = "btn_firmasil";
            this.btn_firmasil.Size = new System.Drawing.Size(151, 40);
            this.btn_firmasil.TabIndex = 37;
            this.btn_firmasil.Text = "Sil";
            this.btn_firmasil.Click += new System.EventHandler(this.btn_firmasil_Click);
            // 
            // btn_firmaguncelle
            // 
            this.btn_firmaguncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_firmaguncelle.Image")));
            this.btn_firmaguncelle.Location = new System.Drawing.Point(777, 575);
            this.btn_firmaguncelle.Name = "btn_firmaguncelle";
            this.btn_firmaguncelle.Size = new System.Drawing.Size(151, 41);
            this.btn_firmaguncelle.TabIndex = 36;
            this.btn_firmaguncelle.Text = "Güncelle";
            this.btn_firmaguncelle.Click += new System.EventHandler(this.btn_firmaguncelle_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 10);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1095, 550);
            this.gridControl1.TabIndex = 38;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "ara ...";
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            // 
            // pnlFirmaListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn_firmasil);
            this.Controls.Add(this.btn_firmaguncelle);
            this.Location = new System.Drawing.Point(3, 10);
            this.Name = "pnlFirmaListeleme";
            this.Size = new System.Drawing.Size(1101, 649);
            this.Load += new System.EventHandler(this.pnlFirmaArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_firmasil;
        private DevExpress.XtraEditors.SimpleButton btn_firmaguncelle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
