using System;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class pnlStokislem : UserControl
    {
        public pnlYoneticiAnaMenu _pnlYoneticiAnaMenu;
        public pnlYoneticiAsistanAnaMenu _pnlYoneticiAsistanAnaMenu;
        public pnlSatisElemaniAnaMenu _pnlSatisElemaniAnaMenu;

        public pnlStokislem()
        {
            InitializeComponent();
        }


        //panel yüklendiğinde
        private void pnlStokislem_Load(object sender, EventArgs e)
        {
            pnlStokİslemTemp.Controls.Clear();
            pnlStokİslemTemp.Controls.Add(new pnlStokArama());
        }

        //ürün ekle buttonu
        private void btnUrunlEkle_Click(object sender, EventArgs e)
        {
            pnlStokİslemTemp.Controls.Clear();
            pnlStokİslemTemp.Controls.Add(new pnlStokUrunEkle());
        }

        //ürün ara buttonu
        private void btnUrunArama_Click(object sender, EventArgs e)
        {
            pnlStokİslemTemp.Controls.Clear();
            pnlStokİslemTemp.Controls.Add(new pnlStokArama());

        }

        //Tüm ürün listesi buttonu
        private void btn_tumUrunListe_Click(object sender, EventArgs e)
        {
            pnlStokİslemTemp.Controls.Clear();
            pnlStokİslemTemp.Controls.Add(new pnlTumUrunListesi());
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
            }else if(_pnlSatisElemaniAnaMenu != null)
            {
                _pnlSatisElemaniAnaMenu._frmSatisEleman.pnlSatisElemenTemp.Controls.Clear();
                _pnlSatisElemaniAnaMenu._frmSatisEleman.pnlSatisElemenTemp.Controls.Add(_pnlSatisElemaniAnaMenu);
            }
            
        }

    }
}
