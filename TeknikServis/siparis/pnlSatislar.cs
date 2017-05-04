using System;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class pnlSatislar : UserControl
    {
        public pnlYoneticiAsistanAnaMenu _pnlYoneticiAsistanAnaMenu;

        public pnlSatislar()
        {
            InitializeComponent();
        }

        //yüklendiğinde
        private void pnlSatislar_Load(object sender, EventArgs e)
        {
            pnlSatisTemp.Controls.Clear();
            pnlSatisTemp.Controls.Add(new pnlTeslimEdilmemisSiparis());
        }

        //teslim edilmemiş siparişler
        private void btn_bekleyen_Click(object sender, EventArgs e)
        {
            pnlSatisTemp.Controls.Clear();
            pnlSatisTemp.Controls.Add(new pnlTeslimEdilmemisSiparis());
        }

        //eski siparişler
        private void btn_eski_Click(object sender, EventArgs e)
        {
            pnlSatisTemp.Controls.Clear();
            pnlSatisTemp.Controls.Add(new pnlEskiSiparis());
        }

        //anasayfaya geri dönüş buttonu
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _pnlYoneticiAsistanAnaMenu._frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Clear();
            _pnlYoneticiAsistanAnaMenu._frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Add(_pnlYoneticiAsistanAnaMenu);
        }
    }
}
