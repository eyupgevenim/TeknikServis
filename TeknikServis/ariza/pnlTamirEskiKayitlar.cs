using System;
using System.Data;
using System.Windows.Forms;

using BL;

namespace TeknikServis
{
    public partial class pnlTamirEskiKayitlar : UserControl
    {
        DataTable t;

        public pnlTamirEskiKayitlar()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlTamirEskiKayitlar_Load(object sender, EventArgs e)
        {
            t = new DataTable();
            t.Columns.Add("id", typeof(int));
            t.Columns.Add("urunadi", typeof(string));
            t.Columns["urunadi"].Caption = "ÜRÜN ADI";
            t.Columns.Add("tAriza", typeof(string));
            t.Columns["tAriza"].Caption = "TESPİT EDİLEN ARIZA";
            t.Columns.Add("musteri", typeof(string));
            t.Columns["musteri"].Caption = "MÜŞTERİ";
            t.Columns.Add("tel", typeof(string));
            t.Columns["tel"].Caption = "MÜŞTERİ TEL";
            t.Columns.Add("personel", typeof(string));
            t.Columns["personel"].Caption = "KAYDI ALAN";
            t.Columns.Add("teknik", typeof(string));
            t.Columns["teknik"].Caption = "TEKNİK ELEMAN";
            //t.Columns.Add("kayittarih", typeof(DateTime)); //sadece tarih görünüyor
            t.Columns.Add("kayittarih", typeof(string)); //daha ayrıntılı
            t.Columns["kayittarih"].Caption = "KAYIT TARİHİ";

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;
        }

        //ara buttonu
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if(txt_ad.Text !="" || dE_tarih.Text != "")
            {
                t.Rows.Clear();
                //gridView1.SelectAll();
                //gridView1.DeleteSelectedRows();

                var sonuc = new BArizaliurun().aGecmistekiListesi(txt_ad.Text.Trim(), dE_tarih.DateTime);
                if (sonuc.basarliMi)
                {
                    foreach (var a in sonuc.veri)
                    {
                        t.Rows.Add(a.aurun_, a.urunadi, a.tespitedilenariza, a._musteri.adi.Trim()+" "+ a._musteri.soyadi, a._musteri.tel,
                            a._personel.adi.Trim()+" "+ a._personel.soyadi, a._teknik.adi.Trim()+" "+ a._teknik.soyadi,a.kayittarih);
                    }
                    gridControl1.DataSource = t;

                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
            else
            {
                MessageBox.Show("Müşteri adı veya kayıt tarihi giriniz !!!");
            }
            
        }

        //temizle buttonu
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            //çoklu select kapalı olduğu için çalışmaz
            //gridView1.SelectAll();
            //gridView1.DeleteSelectedRows();

            t.Rows.Clear();
            txt_ad.Text = "";
            dE_tarih.Text = "";
        }

        
    }
}
