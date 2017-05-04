using System;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class pnlSekreter : UserControl
    {
        public frmSekreter _frmSekreter;
        public pnlYoneticiAsistanAnaMenu _pnlYoneticiAsistanAnaMenu;

        public pnlSekreter()
        {
            InitializeComponent();
        }

        private void pnlSekreter_Load(object sender, EventArgs e)
        {
            pnlSekreterTemp.Controls.Clear();
            pnlServistekiArizaliUrunler sa = new pnlServistekiArizaliUrunler();
            sa._s = this;
            pnlSekreterTemp.Controls.Add(sa);
        }

        //yeni kayıt
        private void btn_auKayit_Click(object sender, EventArgs e)
        {
            pnlSekreterTemp.Controls.Clear();
            pnlArizaKayit ak = new pnlArizaKayit();
            ak._s = this;
            pnlSekreterTemp.Controls.Add(ak);
        }
        

        //------------------
        //servistekiler
        private void btn_servistekiler_Click(object sender, EventArgs e)
        {
            pnlSekreterTemp.Controls.Clear();
            pnlServistekiArizaliUrunler sa = new pnlServistekiArizaliUrunler();
            sa._s = this;
            pnlSekreterTemp.Controls.Add(sa);
        }

        //eski kayıtlar
        private void btn_eskiKayitlar_Click(object sender, EventArgs e)
        {
            pnlSekreterTemp.Controls.Clear();
            pnlSekreterTemp.Controls.Add(new pnlServisEski());
        }
    }
}
