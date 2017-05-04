using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using BL;
using OBJ;


namespace TeknikServis
{
    public partial class pnlSiparisEkle1 : UserControl
    {
        DataTable t;
        //Image sil=Image.FromFile("..\\..\\img\\sil24x24.png");

        public pnlSiparisEkle1()
        {
            InitializeComponent();
        }

        private void pnlSiparisEkle1_Load(object sender, EventArgs e)
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
            //t.Columns.Add("sil", typeof(Image));
            //t.Columns["sil"].Caption = "SİLME";
            
            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;

            gridView1.Columns["toplam"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["toplam"].SummaryItem.DisplayFormat = "Toplam = {0}";

            var katagori = new BUrun().katagoriListele();
            var marka = new BUrun().markaListele();
            if (katagori.basarliMi && marka.basarliMi)
            {

                cBox_katagori.DataSource = katagori.veri;
                cBox_katagori.ValueMember = "katagori_";
                cBox_katagori.DisplayMember = "katagoriadi";
                cBox_katagori.SelectedIndex = 0;

                cBox_marka.DataSource = marka.veri;
                cBox_marka.ValueMember = "marka_";
                cBox_marka.DisplayMember = "markaadi";
                cBox_marka.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show(katagori.hataBilgisi.hataMesaj + "\n" + marka.hataBilgisi.hataMesaj);
            }

            this.cBox_katagori.SelectedIndexChanged +=
                new EventHandler(cBox_katagori_SelectedIndexChanged);
            this.cBox_marka.SelectedIndexChanged +=
                new EventHandler(cBox_marka_SelectedIndexChanged);

            var urunSonuc = new BUrun().urunAra("", (int)cBox_marka.SelectedValue, (int)cBox_katagori.SelectedValue);
            if (urunSonuc.basarliMi)
            {
                cBox_model.DataSource = urunSonuc.veri;
                cBox_model.ValueMember = "urunmodel_";
                cBox_model.DisplayMember = "modeladi";
            }
            else
            {
                MessageBox.Show(urunSonuc.mesaj);
            }

        }

        //katagori  comboboxı değiştiğinde
        private void cBox_katagori_SelectedIndexChanged(object sender, EventArgs e)
        {
            var urunSonuc = new BUrun().urunAra("", (int)cBox_marka.SelectedValue, (int)cBox_katagori.SelectedValue);
            if (urunSonuc.basarliMi)
            {
                cBox_model.DataSource = urunSonuc.veri;
                cBox_model.ValueMember = "urunmodel_";
                cBox_model.DisplayMember = "modeladi";
            }
            else
            {
                MessageBox.Show(urunSonuc.mesaj);
            }
        }

        //marka comboboxı değiştiğinde
        private void cBox_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            var urunSonuc = new BUrun().urunAra("", (int)cBox_marka.SelectedValue, (int)cBox_katagori.SelectedValue);
            if (urunSonuc.basarliMi)
            {
                cBox_model.DataSource = urunSonuc.veri;
                cBox_model.ValueMember = "urunmodel_";
                cBox_model.DisplayMember = "modeladi";
            }
            else
            {
                MessageBox.Show(urunSonuc.mesaj);
            }
        }

        // sepette ekele
        private void btn_sepeteEkle_Click(object sender, EventArgs e)
        {
            OUrun u = (OUrun)cBox_model.SelectedItem;
            DataRow[] row = t.Select("id=" + u.urunmodel_);

            if(row.Length > 0)
            {
                MessageBox.Show("Sepette aynı üründen var !","Uyarı !!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                double satirToplam = (double)(nUd_adet.Value) * (double)(u.ucret);
                t.Rows.Add(u.urunmodel_, u._katagori.katagoriadi, u._marka.markaadi, u.modeladi, nUd_adet.Value, u.ucret, satirToplam);//, sil);
            }
            

        }

        //gridviwe tıklama
        //hücreye tıklama olayı yapılmıi ve sil hücresine basıldığında siler
        private void gridView1_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(MousePosition);

            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                
                string colName= info.Column == null ? "N/A" : info.Column.FieldName;
                int index = info.RowHandle;

                //info.Column.FieldName ==> içinde column ismi var
                //info.Column.Name ==> içinde col+column ismi var(colsil gibi)
                //info.RowHandle ==> içinde satır indexi var

                if (colName == "sil")
                {
                    DataRow row = gridView1.GetDataRow(index);
                    row.Delete();
                }

                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                
            }
        }//gridView1_Click()
    }
}
