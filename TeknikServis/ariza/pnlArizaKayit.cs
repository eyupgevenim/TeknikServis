using System;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class pnlArizaKayit : DevExpress.XtraEditors.XtraUserControl
    {
        public pnlSekreter _s;
        public int musteri_ = 0;

        public pnlArizaKayit()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlArizaKayit_Load(object sender, EventArgs e)
        {
            cBox_serviskap.SelectedIndex = 0;

            var sonuc = new BPersonel().tipeGoreAra(5);
            if (sonuc.basarliMi)
            {
                cBox_teknikEleman.DataSource = sonuc.veri;
                cBox_teknikEleman.ValueMember = "personel_";
                cBox_teknikEleman.DisplayMember = "adi";
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
        }

        //kayıtlı müşteri seçimi değiştiğinde
        private void chBox_musteriSec_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_musteriSec.Checked)
            {
                btnE_musteriSec.Enabled = true;
                txt_ad.Enabled = false;
                txt_soyad.Enabled = false;
                txt_tel.Enabled = false;
                txt_email.Enabled = false;

                txt_ad.Text="";
                txt_soyad.Text = "";
                txt_tel.Text = "";
                txt_email.Text = "";
            }
            else
            {
                btnE_musteriSec.Enabled = false;
                txt_ad.Enabled = true;
                txt_soyad.Enabled = true;
                txt_tel.Enabled = true;
                txt_email.Enabled = true;

                btnE_musteriSec.Text = "";
                musteri_ = 0;
            }
        }

        //... Müşteri seç button 
        private void btnE_musteriSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmArizaliMusteriSec ams = new frmArizaliMusteriSec();
            ams._pnlArizaKayit = this;
            ams.ShowDialog();
        }

        //kaydet buttonu
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if(musteri_ > 0)
            {
                if (txt_urunAd.Text != "" && txt_urunModel.Text != "" && txt_urunSeriNo.Text != "" &&txt_alinanAksesuar.Text != "" 
                    && txt_sifre.Text != "" && rTxt_bilgi.Text != "" && rText_bildirilenAriza.Text != "" && rTxt_tespitedilenAriza.Text != "")
                {
                    ///<ozet>
                    ///arzalı ürünün 4 durumu olacak
                    ///1.kayıt yapıldı teknik serviste
                    ///2.temair bitti yapıldı
                    ///3.tamir bitti yapılamadı
                    ///4.teslim edildi
                    /// </ozet>

                    OArizaliurun a = new OArizaliurun();
                    a.durumu = 1;//4 durum var
                    a.urunadi = txt_urunAd.Text.Trim();
                    a.urunmodel = txt_urunModel.Text.Trim();
                    a.urunkodu = txt_urunSeriNo.Text.Trim();
                    a.urunaksesuar = txt_alinanAksesuar.Text.Trim();
                    a.sifre = txt_sifre.Text.Trim();
                    a.aciklama = rTxt_bilgi.Text.Trim();
                    a.ariza = rText_bildirilenAriza.Text.Trim();
                    a.tespitedilenariza = rTxt_tespitedilenAriza.Text.Trim();
                    a.arizabedeli = (int)nUd_arizabedeli.Value;
                    a.serviskapsam = cBox_serviskap.SelectedIndex + 1; // iki durum var
                    a.kayittarih = DateTime.Now;

                    OPersonel p = new OPersonel();
                    p.personel_ = _s._frmSekreter.personel_;
                    a._personel = p;
                    OPersonel t = new OPersonel();
                    t.personel_ = (int)cBox_teknikEleman.SelectedValue;
                    a._teknik = t;

                    var sonuc = new BArizaliurun().sadeceArizaliUrunEkle(a);
                    if (sonuc.basarliMi)
                    {
                        MessageBox.Show("Başarlı");
                        //formlar temizlenir.
                        //ve servisteki cihazlara dünülür...
                    }
                    else
                    {
                        MessageBox.Show(sonuc.mesaj);
                    }
                }
                else
                {
                    MessageBox.Show("Alanları boş bırakamazsınız !", "Boş bırakma hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txt_ad.Text != "" && txt_soyad.Text != "" && txt_tel.Text != "" && txt_email.Text != ""
                 && txt_urunAd.Text != "" && txt_urunModel.Text != "" && txt_urunSeriNo.Text != "" &&
                txt_alinanAksesuar.Text != "" && txt_sifre.Text != "" && rTxt_bilgi.Text != "" && rText_bildirilenAriza.Text != "" &&
                rTxt_tespitedilenAriza.Text != "")
                {
                    ///<ozet>
                    ///arzalı ürünün 4 durumu olacak
                    ///1.kayıt yapıldı teknik serviste
                    ///2.temair bitti yapıldı
                    ///3.tamir bitti yapılamadı
                    ///4.teslim edildi
                    /// </ozet>

                    OArizaliurun a = new OArizaliurun();
                    a.durumu = 1;//4 durum var
                    a.urunadi = txt_urunAd.Text.Trim();
                    a.urunmodel = txt_urunModel.Text.Trim();
                    a.urunkodu = txt_urunSeriNo.Text.Trim();
                    a.urunaksesuar = txt_alinanAksesuar.Text.Trim();
                    a.sifre = txt_sifre.Text.Trim();
                    a.aciklama = rTxt_bilgi.Text.Trim();
                    a.ariza = rText_bildirilenAriza.Text.Trim();
                    a.tespitedilenariza = rTxt_tespitedilenAriza.Text.Trim();
                    a.arizabedeli = (int)nUd_arizabedeli.Value;
                    a.serviskapsam = cBox_serviskap.SelectedIndex + 1; // iki durum var
                    a.kayittarih = DateTime.Now;

                    OPersonel p = new OPersonel();
                    p.personel_ = _s._frmSekreter.personel_;
                    a._personel = p;
                    OPersonel t = new OPersonel();
                    t.personel_ = (int)cBox_teknikEleman.SelectedValue;
                    a._teknik = t;

                    OMusteri m = new OMusteri();
                    m.adi = txt_ad.Text;
                    m.soyadi = txt_soyad.Text;
                    m.tel = txt_tel.Text;
                    m.email = txt_email.Text;
                    m.kayittarihi = DateTime.Now;
                    a._musteri = m;

                    var sonuc = new BArizaliurun().aUrunEkle(a);
                    if (sonuc.basarliMi)
                    {
                        MessageBox.Show("Başarlı");
                        //formlar temizlenir.
                        //ve servisteki cihazlara dünülür...
                    }
                    else
                    {
                        MessageBox.Show(sonuc.mesaj);
                    }
                }
                else
                {
                    MessageBox.Show("Alanları boş bırakamazsınız !", "Boş bırakma hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        
    }
}
