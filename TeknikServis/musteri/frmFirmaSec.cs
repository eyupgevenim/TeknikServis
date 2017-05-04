using System;
using System.Data;
using System.Windows.Forms;


using BL;
using OBJ;

namespace TeknikServis
{
    public partial class frmFirmaSec : Form
    {
        public pnlMusteriekle mE;

        DataTable t;

        public frmFirmaSec()
        {
            InitializeComponent();
        }

        private void frmFirmaAra_Load(object sender, EventArgs e)
        {
            t = new DataTable();
            t.Columns.Add("id", typeof(int));
            t.Columns.Add("adi", typeof(string));
            t.Columns["adi"].Caption = "FİRMA ADI";
            t.Columns.Add("email", typeof(string));
            t.Columns["email"].Caption = "EMAİL";
            t.Columns.Add("tel1", typeof(string));
            t.Columns["tel1"].Caption = "TELEFON 1";
            t.Columns.Add("tel2", typeof(string));
            t.Columns["tel2"].Caption = "TELEFON 2";
            t.Columns.Add("adres", typeof(string));
            t.Columns["adres"].Caption = "ADRES";
            t.Columns.Add("ilce", typeof(string));
            t.Columns["ilce"].Caption = "İLÇE";
            t.Columns.Add("il", typeof(string));
            t.Columns["il"].Caption = "İL";
            

            var sonuc = new BSatismusterisi().firmaListele();
            if (sonuc.basarliMi)
            {
                foreach (var f in sonuc.veri)
                {
                    t.Rows.Add(f.firma_, f.firmaadi, f.email, f.tel1, f.tel2, f._adres.adres, f._adres.ilce, f._adres.il);
                }
                gridControl1.DataSource = t;
                gridView1.Columns["id"].Visible = false;
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }

        }

        //seç buttonu
        private void btn_sec_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);

                mE.btnE_firmaAd.Text = row["adi"].ToString();
                mE.firma_ = (int)row["id"];
                this.Close();
            }
            else
            {
                MessageBox.Show("Firma seçilmedi !!!");
            }
        }
    }
}
