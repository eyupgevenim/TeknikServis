using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class pnlSiparisListesi : UserControl
    {
        public pnlSiparisIslem _pnlSiparis;
        public OSiparis _s;
        DataTable t;

        public pnlSiparisListesi()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlSiparisListesi_Load(object sender, EventArgs e)
        {
            t = new DataTable();
            t.Columns.Add("id", typeof(int));

            t.Columns.Add("urun", typeof(string));
            t.Columns["urun"].Caption = "ÜRÜNLER";
            t.Columns.Add("tarih", typeof(string));
            t.Columns["tarih"].Caption = "SİPARİŞ TARİHİ";
            t.Columns.Add("musteri", typeof(string));
            t.Columns["musteri"].Caption = "MÜŞTERİ";
            t.Columns.Add("adet", typeof(int));
            t.Columns["adet"].Caption = "ÜRÜN ADETİ";
            t.Columns.Add("toplam", typeof(double));
            t.Columns["toplam"].Caption = "TOPLAM FİYAT";

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;

            var sonuc = new BSiparis().siparisListele();
            if (sonuc.basarliMi)
            {
                //burası veri yapısa uygun değil
                foreach (var s in sonuc.veri)
                {
                    var m = new BSatismusterisi().sMusterilBilgisi(s.musteri_).veri;
                    string musteri = m.adi.Trim()+" "+m.soyadi.Trim();

                    string urunler = "";
                    int addet = 0;
                    foreach (var u in s.sepat)
                    {
                        var _u = new BUrun().urunBilgisi(u._urun.urunmodel_).veri;
                        urunler += _u.modeladi.Trim() + "-";
                        addet += u.urunsayisi;
                    }
                    
                    t.Rows.Add(s.siparis_,urunler,s.tarih,musteri,addet,s.toplamucret);
                }
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }


        }

        //------------------satır double click--------
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();

                DataRow row = gridView1.GetDataRow(info.RowHandle);
                var sonuc = new BSiparis().siparisBilgisi((int)row["id"]);
                if (sonuc.basarliMi)
                {
                    _s = sonuc.veri;
                    pnlSiparisEkleTemp s = new pnlSiparisEkleTemp();
                    _pnlSiparis.pnlSiparisIslamTemp.Controls.Clear(); 
                    s._pnlSiparisListesi = this;
                    _pnlSiparis.pnlSiparisIslamTemp.Controls.Add(s);
                    s.siparisGoruntuleme();
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
        }
        //-----------------satır double click sonu-------

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
                    var sonuc = new BSiparis().siparisSil((int)row["id"]);
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
