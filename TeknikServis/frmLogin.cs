using System;
using System.Windows.Forms;
using System.Text;

using BL;

namespace TeknikServis
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //yüklendiğinde
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        // Giriş Yap buttonu
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Trim() != "" && txt_sifre.Text.Trim() != "")
                LOGIN();
            else
                MessageBox.Show("Email veya Şifreyi boş geçemezsiniz !!!");
        }

        //login fonk.
        private void LOGIN()
        {
            var sonuc = new BPersonel().Login(txt_email.Text.Trim(), new BPersonel().MD5(txt_sifre.Text.Trim()));
            if (sonuc.basarliMi)
            {
                //this.Close(); //Burada tüm programı kapatır başka ise formda sadece o formu kapatır.
                //Application.Exit(); // Hangi formda olursa olsun tüm programı kapatır.
                //.ShowDialog() da sadece o forma etki yapılabilir. .Show() da ise diğer formlara da etki yapılabilir.
                //this.Hide() ise  this.Visible = false aynı görev görür

                this.Visible = false;
                txt_email.Text = "";
                txt_sifre.Text = "";
                var veri = sonuc.veri;
                int personel_ = veri.personel_;
                int personeltip_ = veri.personelTipi_;
                string adSoyad = veri.adi.Trim() + " " + veri.soyadi.Trim();
                string email = veri.email;
                
                if (personeltip_ == 1)
                {
                    frmYonetici _y = new frmYonetici();
                    _y._frmLogin = this;
                    _y.personel_ = personel_;
                    _y.personeltip_ = personeltip_;
                    _y.adSoyad = adSoyad;
                    _y.email = email;
                    _y.ShowDialog();

                }
                else if (personeltip_ == 2)
                {
                    frmYoneticiAsistan _ya = new frmYoneticiAsistan();
                    _ya._frmLogin = this;
                    _ya.personel_ = personel_;
                    _ya.personeltip_ = personeltip_;
                    _ya.adSoyad = adSoyad;
                    _ya.email = email;
                    _ya.ShowDialog();
                }
                else if (personeltip_ == 3)
                {
                    frmSatisEleman _se = new frmSatisEleman();
                    _se._frmLogin = this;
                    _se.personel_ = personel_;
                    _se.personeltip_ = personeltip_;
                    _se.adSoyad = adSoyad;
                    _se.email = email;
                    _se.ShowDialog();
                }
                else if (personeltip_ == 4)
                {
                    frmSekreter _s = new frmSekreter();
                    _s._frmLogin = this;
                    _s.personel_ = personel_;
                    _s.personeltip_ = personeltip_;
                    _s.adSoyad = adSoyad;
                    _s.email = email;
                    _s.ShowDialog();
                }
                else if (personeltip_ == 5)
                {
                    frmTeknikEleman _te = new frmTeknikEleman();
                    _te._frmLogin = this;
                    _te.personel_ = personel_;
                    _te.personeltip_ = personeltip_;
                    _te.adSoyad = adSoyad;
                    _te.email = email;
                    _te.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
        }


        //şifremi unuttum link click olayı
        private void lnk_sifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlGiris.Visible = false;
            pnlSifremiUnuttum.Visible = true;
            //kodlar...
        }

        // Girişe geri dön linki click olayı
        private void lnk_giriseGeriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlSifremiUnuttum.Visible = false;
            pnlGiris.Visible = true;
            
        }

        //email gönder buttonu
        private void btn_EmaileSifreGonder_Click(object sender, EventArgs e)
        {
            if(txt_emailGonder.Text.Trim() != "")
            {
                string email = txt_emailGonder.Text.Trim();
                var sonuc = new BPersonel().emailSorgu(email);
                if (sonuc.basarliMi)
                {
                    string yeniSifre = sifreOlusturma();
                    var sifreDegistime = new BPersonel().sifreDegistirme(sonuc.veri, new BPersonel().MD5(yeniSifre));
                    if (sifreDegistime.basarliMi)
                    {
                        var emailGonderme = new BPersonel().emailGonderme("Biro Donanım Otomasyon şifresi", yeniSifre, email);
                        if (emailGonderme.basarliMi)
                        {
                            MessageBox.Show("Balarıyla emailine yeni şifren gonderilmiştie.",
                                "Email gonderme başarlı",MessageBoxButtons.OK,MessageBoxIcon.Information);

                            pnlSifremiUnuttum.Visible = false;
                            pnlGiris.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show(emailGonderme.mesaj);
                        }
                    }
                    else
                    {
                        MessageBox.Show(sifreDegistime.mesaj);
                    }
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
            else
            {
                MessageBox.Show("Boş geçemezsiniz !");
            }
            
        }

        //rastgeel şifre oluşturma
        private string sifreOlusturma()
        {
            Random rastgele = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int ascii = rastgele.Next(32, 127);
                char karakter = Convert.ToChar(ascii);

                sb.Append(karakter);
            }

            return sb.ToString();
        }
    }
}
