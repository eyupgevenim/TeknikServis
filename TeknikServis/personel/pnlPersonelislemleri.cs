using System;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class pnlPersonelislemleri : UserControl
    {
        public pnlYoneticiAnaMenu _pnlYoneticiAnaMenu;

        public pnlPersonelislemleri()
        {
            InitializeComponent();
        }

        private void pnlPersonelislemleri_Load(object sender, EventArgs e)
        {
            pnlPersonelIslemTemp.Controls.Clear();
            pnlPersonelIslemTemp.Controls.Add(new pnlPersonellistele());
        }

        //personel ekleme button click
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            pnlPersonelIslemTemp.Controls.Clear();
            pnlPersonelIslemTemp.Controls.Add(new pnlPersonelekle());
        }

        //ana sayfya geri dön button click
        private void btn_anaSayfayaGeriDon_Click(object sender, EventArgs e)
        {
            _pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Clear();
            _pnlYoneticiAnaMenu._frmYonetici.pnlYoneticiTemp.Controls.Add(_pnlYoneticiAnaMenu);
        }

        //personel listesi
        private void btnPersonelGoruntule_Click(object sender, EventArgs e)
        {
            pnlPersonelIslemTemp.Controls.Clear();
            pnlPersonelIslemTemp.Controls.Add(new pnlPersonellistele());
        }

        
    }
}
