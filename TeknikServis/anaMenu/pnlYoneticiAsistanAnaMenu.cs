using System;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class pnlYoneticiAsistanAnaMenu : UserControl
    {
        public frmYoneticiAsistan _frmYoneticiAsistan;

        public pnlYoneticiAsistanAnaMenu()
        {
            InitializeComponent();
        }

        //yüklendiğinde
        private void pnlYoneticiAsistanAnaMenu_Load(object sender, EventArgs e)
        {

        }

        //stok işlemleri
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pnlStokislem si = new pnlStokislem();
            si._pnlYoneticiAsistanAnaMenu = this;
            _frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Clear();
            _frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Add(si);
        }

        //arıza ürün
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pnlTeknikServisTakibi tst = new pnlTeknikServisTakibi();
            tst._pnlYoneticiAsistanAnaMenu = this;
            _frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Clear();
            _frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Add(tst);
        }

        //müşteri işlemleri
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            pnlMusteriIslemleri mi = new pnlMusteriIslemleri();
            mi._pnlYoneticiAsistanAnaMenu = this;
            _frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Clear();
            _frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Add(mi);
        }

        //satışlar
        private void btn_kargoIslem_Click(object sender, EventArgs e)
        {
            pnlSatislar s = new pnlSatislar();
            _frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Clear();
            s._pnlYoneticiAsistanAnaMenu = this;
            _frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Add(s);
        }
    }
}
