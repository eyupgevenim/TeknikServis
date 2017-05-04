using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.Drawing;

using BL;
using OBJ;


namespace TeknikServis
{
    public partial class pnlArizaUrunGoruntule : UserControl
    {
        public pnlServistekiArizaliUrunler sau;
        public pnlTeknikServisEleman tse;
        OArizaliurun a;
        int personel_;
        string adSoyad;

        public pnlArizaUrunGoruntule()
        {
            InitializeComponent();
        }

        private void pnlArizaUrunGoruntule_Load(object sender, EventArgs e)
        {
            a = new OArizaliurun();
            if (sau != null)
            {
                a = sau.au;

                if(sau._s != null)
                {
                    personel_ = sau._s._frmSekreter.personel_;
                    adSoyad = sau._s._frmSekreter.adSoyad;
                }
                else
                {
                    rTxt_gonder.Visible = false;
                    btn_gonder.Visible = false;
                }
            }
            else if (tse != null)
            {
                a = tse.au;
                personel_ = tse._frmTeknikEleman.personel_;
                adSoyad = tse._frmTeknikEleman.adSoyad;
            }

            //müşteri bilgileri
            lbl_mAd.Text="Müşteri Adı: " + a._musteri.adi;
            lbl_mSoyad.Text ="Müşteri Soyadı: " + a._musteri.soyadi;
            lbl_mTel.Text = "Müşteri Tel: " + a._musteri.tel;



            //arizalı ürün bilgileri
            lbl_urunAd.Text = "Ürün Adı: " + a.urunadi;
            lbl_urunModel.Text = "Ürün Model: " + a.urunmodel;
            lbl_urunSeriNo.Text = "Ürün Seri No: " + a.urunkodu;
            lbl_alinanAksesuar.Text = "Alinan Aksesuarlar:" + a.urunaksesuar;
            lbl_sifre.Text = "Şifre: " + a.sifre;
            lbl_bilgi.Text = "Bilgiler: " + a.aciklama;
            lbl_bildirilenAriza.Text = "Bildirilen Ariza: " + a.ariza;
            lbl_tespitedilenAriza.Text = "Tespit Edilen Ariza: " + a.tespitedilenariza;
            string kapsam = a.serviskapsam == 0 ? "Kapsamsız" : "Kapsamlı";
            lbl_servisKapsam.Text = "Servis Kapsamı: " + kapsam;
            string durum = a.durumu == 1 ? "Tamirde" : a.durumu == 2 ? "Bitti Yapıldı" : a.durumu == 3 ? "Bitti Yapılamadı !":"Teslim Edilmiş";
            lbl_durum.Text = "Durumu: " +  durum;

            //konuşmalar listesi
            Komusmalar(a._asama);

        }

        //gönder buttonu
        private void btn_gonder_Click(object sender, EventArgs e)
        {
            if(rTxt_gonder.Text.Trim() != "")
            {
                OAsama _a = new OAsama();
                _a.arizaliurun_ = a.aurun_;
                _a.aciklama = rTxt_gonder.Text.Trim();
                _a.tarih = DateTime.Now;
                OPersonel p = new OPersonel();
                p.personel_ = personel_;
                _a._personel = p;
                _a.gordu = false;

                var sonuc = new BArizaliurun().aAsamaEkle(_a);
                if (sonuc.basarliMi)
                {
                    yeniKonusma();
                    rTxt_gonder.Text = "";
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
            else
            {
                MessageBox.Show("Fütfen mesajınız varsa önce mesajınızı yazın sonra göndere basınız !",
                    "Boş bırakma hatası !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //konuşmalar groupControl
        public void Komusmalar(List<OAsama> _a)
        {
            int i = 0;
            foreach (OAsama a in _a)
            {
                GroupControl gC_ = new GroupControl();
                gC_.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                gC_.AppearanceCaption.ForeColor = Color.Blue;
                gC_.Location = new Point(3, 3);//gerek kalmayabilir
                gC_.Name = "gC_" + i.ToString();
                gC_.Size = new Size(400, 108);
                gC_.TabIndex = 0;
                gC_.Text = a._personel.adi.Trim() + " " + a._personel.soyadi.Trim() + " | " + a.tarih;

                Label lbl = new Label();
                lbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                lbl.Location = new Point(8, 30);
                lbl.Size = new System.Drawing.Size(397, 80);
                lbl.Name = "konusma";
                lbl.Text = a.aciklama.Trim();

                gC_.Controls.Add(lbl);
                flPnl_konusma.Controls.Add(gC_);

                flPnl_konusma.ScrollControlIntoView(gC_);//ekleninin scrollu ayarlar - yani scrollu sonuna getirir

                i++;
            }

        }

        //yeni konuşma ekleme
        private void yeniKonusma()
        {
            int i = flPnl_konusma.Controls.Count;

            GroupControl gC_ = new GroupControl();
            gC_.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            gC_.AppearanceCaption.ForeColor = Color.Blue;
            gC_.Location = new Point(3, 3);//gerek kalmayabilir
            gC_.Name = "gC_" + i.ToString();
            gC_.Size = new Size(400, 108);
            gC_.TabIndex = 0;
            gC_.Text = adSoyad+" | " + DateTime.Now;//personelin adı ve soyadı ve tarih

            Label lbl = new Label();
            lbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lbl.Location = new Point(8, 30);
            lbl.Size = new System.Drawing.Size(397, 80);
            lbl.Name = "konusma";
            lbl.Text = rTxt_gonder.Text.Trim();

            gC_.Controls.Add(lbl);
            flPnl_konusma.Controls.Add(gC_);
            flPnl_konusma.ScrollControlIntoView(gC_);
        }

        
    }
}
