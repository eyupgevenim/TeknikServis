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
    public partial class pnlTeslimEdilmemisSiparis : UserControl
    {
        public bool tesliEdilmisMi = false;
        DataTable t;

        public pnlTeslimEdilmemisSiparis()
        {
            InitializeComponent();
        }

        //yüklendiğinde
        private void pnlteslimEdilmemisSiparis_Load(object sender, EventArgs e)
        {
            Image btn = Image.FromFile("..\\..\\img\\teslim24x24.png");
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
            t.Columns.Add("sFiyat", typeof(double));
            t.Columns["sFiyat"].Caption = "SATIŞ FİYATI";
            t.Columns.Add("teslim", typeof(Image));
            t.Columns["teslim"].Caption = "TESLİMAT ONAYI";

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;

            var sonuc = new BSiparis().teslimEdilmemisSiparisListele();
            if (sonuc.basarliMi)
            {
                //burası veri yapısa uygun değil
                foreach (var s in sonuc.veri)
                {
                    var m = new BSatismusterisi().sMusterilBilgisi(s.musteri_).veri;
                    string musteri = m.adi.Trim() + " " + m.soyadi.Trim();

                    string urunler = "";
                    int addet = 0;
                    foreach (var u in s.sepat)
                    {
                        var _u = new BUrun().urunBilgisi(u._urun.urunmodel_).veri;
                        urunler += _u.modeladi.Trim() + "-";
                        addet += u.urunsayisi;
                    }

                    t.Rows.Add(s.siparis_, urunler, s.tarih, musteri, addet, s.toplamucret,s.satisfiyat,btn);
                }
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
        }

        //gridviwe tıklama
        //hücreye tıklama olayı yapılmıi ve sil hücresine basıldığında siler
        private void gridView1_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(MousePosition);

            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {

                string colName = info.Column == null ? "N/A" : info.Column.FieldName;
                int index = info.RowHandle;

                //info.Column.FieldName ==> içinde column ismi var
                //info.Column.Name ==> içinde col+column ismi var(colsil gibi)
                //info.RowHandle ==> içinde satır indexi var

                if (colName == "teslim")
                {
                    DialogResult eh = MessageBox.Show("Sipariş müşteriye teslim edildi mi ? \n" +
                    "Onaylıyorsanız sipariş bu listede kalkacak eski kayıtlara eklenecektir.", "Uyarı !!!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (eh==DialogResult.Yes)
                    {
                        DataRow row = gridView1.GetDataRow(index);

                        OSiparis s = new OSiparis();
                        s.siparis_ = (int)row["id"];
                        s.durumu = 3;
                        s.satisfiyat = Convert.ToDouble(row["sFiyat"]);

                        var sonuc = new BSiparis().siparisDurumGuncelle(s);
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

                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));

            }
        }//gridView1_Click()

    }
}
