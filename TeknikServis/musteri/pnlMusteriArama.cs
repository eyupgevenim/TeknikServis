using System;
using System.Data;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class pnlMusteriArama : UserControl
    {
        DataTable t;
        public pnlMusteriArama()
        {
            InitializeComponent();
        }

        // panel yüklendiğinde
        private void pnlMusteriArama_Load(object sender, EventArgs e)
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
            gridView1.SelectAll();
            gridView1.DeleteSelectedRows();
        }

        //arama buttonu
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (txt_ara.Text.Trim() !="")
            {
                gridView1.SelectAll();
                gridView1.DeleteSelectedRows();
                var sonuc = new BSatismusterisi().sMusteriAra(txt_ara.Text.Trim(), "", "");
                if (sonuc.basarliMi)
                {
                    foreach (var m in sonuc.veri)
                    {
                        t.Rows.Add(m.musteri_,m.adi,m.soyadi,m.tel,m.email,m._adres.adres, m._adres.ilce, m._adres.il, m._firma.firmaadi);
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

        //güncelle buttonu
        private void btn_firmaguncelle_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);
                var sonuc = new BSatismusterisi().sMusterilBilgisi((int)row["id"]);
                if (sonuc.basarliMi)
                {
                    frmMusteriGuncelle mg = new frmMusteriGuncelle();
                    mg.m = sonuc.veri;
                    mg.mA = this;
                    mg.ShowDialog();
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
            
        }

        //sil buttonu
        private void btn_firmasil_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);

                DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "Uyarı !!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var sonuc = new BSatismusterisi().sMusterilSil((int)row["id"]);
                    if (sonuc.basarliMi)
                    {
                        row.Delete();
                    }
                    else
                    {
                        MessageBox.Show(sonuc.mesaj);
                    }
                }

            }
        }
    }
}
