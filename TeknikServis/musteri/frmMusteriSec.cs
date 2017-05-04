using System;
using System.Data;
using System.Windows.Forms;

using BL;

namespace TeknikServis
{
    public partial class frmMusteriSec : Form
    {
        public pnlSiparisEkle2 _e2;
        DataTable t;

        public frmMusteriSec()
        {
            InitializeComponent();
        }

        // form yüklendiğinde
        private void frmMusteriSec_Load(object sender, EventArgs e)
        {
            t = new DataTable();
            t.Columns.Add("id", typeof(int));
            t.Columns.Add("adi", typeof(string));
            t.Columns["adi"].Caption = "ADI";
            t.Columns.Add("soyadi", typeof(string));
            t.Columns["soyadi"].Caption = "SOYADI";
            t.Columns.Add("tel", typeof(string));
            t.Columns["tel"].Caption = "TELEFON";
            t.Columns.Add("email", typeof(string));
            t.Columns["email"].Caption = "EMAİL";
            t.Columns.Add("adres", typeof(string));
            t.Columns["adres"].Caption = "ADRES";
            t.Columns.Add("ilce", typeof(string));
            t.Columns["ilce"].Caption = "İLÇE";
            t.Columns.Add("il", typeof(string));
            t.Columns["il"].Caption = "İL";
            t.Columns.Add("firma", typeof(string));
            t.Columns["firma"].Caption = "FİRMA";

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;
        }

        //temizle buttonu
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ara.Text = "";
            t.Rows.Clear();
        }

        //ara buttonu
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (txt_ara.Text.Trim() != "")
            {
                t.Rows.Clear();
                var sonuc = new BSatismusterisi().sMusteriAra(txt_ara.Text.Trim(), txt_ara.Text.Trim(), txt_ara.Text.Trim());
                if (sonuc.basarliMi)
                {
                    foreach (var m in sonuc.veri)
                    {
                        t.Rows.Add(m.musteri_, m.adi.Trim(), m.soyadi.Trim(), m.tel.Trim(), m.email.Trim(),
                            m._adres.adres.Trim(), m._adres.ilce.Trim(), m._adres.il.Trim(), m._firma.firmaadi.Trim());
                    }
                    gridControl1.DataSource = t;
                    gridView1.Columns["id"].Visible = false;

                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
            else
            {
                MessageBox.Show("Lütfen arama kelimesi girin !!!");
            }
        }

        //seç buttonu
        private void btn_sec_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);

                _e2.btnE_musteriSec.Text = row["adi"].ToString()+" "+ row["soyadi"].ToString();
                _e2.musteri_ = (int)row["id"];
                this.Close();
            }
            else
            {
                MessageBox.Show("Müşteri seçilmedi !!!");
            }
        }
    }
}
