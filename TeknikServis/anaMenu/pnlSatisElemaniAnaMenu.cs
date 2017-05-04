using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class pnlSatisElemaniAnaMenu : UserControl
    {
        public frmSatisEleman _frmSatisEleman;

        public pnlSatisElemaniAnaMenu()
        {
            InitializeComponent();
        }

        private void pnlSatisElemaniAnaMenu_Load(object sender, EventArgs e)
        {

        }

        //stok işlemleri
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pnlStokislem si = new pnlStokislem();
            si._pnlSatisElemaniAnaMenu = this;
            _frmSatisEleman.pnlSatisElemenTemp.Controls.Clear();
            _frmSatisEleman.pnlSatisElemenTemp.Controls.Add(si);
        }

        //satış işlemleri
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pnlSiparisIslem s = new pnlSiparisIslem();
            s._pnlSatisElemaniAnaMenu = this;
            _frmSatisEleman.pnlSatisElemenTemp.Controls.Clear();
            _frmSatisEleman.pnlSatisElemenTemp.Controls.Add(s);
        }

        //Müşteri işlemleri
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            pnlMusteriIslemleri mi = new pnlMusteriIslemleri();
            mi._pnlSatisElemaniAnaMenu = this;
            _frmSatisEleman.pnlSatisElemenTemp.Controls.Clear();
            _frmSatisEleman.pnlSatisElemenTemp.Controls.Add(mi);
        }
    }
}
