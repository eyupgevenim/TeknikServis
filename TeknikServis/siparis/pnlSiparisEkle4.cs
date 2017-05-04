using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using BL;

namespace TeknikServis
{
    public partial class pnlSiparisEkle4 : UserControl
    {
        DataTable t;
        
        public pnlSiparisEkle4()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlSiparisEkle4_Load(object sender, EventArgs e)
        {
            t = new DataTable();
            t.Columns.Add("id", typeof(int));

            t.Columns.Add("katagori", typeof(string));
            t.Columns["katagori"].Caption = "KATAGORİ";
            t.Columns.Add("marka", typeof(string));
            t.Columns["marka"].Caption = "MARKA";
            t.Columns.Add("model", typeof(string));
            t.Columns["model"].Caption = "MODEL";
            t.Columns.Add("adet", typeof(int));
            t.Columns["adet"].Caption = "ÜRÜN ADETİ";
            t.Columns.Add("ucret", typeof(double));
            t.Columns["ucret"].Caption = "GELİŞ FİYATI";
            t.Columns.Add("toplam", typeof(double));
            t.Columns["toplam"].Caption = "TOPLAM FİYAT";
            t.Columns.Add("sil", typeof(Image));
            t.Columns["sil"].Caption = "SİLME";

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;
            gridView1.Columns["sil"].Visible = false;

            gridView1.Columns["toplam"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["toplam"].SummaryItem.DisplayFormat = "Toplam = {0}";
        }

        //özet müşteri bilgileri ve toplsm fiyatlar
        public void ozet(int musteri_)
        {
            var sonuc = new BSatismusterisi().sMusterilBilgisi(musteri_);
            if (sonuc.basarliMi)
            {
                var m = sonuc.veri;
                lbl_mAd.Text = "Müşteri Adı-Soyadı: "+m.adi.Trim()+" "+m.soyadi.Trim();
                lbl_mTel.Text = "Müşteri Telefonu: "+m.tel.Trim();
                lbl_mEmail1.Text = "Müşteri Email: "+m.email.Trim();
                lbl_mAdres.Text = "Müşteri Adresi: "+m._adres.adres+"\n"
                    +m._adres.ilce+"/"+m._adres.il;

                lbl_toplamUcret.Text = "Geliş Fiyatı: "+gridView1.Columns["toplam"].SummaryItem.SummaryValue.ToString();
                nUd_satisFiyat.Value = Convert.ToInt32(gridView1.Columns["toplam"].SummaryItem.SummaryValue);
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
        }

    }
}
