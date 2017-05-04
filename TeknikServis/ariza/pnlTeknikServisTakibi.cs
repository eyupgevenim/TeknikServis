using System;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class pnlTeknikServisTakibi : UserControl
    {
        public pnlYoneticiAnaMenu _pnlYoneticiAnaMenu;
        public pnlYoneticiAsistanAnaMenu _pnlYoneticiAsistanAnaMenu;

        public pnlTeknikServisTakibi()
        {
            InitializeComponent();
        }

        //panel yöklendiğinde
        private void pnlTeknikServisTakibi_Load(object sender, EventArgs e)
        {
            pnlServistekiArizaliUrunler sau = new pnlServistekiArizaliUrunler();
            pnlArizaTemp.Controls.Clear();
            if (_pnlYoneticiAsistanAnaMenu != null)
            {
                sau._pnlYoneticiAsistanAnaMenu = _pnlYoneticiAsistanAnaMenu;
            }
            else if(_pnlYoneticiAnaMenu != null)
            {
                sau._pnlTeknikServisTakibi = this;
            }
            pnlArizaTemp.Controls.Add(sau);
        }

        // teknikserviste bulunan cihazlar
        private void btn_servistebulunan_Click(object sender, EventArgs e)
        {
            pnlServistekiArizaliUrunler sau = new pnlServistekiArizaliUrunler();
            pnlArizaTemp.Controls.Clear();
            if (_pnlYoneticiAsistanAnaMenu != null)
            {
                sau._pnlYoneticiAsistanAnaMenu = _pnlYoneticiAsistanAnaMenu;
            }
            else if (_pnlYoneticiAnaMenu != null)
            {
                sau._pnlTeknikServisTakibi = this;
            }
            pnlArizaTemp.Controls.Add(sau);
        }

        //tamire gelmiş Eski cihazlar
        private void btn_eskiKayitlar_Click(object sender, EventArgs e)
        {
            pnlArizaTemp.Controls.Clear();
            pnlArizaTemp.Controls.Add(new pnlTamirEskiKayitlar());
        }

        //anasayfaya geri dön buttonu
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(_pnlYoneticiAnaMenu != null)
            {
                _pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Clear();
                _pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Add(_pnlYoneticiAnaMenu);
            }
            else if(_pnlYoneticiAsistanAnaMenu != null)
            {
                _pnlYoneticiAsistanAnaMenu._frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Clear();
                _pnlYoneticiAsistanAnaMenu._frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Add(_pnlYoneticiAsistanAnaMenu);
            }
            
        }

       
    }
}
