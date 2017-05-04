using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using BL;

namespace TeknikServis
{
    public partial class pnlEskiSiparis : UserControl
    {
        DataTable t;

        public pnlEskiSiparis()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlEskiSiparis_Load(object sender, EventArgs e)
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

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;
            
        }

        //ara buttonu
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text.Trim() != "")
            {
                t.Rows.Clear();

                var sonuc = new BSiparis().siparisAra(txt_ad.Text.Trim());
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

                        t.Rows.Add(s.siparis_, urunler, s.tarih, musteri, addet, s.toplamucret, s.satisfiyat);
                    }

                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
            else
            {
                MessageBox.Show("Arama keslimesini boş geçemezsiniz !!!");
            }
        }

        //temizle buttonu
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            t.Rows.Clear();
            txt_ad.Text = "";
        }
    }
}
