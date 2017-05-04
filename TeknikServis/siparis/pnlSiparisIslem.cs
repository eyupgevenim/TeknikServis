using System;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class pnlSiparisIslem : UserControl
    {
        public pnlYoneticiAnaMenu _pnlYoneticiAnaMenu;
        public pnlSatisElemaniAnaMenu _pnlSatisElemaniAnaMenu;

        public pnlSiparisIslem()
        {
            InitializeComponent();
        }

        // panel yüklendiğinde
        private void pnlSiparis_Load(object sender, EventArgs e)
        {
            pnlSiparisListesi sl = new pnlSiparisListesi();
            pnlSiparisIslamTemp.Controls.Clear();
            sl._pnlSiparis = this;
            pnlSiparisIslamTemp.Controls.Add(sl);
        }

        //sipariş ekle
        private void btn_Siparisekle_Click(object sender, EventArgs e)
        {
            pnlSiparisEkleTemp s = new pnlSiparisEkleTemp();
            pnlSiparisIslamTemp.Controls.Clear();
            s._pnlSiparis = this;
            pnlSiparisIslamTemp.Controls.Add(s);
        }

        //sipariş listele
        private void btn_Siparislistele_Click(object sender, EventArgs e)
        {
            pnlSiparisListesi sl = new pnlSiparisListesi();
            pnlSiparisIslamTemp.Controls.Clear();
            sl._pnlSiparis = this;
            pnlSiparisIslamTemp.Controls.Add(sl);
        }

        //ana sayfaya dön buttonu
        private void btn_anaSayfayaGeriDon_Click(object sender, EventArgs e)
        {
            if (_pnlYoneticiAnaMenu != null)
            {
                _pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Clear();
                _pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Add(_pnlYoneticiAnaMenu);
            }
            else if (_pnlSatisElemaniAnaMenu != null)
            {
                _pnlSatisElemaniAnaMenu._frmSatisEleman.pnlSatisElemenTemp.Controls.Clear();
                _pnlSatisElemaniAnaMenu._frmSatisEleman.pnlSatisElemenTemp.Controls.Add(_pnlSatisElemaniAnaMenu);
            }
        }

        
    }
}
