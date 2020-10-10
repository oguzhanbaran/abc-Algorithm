using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _163311052_abc
{
    public partial class frmABC : Form
    {
        public frmABC()
        {
            InitializeComponent();
        }
        int cs;
        private void FrmABC_Load(object sender, EventArgs e)
        {

        }
        private void ListViewAtaGozcu()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Besin", 50);
            listView1.Columns.Add("X", 70);
            listView1.Columns.Add("Y", 70);
            listView1.Columns.Add("F(x)", 70);
            listView1.Columns.Add("Fitness", 70);
        }
        private void ListViewAta()
        {
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.Add("Besin", 50);
            listView.Columns.Add("X", 70);
            listView.Columns.Add("Y", 70);
            listView.Columns.Add("F(x)", 70);
            listView.Columns.Add("Fitness", 70);
        }
        private void BtnCalistir_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            listView1.Clear();
            listView.Clear();
            ListViewAtaGozcu();
            ListViewAta();
            cs = (int)numericCS.Value;
            ABC yeniKoloni = new ABC(cs);
            double[,] kaynakPozisyonları = yeniKoloni.kaynakPozisyonları;
            double[] fxDegerleri = yeniKoloni.fxDegerleri;
            double[] fitnessDegerleri = yeniKoloni.fitnessDegerleri;
            GozcuAri gozcuAriKoloni = new GozcuAri(cs, kaynakPozisyonları, yeniKoloni.uygunlukDegerleri);
            double [,] gKaynakPozisyonları = gozcuAriKoloni.gozcuKaynak;
            double[] gFxDegerleri = gozcuAriKoloni.fxDegerleri;
            double[] gFitnessDegerleri = gozcuAriKoloni.fitnessDegerleri;
            double maxFitGozcu = gFitnessDegerleri.Max();
            double maxFitIsci = fitnessDegerleri.Max();
            int maxFitKonum = 0;
            int maxFitKonumIsci = 0;
            for (int i = 0; i < gFitnessDegerleri.Length; i++)
            {
                if (gFitnessDegerleri[i]==maxFitGozcu)
                {
                    maxFitKonum = i;
                }
            }
            for (int i = 0; i < gFitnessDegerleri.Length; i++)
            {
                if (fitnessDegerleri[i] == maxFitIsci)
                {
                    maxFitKonumIsci = i;
                }
            }
            lblX.Text = gKaynakPozisyonları[maxFitKonum, 0].ToString();
            lblY.Text = gKaynakPozisyonları[maxFitKonum, 1].ToString();
            lblXIsci.Text = kaynakPozisyonları[maxFitKonumIsci, 0].ToString();
            lblYIsci.Text = kaynakPozisyonları[maxFitKonumIsci, 1].ToString();
            lblFit.Text = "En uygun değer:" + fitnessDegerleri.Max();
            lblGozcuFit.Text= "En uygun değer:" + gFitnessDegerleri.Max();
            for (int i = 0; i < fxDegerleri.Length; i++)
            {
                string[] row = new string[] { (i+1).ToString() ,kaynakPozisyonları[i,0].ToString(),
                    kaynakPozisyonları[i, 1].ToString(), fxDegerleri[i].ToString(),fitnessDegerleri[i].ToString()};
                var satir = new ListViewItem(row);
                listView.Items.Add(satir);
                
            }
            for (int i = 0; i < gFxDegerleri.Length; i++)
            {
                string[] row = new string[] { (i+1).ToString() ,gKaynakPozisyonları[i,0].ToString(),
                    gKaynakPozisyonları[i, 1].ToString(), gFxDegerleri[i].ToString(),gFitnessDegerleri[i].ToString()};
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
            }
            lblDegisimSayisi.Text =cs/2+" işçi arı için uygunluk değerlerinde yapılan toplam iyileştirme sayısı:"+ yeniKoloni.degisiklikSayisi.ToString();
            lblGozcuDegisim.Text= cs / 2 + " gözcü arı için uygunluk değerlerinde yapılan toplam iyileştirme sayısı:" + gozcuAriKoloni.degisiklikSayisi.ToString();
            listView1.Items[maxFitKonum].BackColor = Color.Yellow;
            listView1.Items[maxFitKonum].ForeColor = Color.Black;
            listView.Items[maxFitKonumIsci].BackColor = Color.Yellow;
            listView.Items[maxFitKonumIsci].ForeColor = Color.Black;
            chart1.Series.Add("Gözcü");
            chart1.Series["Gözcü"].Color = Color.Yellow;
            chart1.Series.Add("İşçi");
            chart1.Series["İşçi"].Color = Color.Black;
            for (int i = 0; i < cs/2; i++)
            {  
                chart1.Series["Gözcü"].Points.Add(gFitnessDegerleri[i]);
                chart1.Series["İşçi"].Points.Add(fitnessDegerleri[i]);
            }

        }
    }
}
