using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
namespace TeknikServis
{
    public partial class pnlSiparisEkle2 : UserControl
    {
        public frmMusteriSec ms;
        public int musteri_;
        DataTable t;

        public pnlSiparisEkle2()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlSiparisEkle2_Load(object sender, EventArgs e)
        {
            t = new DataTable();
            t.Columns.Add("id", typeof(int));

            t.Columns.Add("katagori", typeof(string));
            t.Columns["katagori"].Caption = "KATAGORİ";
            t.Columns.Add("marka", typeof(string));
            t.Columns["marka"].Caption = "MARKA";
            t.Columns.Add("model", typeof(string));
            t.Columns["model"].Caption = "MODEL";
            t.Columns.Add("adet", typeof(int));
            t.Columns["adet"].Caption = "ÜRÜN ADETİ";
            t.Columns.Add("ucret", typeof(double));
            t.Columns["ucret"].Caption = "GELİŞ FİYATI";
            t.Columns.Add("toplam", typeof(double));
            t.Columns["toplam"].Caption = "TOPLAM FİYAT";
            t.Columns.Add("sil", typeof(Image));
            t.Columns["sil"].Caption = "SİLME";

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;
            gridView1.Columns["sil"].Visible = false;

            gridView1.Columns["toplam"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["toplam"].SummaryItem.DisplayFormat = "Toplam = {0}";
        }

        //... müşteri seç buttonu
        private void btnE_musteriSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ms = new frmMusteriSec();
            ms._e2 = this;
            ms.ShowDialog();
        }

    }
}
