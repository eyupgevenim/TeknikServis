using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class pnlSiparisEkleTemp : UserControl
    {
        public pnlSiparisIslem _pnlSiparis;
        public pnlSiparisListesi _pnlSiparisListesi;

        private int siparis_=0;
        private int personel_ = 0;

        public bool yeniKayit = true;

        pnlSiparisBasla e1 = null;
        pnlSiparisEkle2 e2 = null;
        pnlSiparisEkle3 e3 = null;
        pnlSiparisEkle4 e4 = null;
        int sayac = 0;

        public pnlSiparisEkleTemp()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlSiparisEkleTemp_Load(object sender, EventArgs e)
        {
            sayac = 1;
            e1 = pnlSiparisBasla;
            e2 = pnlSiparisEkle2;
            e3 = pnlSiparisEkle3;
            e4 = pnlSiparisEkle4;

            btn_ileri.Enabled = false;
            btn_geri.Visible = false;
            btn_kaydet.Visible = false;
            btn_degistir.Visible = false;
            btn_tamam.Visible = false;

            e1.gridView1.RowCountChanged += new EventHandler(e1_gridView1_degistiginde);
            
        }
        
        // e1 in gridView1 i satır sayısı değiştiğinde
        private void e1_gridView1_degistiginde(object sender, EventArgs e)
        {
            if (e1.gridView1.RowCount > 0)
                btn_ileri.Enabled = true;
            else
                btn_ileri.Enabled = false;
        }
        
        //ileri buttonu
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 2)
            {
                e2.gridControl1.DataSource = e1.gridControl1.DataSource;
                e1.Visible = false;
                btn_geri.Visible = true;
                btn_ileri.Visible = false;
                btn_kaydet.Visible = true;
            } 
            else if (sayac == 3)
            {
                if (e2.musteri_ > 0)
                {
                    e3.gridControl1.DataSource = e2.gridControl1.DataSource;
                    e2.Visible = false;
                    btn_geri.Visible = false;
                }
                else
                {
                    sayac--;
                    MessageBox.Show("Fütfen müşteri seçin !", "Seçmeme Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (sayac == 4)
            {
                e4.gridControl1.DataSource = e3.gridControl1.DataSource;
                e3.Visible = false;
                btn_ileri.Visible = false;
                btn_geri.Visible = true;
                btn_degistir.Visible = false;
                btn_tamam.Visible = true;

                e4.ozet(e2.musteri_);
                
            }

        }

        //geri buttonu
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sayac--;
            if(sayac == 3)
            {
                e3.Visible = true;
                btn_ileri.Visible = true;
                btn_geri.Visible = false;
                btn_degistir.Visible = true;
                btn_tamam.Visible = false;
            }
            else if(sayac == 2)
            {
                e2.Visible = true;
            }
            else if(sayac == 1)
            {
                e1.Visible = true;
                btn_geri.Visible = false;
                btn_kaydet.Visible = false;
            }
        }

        //Siparişi kaydet buttonu
        private void btn_kaydet_tiklama(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {
                if (e2.musteri_ > 0)
                {
                    if (siparisEkleme())
                    {
                        yeniKayit = false;

                        e3.gridControl1.DataSource = e2.gridControl1.DataSource;
                        e2.Visible = false;
                        btn_ileri.Visible = true;
                        btn_geri.Visible = false;
                        btn_kaydet.Visible = false;
                        btn_degistir.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Sipariş kaydedilmedi !","Kayıt Hatası !!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    sayac--;
                    MessageBox.Show("Fütfen müşteri seçin !", "Seçmeme Hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //sipariş değiştir buttonu
        private void btn_degistir_tiklama(object sender, EventArgs e)
        {
            sayac--;
            if (sayac == 2)
            {
                e2.Visible = true;
                btn_geri.Visible = true;
                btn_kaydet.Visible = true;
                btn_degistir.Visible = false;
                
            }
        }

        //tamam buttonu
        private void btn_teslim_Click(object sender, EventArgs e)
        {
            OSiparis s = new OSiparis();
            s.siparis_ = siparis_;
            s.durumu = 2;
            s.satisfiyat = Convert.ToDouble(e4.nUd_satisFiyat.Value);

            var sonuc = new BSiparis().siparisDurumGuncelle(s);
            if (sonuc.basarliMi)
            {
                MessageBox.Show("Sipariş başarıyla tamlandı. \n Anasayfa'ya yönlendirileceksiniz.", "Sipariş Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_pnlSiparis == null)
                {
                    if (_pnlSiparisListesi._pnlSiparis._pnlYoneticiAnaMenu != null)
                    {
                        _pnlSiparisListesi._pnlSiparis._pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Clear();
                        _pnlSiparisListesi._pnlSiparis._pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Add(_pnlSiparisListesi._pnlSiparis._pnlYoneticiAnaMenu);
                    }
                    else if (_pnlSiparisListesi._pnlSiparis._pnlSatisElemaniAnaMenu != null)
                    {
                        _pnlSiparisListesi._pnlSiparis._pnlSatisElemaniAnaMenu._frmSatisEleman.pnlSatisElemenTemp.Controls.Clear();
                        _pnlSiparisListesi._pnlSiparis._pnlSatisElemaniAnaMenu._frmSatisEleman.pnlSatisElemenTemp.Controls.Add(_pnlSiparisListesi._pnlSiparis._pnlSatisElemaniAnaMenu);
                    }
                }
                else if (_pnlSiparis._pnlYoneticiAnaMenu != null)
                {
                    _pnlSiparis._pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Clear();
                    _pnlSiparis._pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Add(_pnlSiparis._pnlYoneticiAnaMenu);
                }
                else if (_pnlSiparis._pnlSatisElemaniAnaMenu != null)
                {
                    _pnlSiparis._pnlSatisElemaniAnaMenu._frmSatisEleman.pnlSatisElemenTemp.Controls.Clear();
                    _pnlSiparis._pnlSatisElemaniAnaMenu._frmSatisEleman.pnlSatisElemenTemp.Controls.Add(_pnlSiparis._pnlSatisElemaniAnaMenu);
                }
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
        }

        //sipariş ekleme fonksiyonu db veya GÜNCELLEME
        private bool siparisEkleme()
        {
            if(_pnlSiparis == null)
                personel_ = _pnlSiparisListesi._s.personel_;
            else if (_pnlSiparis._pnlYoneticiAnaMenu != null)
            {
                personel_ = _pnlSiparis._pnlYoneticiAnaMenu._frmYonetici.personel_;
                e3.personel.personel_ = personel_;
                e3.personel.adi = _pnlSiparis._pnlYoneticiAnaMenu._frmYonetici.adSoyad;
            }
            else if (_pnlSiparis._pnlSatisElemaniAnaMenu != null)
            {
                personel_ = _pnlSiparis._pnlSatisElemaniAnaMenu._frmSatisEleman.personel_;
                e3.personel.personel_ = personel_;
                e3.personel.adi = _pnlSiparis._pnlSatisElemaniAnaMenu._frmSatisEleman.adSoyad;
            }
            
            List<OSepet> sepet = new List<OSepet>();
            double tFiyat = 0;
            
            //gridview deki ürünleri sepet nesnesine ekleme
            for (int i = 0; i < e1.gridView1.RowCount; i++)
            {
                DataRow row = e1.gridView1.GetDataRow(i);
                tFiyat += (double)row["toplam"];

                OSepet s = new OSepet
                {
                    siparis_=siparis_,
                    _urun = new OUrun
                    {
                        urunmodel_ = (int)row["id"]
                    },
                    urunsayisi = (int)row["adet"],
                    toplamucret = (double)row["toplam"]
                };

                sepet.Add(s);
            }

            //sipariş nesini doldurmak
            OSiparis siparis = new OSiparis
            {
                siparis_=siparis_,
                musteri_ = e2.musteri_,
                tarih = DateTime.Now,
                toplamucret = tFiyat,
                personel_ = personel_,
                sepat = sepet
            };

            //yeni kayıtmı yoksa eski kayıtmı....
            if (yeniKayit)//yeni kayıt sonucu
            {
                var ekleme = new BSiparis().siparisEkle(siparis);
                if (ekleme.basarliMi)
                {
                    siparis_ = ekleme.veri;
                    e3.siparis.siparis_ = siparis_;//sipariş id siparişEkle3 de iletildi
                    MessageBox.Show("Artık fırsat konuşmaları yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(ekleme.mesaj);
                    return false;
                }
            }
            else//güncelleme sonucu
            {
                var guncelleme = new BSiparis().siparisGuncelle(siparis);
                if (guncelleme.basarliMi)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(guncelleme.mesaj);
                    return false;
                }
            }
            
            
        }//siparisEkleme()
        
        //sipariş görüntüleme
        public void siparisGoruntuleme()
        {
            yeniKayit = false;
            siparis_ = _pnlSiparisListesi._s.siparis_;

            sayac = 3;
            e1.Visible = false;
            e2.Visible = false;

            btn_ileri.Visible = true;
            btn_geri.Visible = false;
            btn_kaydet.Visible = false;
            btn_degistir.Visible = true;
            btn_tamam.Visible = false;

            DataTable t= siparisTablosu(_pnlSiparisListesi._s);
            e1.t = t;
            e1.gridControl1.DataSource = t;
            e2.gridControl1.DataSource = t;
            e3.gridControl1.DataSource = t;
            //e3.gridControl1.DataSource = siparisTablosu(_pnlSiparisListesi._s);

            e3.Komusmalar(_pnlSiparisListesi._s.firsat);
            e3.siparis.siparis_ = siparis_;
            if (_pnlSiparisListesi._pnlSiparis._pnlYoneticiAnaMenu != null)
            {
                e3.personel.personel_ = _pnlSiparisListesi._pnlSiparis._pnlYoneticiAnaMenu._frmYonetici.personel_;
                e3.personel.adi = _pnlSiparisListesi._pnlSiparis._pnlYoneticiAnaMenu._frmYonetici.adSoyad;
            }
            else if (_pnlSiparisListesi._pnlSiparis._pnlSatisElemaniAnaMenu != null)
            {
                e3.personel.personel_ = _pnlSiparisListesi._pnlSiparis._pnlSatisElemaniAnaMenu._frmSatisEleman.personel_;
                e3.personel.adi = _pnlSiparisListesi._pnlSiparis._pnlSatisElemaniAnaMenu._frmSatisEleman.adSoyad;
            }
            
            var musteri = new BSatismusterisi().sMusterilBilgisi(_pnlSiparisListesi._s.musteri_);
            e2.btnE_musteriSec.Text = musteri.veri.adi.Trim() + " " + musteri.veri.soyadi.Trim();
            e2.musteri_ = _pnlSiparisListesi._s.musteri_;
            //personel_ = _pnlSiparisListesi._s.personel_;

        }

        //sipariş tablosu
        private DataTable siparisTablosu(OSiparis s)
        {
            Image sil = Image.FromFile("..\\..\\img\\sil24x24.png");
            DataTable t = new DataTable();
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
            
            //gc.DataSource = t;
            //gv.Columns["id"].Visible = false;
            //gv.Columns["toplam"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //gv.Columns["toplam"].SummaryItem.DisplayFormat = "Toplam = {0}";

            foreach (OSepet i in s.sepat)
            {
                var u = new BUrun().urunBilgisi(i._urun.urunmodel_).veri;
                t.Rows.Add(i._urun.urunmodel_, u._katagori.katagoriadi, u._marka.markaadi, u.modeladi, i.urunsayisi, u.ucret, i.toplamucret, sil);
            }

            return t;
            
        }
        
    }
}
