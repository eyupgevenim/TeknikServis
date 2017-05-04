using System;
using System.Data;
using System.Windows.Forms;

using BL;

namespace TeknikServis
{
    public partial class pnlTumUrunListesi : UserControl
    {
        public pnlTumUrunListesi()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlTumUrunListesi_Load(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            t.Columns.Add("id", typeof(int));
            t.Columns.Add("model", typeof(string));
            t.Columns["model"].Caption = "MODEL";
            t.Columns.Add("stokadet", typeof(int));
            t.Columns["stokadet"].Caption = "STOK ADETİ";
            t.Columns.Add("ucret", typeof(double));
            t.Columns["ucret"].Caption = "GELİŞ FİYATI";
            t.Columns.Add("tarih", typeof(DateTime));
            t.Columns["tarih"].Caption = "KAYIT TARİHİ";
            t.Columns.Add("marka", typeof(string));
            t.Columns["marka"].Caption = "MARKA";
            t.Columns.Add("katagori", typeof(string));
            t.Columns["katagori"].Caption = "KATAGORİ";
            
            gridView1.SelectAll();
            gridView1.DeleteSelectedRows();

            var sonuc = new BUrun().urunListele();
            if (sonuc.basarliMi)
            {
                foreach (var u in sonuc.veri)
                {
                    t.Rows.Add(u.urunmodel_, u.modeladi, u.stoksayisi,
                        u.ucret, u.tarih, u._marka.markaadi, u._katagori.katagoriadi);
                }
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
            
            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;


        }

        //güncelle buttonu
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);

                var sonuc = new BUrun().urunBilgisi((int)row["id"]);
                if (sonuc.basarliMi)
                {
                    frmStokGüncelle _u = new frmStokGüncelle();
                    _u.u = sonuc.veri;
                    _u.tul = this;
                    _u.ShowDialog();

                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
        }

        // sil buttonu
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);

                DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "Uyarı !!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var sonuc = new BUrun().urunSil((int)row["id"]);
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
