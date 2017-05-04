using System;
using System.Windows.Forms;
using System.Drawing;

using BL;


namespace TeknikServis
{
    public partial class frmSifreDegistirme : Form
    {
        public frmYonetici _frmYonetici;
        public frmYoneticiAsistan _frmYoneticiAsistan;
        public frmSatisEleman _frmSatisEleman;
        public frmSekreter _frmSekreter;
        public frmTeknikEleman _frmTeknikEleman;

        public frmSifreDegistirme()
        {
            InitializeComponent();
        }

        private void frmSifreDegistirme_Load(object sender, EventArgs e)
        {
            this.Location = new Point(400, 100);
        }

        //kaydet buttonu
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string email="";
            if (_frmYonetici != null)
            {
                email = _frmYonetici.email;
            }
            else if(_frmYoneticiAsistan != null)
            {
                email = _frmYoneticiAsistan.email;
            }
            else if(_frmSatisEleman != null)
            {
                email = _frmSatisEleman.email;
            }
            else if (_frmSekreter != null)
            {
                email = _frmSekreter.email;
            }
            else if (_frmTeknikEleman != null)
            {
                email = _frmTeknikEleman.email;
            }

            if(txt_eski.Text.Trim() != "" && txt_yeni.Text.Trim() != "" && txt_yeniTekrar.Text.Trim() != "")
            {
                BPersonel p = new BPersonel();
                var sonuc = p.Login(email,p.MD5(txt_eski.Text.Trim()));
                if (sonuc.basarliMi)
                {
                    if (txt_yeni.Text.Trim() == txt_yeniTekrar.Text.Trim())
                    {
                        var guncellemeSonuc=p.sifreDegistirme(sonuc.veri.personel_, p.MD5(txt_yeni.Text.Trim()));
                        if (guncellemeSonuc.basarliMi)
                            this.Close();
                        else
                            MessageBox.Show(guncellemeSonuc.mesaj);
                    }
                    else
                    {
                        MessageBox.Show("Yeni şifreler eşleşmiyor !!!");
                    }
                        
                }
                else
                {
                    MessageBox.Show("Eski şifrenizi yanlış !!!");
                }
            }
            else
            {
                MessageBox.Show("Boş alan geçemezsimiz !!!");
            }
            

        }
        
    }
}
