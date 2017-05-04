using System;
using System.Collections.Generic;
using System.Text;
using DAL.Siniflar;
using OBJ;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace BL
{
    public class BPersonel :DPersonel
    {
        //Kullanıcı Giriş
        public new OIslemSonuc<OPersonel> Login(string _email, string _sifre)
        {
            var sonuc = base.Login(_email,_sifre);
            if(sonuc.hataBilgisi != null)
            {
                // hatalar veritabanına kaydı...
            }
            return sonuc;
        }//Login()

        // Personel ekleme
        public new OIslemSonuc<bool> personelEkle(OPersonel _p)
        {
            /*
            var sonuc = new BAdres().adresEkleme(_p.adres);
            if (sonuc.basarliMi )
            {
                _p.adres.adres_ = sonuc.veri;
                return base.personelEkle(_p);
            }
            else
            {
                return new OIslemSonuc<bool>
                {
                    basarliMi=false,
                    veri=false,
                    hataBilgisi=sonuc.hataBilgisi
                };
            }
            */

            return base.personelEkle(_p);
            
        }//personelEkle()

        // Personel güncelleme
        public new OIslemSonuc<bool> personelGuncelle(OPersonel _p)
        {
            return base.personelGuncelle(_p);
        }//personelGuncelle()

        // Personel silme
        public new OIslemSonuc<bool> personelSil(int id)
        {
            return base.personelSil(id);
        }//personelSil()

        // Personel bilgisi
        public new OIslemSonuc<OPersonel> personelBilgisi(int id)
        {
            return base.personelBilgisi(id);
        }//personelBilgisi()

        // Personel arama
        public new OIslemSonuc<List<OPersonel>> personelAra(string ad, string soyad, string tc, string email)
        {
            return base.personelAra(ad, soyad, tc, email);
        }//personelAra()

        // Personel tipine göre arama
        public new  OIslemSonuc<List<OPersonel>> tipeGoreAra(int personeltip_)
        {
            return base.tipeGoreAra(personeltip_);
        }//tipeGoreAra()

        // Personelleri Listeleme
        public new OIslemSonuc<List<OPersonel>> personelListele()
        {
            return base.personelListele();
        }//personelListele()

        //şifre değiştirme
        public new OIslemSonuc<bool> sifreDegistirme(int personel_,string yeniSifre)
        {
            return base.sifreDegistirme(personel_, yeniSifre);
        }//sifreDegistirme()

        //MD5 hash algoritması
        public string MD5(string _psw)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] btr = Encoding.UTF8.GetBytes(_psw);
            btr = md5.ComputeHash(btr);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            
            return sb.ToString();
        }

        //Email gönderme
        public OIslemSonuc<bool> emailGonderme(string konu,string icerik,string aliciEmail)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("eyupgevenim@gmail.com");  //gönderici
                message.To.Add(new MailAddress(aliciEmail)); // aliciEmail
                message.Subject = konu;
                message.Body =icerik;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("burodonanim.teknikservis@gmail.com", "0123456789abc");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                return new OIslemSonuc<bool>
                {
                    basarliMi=true
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc < bool >
                {
                    basarliMi=false,
                    hataBilgisi=new OHata
                    {
                        hataMesaj=e.Message,
                        sinif="BPersonel",
                        method="emailGonderme"
                    }
                };
            }
        }

        // Personel emailini sorgulama
        public new OIslemSonuc<int> emailSorgu(string email)
        {
            return base.emailSorgu(email);
        }

    }
}
