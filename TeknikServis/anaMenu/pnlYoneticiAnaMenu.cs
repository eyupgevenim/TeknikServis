using System;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class pnlYoneticiAnaMenu : UserControl
    {
        public frmYonetici _frmYonetici;

        public pnlYoneticiAnaMenu()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlYoneticiAnaMenu_Load(object sender, EventArgs e)
        {

        }

        // Personel işlemleri click
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            pnlPersonelislemleri pi = new pnlPersonelislemleri();
            pi._pnlYoneticiAnaMenu = this;
            _frmYonetici.pnlYoneticiTemp.Controls.Clear();
            _frmYonetici.pnlYoneticiTemp.Controls.Add(pi);

        }

        // Servisteki cihazlar click
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pnlTeknikServisTakibi tst = new pnlTeknikServisTakibi();
            tst._pnlYoneticiAnaMenu = this;
            _frmYonetici.pnlYoneticiTemp.Controls.Clear();
            _frmYonetici.pnlYoneticiTemp.Controls.Add(tst);
        }

        // Stok takip click
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            pnlStokislem si = new pnlStokislem();
            si._pnlYoneticiAnaMenu = this;
            _frmYonetici.pnlYoneticiTemp.Controls.Clear();
            _frmYonetici.pnlYoneticiTemp.Controls.Add(si);
        }

        //Satış İşlemleri click
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            pnlSiparisIslem s = new pnlSiparisIslem();
            s._pnlYoneticiAnaMenu = this;
            _frmYonetici.pnlYoneticiTemp.Controls.Clear();
            _frmYonetici.pnlYoneticiTemp.Controls.Add(s);
        }

        //Müşteri işlemleri click
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            pnlMusteriIslemleri mi = new pnlMusteriIslemleri();
            mi._pnlYoneticiAnaMenu = this;
            _frmYonetici.pnlYoneticiTemp.Controls.Clear();
            _frmYonetici.pnlYoneticiTemp.Controls.Add(mi);
        }
    }
}
