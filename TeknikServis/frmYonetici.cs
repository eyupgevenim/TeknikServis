using DevExpress.Utils.Menu;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class frmYonetici : Form
    {
        public frmLogin _frmLogin;
        public int personel_;
        public string adSoyad;
        public int personeltip_;
        public string email;

        bool kapatma;

        public frmYonetici()
        {
            InitializeComponent();

            kapatma = true;
        }

        private void frmYonetici_Load(object sender, EventArgs e)
        {
            //Ana menüler(kart menüler) oluşturma
            pnlYoneticiAnaMenu ym = new pnlYoneticiAnaMenu();
            ym._frmYonetici = this;
            pnlYoneticiTemp.Controls.Add(ym);

            //kullanıcı menu oluşturma
            kullaniciMenu();
        }

        // kullanıcı hesap menü dizayn
        private void kullaniciMenu()
        {
            EventHandler bilgileriniGuncelle = new EventHandler(bilgileriniGuncelle_Tiklama);
            EventHandler sifreDegistirme = new EventHandler(sifreDegistirme_Tiklama);
            EventHandler cikisYap = new EventHandler(cikisYap_Tiklama);
            drpD_kullanici.Text = adSoyad;
            DXPopupMenu menu = new DXPopupMenu();
            menu.Items.Add(new DXMenuItem("Bilgilerini Güncelle", bilgileriniGuncelle, Image.FromFile("..\\..\\img\\guncelle32x32.png")));
            menu.Items.Add(new DXMenuItem("Şifreni Değiştir", sifreDegistirme, Image.FromFile("..\\..\\img\\sifre_deg32x32.png")));
            menu.Items.Add(new DXMenuItem("Çıkış Yap", cikisYap, Image.FromFile("..\\..\\img\\cikis32x32.png")));
            drpD_kullanici.DropDownControl = menu;
        }

        // Bilgilerini güncelleye tıklandığında
        private void bilgileriniGuncelle_Tiklama(object sender, EventArgs e)
        {
            frmBilgileriniGuncelle pg = new frmBilgileriniGuncelle();
            pg._frmYonetici = this;
            pg.ShowDialog();
        }

        // Şifreni değiştire tıklandığında
        private void sifreDegistirme_Tiklama(object sender, EventArgs e)
        {
            frmSifreDegistirme sd = new frmSifreDegistirme();
            sd._frmYonetici = this;
            sd.ShowDialog();
        }

        // Çıkış Yap'a tıklandığında
        private void cikisYap_Tiklama(object sender, EventArgs e)
        {
            kapatma = false;
            this.Close();
            _frmLogin.Visible = true;
        }

        //form kapatılıyorken
        private void frmYonetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult evetVeyaHayir= MessageBox.Show("Yarıda kalmış bir işleminiz varsa hatayla karşılaşabilirsiniz."+
            //    "Yine de kapatmak istiyor musun?", "Uyarı !!!", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(kapatma)
                if(MessageBox.Show("Yarıda kalmış bir işleminiz varsa hatayla karşılaşabilirsiniz." +
                    "Yine de kapatmak istiyor musun?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    _frmLogin.Close();
                }
                else
                {
                    e.Cancel = true;
                }
        }
    }
}
