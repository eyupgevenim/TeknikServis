using System;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class pnlMusteriIslemleri : UserControl
    {
        public pnlYoneticiAnaMenu _pnlYoneticiAnaMenu;
        public pnlYoneticiAsistanAnaMenu _pnlYoneticiAsistanAnaMenu;
        public pnlSatisElemaniAnaMenu _pnlSatisElemaniAnaMenu;

        public pnlMusteriIslemleri()
        {
            InitializeComponent();
        }

        //yüklendiğinde
        private void pnlMusteriIslemleri_Load(object sender, EventArgs e)
        {
            pnlMusteriIslemTemp.Controls.Clear();
            pnlMusteriIslemTemp.Controls.Add(new pnlMusteriArama());
        }

        //müşteri ekle buttonu
        private void btn_Click(object sender, EventArgs e)
        {
            pnlMusteriIslemTemp.Controls.Clear();
            pnlMusteriIslemTemp.Controls.Add(new pnlMusteriekle());
        }

        //müşteri arama
        private void btn_musteriAra_Click(object sender, EventArgs e)
        {
            pnlMusteriIslemTemp.Controls.Clear();
            pnlMusteriIslemTemp.Controls.Add(new pnlMusteriArama());
        }

        //firma ekle buttonu
        private void btnFirmaekle_Click(object sender, EventArgs e)
        {
            pnlMusteriIslemTemp.Controls.Clear();
            pnlMusteriIslemTemp.Controls.Add(new pnlFirmaEkle());
        }

        //firma ara buttonu
        private void btnArama_Click(object sender, EventArgs e)
        {
            pnlMusteriIslemTemp.Controls.Clear();
            pnlMusteriIslemTemp.Controls.Add(new pnlFirmaListeleme());
        }

        //anasayfaya dönme buttonu
        private void btn_anaSayfayaGeriDon_Click(object sender, EventArgs e)
        {
            if (_pnlYoneticiAnaMenu != null)
            {
                _pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Clear();
                _pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Add(_pnlYoneticiAnaMenu);
            }
            else if (_pnlYoneticiAsistanAnaMenu != null)
            {
                _pnlYoneticiAsistanAnaMenu._frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Clear();
                _pnlYoneticiAsistanAnaMenu._frmYoneticiAsistan.pnlYoneticiAsistanTemp.Controls.Add(_pnlYoneticiAsistanAnaMenu);
            }
            else if (_pnlSatisElemaniAnaMenu != null)
            {
                _pnlSatisElemaniAnaMenu._frmSatisEleman.pnlSatisElemenTemp.Controls.Clear();
                _pnlSatisElemaniAnaMenu._frmSatisEleman.pnlSatisElemenTemp.Controls.Add(_pnlSatisElemaniAnaMenu);
            }

        }

    }
}
