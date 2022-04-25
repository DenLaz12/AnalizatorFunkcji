using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Projekt3_Lazarenko51064
{
    public partial class AnalizatorFunkcji : Form
    {
        public AnalizatorFunkcji()
        {
            InitializeComponent();
        }
        bool PobranieDanychWejściowych(out float dlX, out float dlEps)
        {
            dlX = 0.0F;
            dlEps = 0.0F;
            if (!float.TryParse(txtX.Text, out dlX))
            {
                errorProvider1.SetError(txtX, "ERROR: w zapisie wartości zmiennej niezależnej X wystąpił niedozwolony znak");
                return false;
            }
            else if (string.IsNullOrEmpty(txtX.Text))
            {
                errorProvider1.SetError(txtX, "ERROR: musisz wpisać wartość X");
                btnObliczenieFx.Enabled = false;
                return false;
            }
            else errorProvider1.Dispose();

            if (!float.TryParse(txtEps.Text, out dlEps))
            {
                errorProvider1.SetError(txtEps, "ERROR: w zapisie wartości Eps wystąpił niedozwolony znak");
                btnObliczenieFx.Enabled = false;
                return false;
            }
            else if (string.IsNullOrEmpty(txtEps.Text))
            {
                errorProvider1.SetError(txtEps, "ERROR: musisz wpisać wartość Eps");
                btnObliczenieFx.Enabled = false;
                return false;
            }
            else if ((dlEps <= 0.0F) || (dlEps >= 1.0F))
            {
                errorProvider1.SetError(txtEps, "ERROR: dokładność obliczeń Eps musi spełniać warunek: 0.0 < Eps< 1.0");
                return false;
            }
            else
                errorProvider1.Dispose();

            return true;
        }
        
        bool PobranieDanychDlaTablicowania(out float dlXd, out float dlXg, out float dlh)
        {
            dlXd = 0.0f;
            dlXg = 0.0f;
            dlh = 0.0f;
            if (!float.TryParse(txtXg.Text, out dlXg))
            {
                errorProvider1.SetError(txtXg, "ERROR: wystąpił niedozwolony znak w zapisie dolnej granicy zmian X");
                return false;
            }
            else if (string.IsNullOrEmpty(txtXg.Text))
            {
                errorProvider1.SetError(txtXg, "ERROR: musisz wpisać wartość Xg");
                return false;
            }
            else
                errorProvider1.Dispose();

            if (!float.TryParse(txtXd.Text, out dlXd))
            {
                errorProvider1.SetError(txtXd, "ERROR:wystąpił niedozwolony znak w zapisie dolnej granicy Xd");
                return false;
            }
            else if (string.IsNullOrEmpty(txtXd.Text))
            {
                errorProvider1.SetError(txtXd, "ERROR: musisz wpisać wartość Xd");
                return false;
            }
            else
                errorProvider1.Dispose();

            if (!float.TryParse(txth.Text, out dlh))
            {
                errorProvider1.SetError(txth, "ERROR: wystąpił niedozwolony znak w zapisie kroku przyrostu h");
                return false;
            }
            else if (string.IsNullOrEmpty(txth.Text))
            {
                errorProvider1.SetError(txth, "ERROR: musisz wpisać wartość h");
                return false;
            }
            errorProvider1.Dispose();

            if ((dlXd >= dlXg))
            {
                errorProvider1.SetError(btnTabelarycznaWizualizacja, "ERROR:granica dolna musi spełniać warunek wejściowy  Xg > Xd");
                return false;

            }
            errorProvider1.Dispose();


            if ((dlh > 1) || (0 > dlh))
            {
                errorProvider1.SetError(txth, "ERROR: wartość przyrostu musi spełniać warunek wejściowy 0 < h < 1");
                return false;
            }
            errorProvider1.Dispose();

            return true;
        }

        private void btnTabelarycznaWizualizacja_Click(object sender, EventArgs e)
        {
            float dlX, dlXg, dlXd, dlEps, dlh;
            ushort dlLicznikSumowanychWyrazów;

            if (!PobranieDanychDlaTablicowania(out dlXd, out dlXg, out dlh))
            {
                return;
            }

            if (!PobranieDanychWejściowych(out dlX, out dlEps))
            {
                return;
            }
            dgvTablicaWartości.Rows.Clear();
            dlX = dlXd;
            for (int i = 0; dlX <= dlXg; i++, dlX = dlXd + i * dlh)
            {
                dgvTablicaWartości.Rows.Add();
                dgvTablicaWartości.Rows[i].Cells[0].Value = string.Format("{0:0.00}", dlX);
                dgvTablicaWartości.Rows[i].Cells[1].Value = string.Format("{0:0.00}", ObliczenieWartościSumySzeregu(dlX, dlEps, out dlLicznikSumowanychWyrazów));
                dgvTablicaWartości.Rows[i].Cells[2].Value = dlLicznikSumowanychWyrazów;
            }
            dgvTablicaWartości.Visible = true;
            chtGraficznaWizualizacja.Visible = false;


        }

        private void btnGraficznaWizualizacja_Click(object sender, EventArgs e)
        {
            chtGraficznaWizualizacja.Visible = true;
            dgvTablicaWartości.Visible = false;

            float dlX, dlXg, dlXd, dlEps, dlh;
            ushort dlLicznikSumowanychWyrazów;
            if (!PobranieDanychDlaTablicowania(out dlXd, out dlXg, out dlh))
            {
                return;
            }
            if (!PobranieDanychWejściowych(out dlX, out dlEps))
            {
                return;
            }

            dlX = dlXd;

            chtGraficznaWizualizacja.Series.Clear();

            chtGraficznaWizualizacja.Series.Add("Wartość funkcji F(X)");

            chtGraficznaWizualizacja.ChartAreas[0].AxisX.Title = "Wartość X";
            chtGraficznaWizualizacja.ChartAreas[0].AxisY.Title = "Wartości F(x)";

            chtGraficznaWizualizacja.ChartAreas[0].Name = "Wykres funkcji";

            chtGraficznaWizualizacja.Series[0].ChartType = SeriesChartType.Line;
            chtGraficznaWizualizacja.Series[0].Color = Color.Blue;
            chtGraficznaWizualizacja.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            chtGraficznaWizualizacja.Series[0].BorderWidth = 1;

            chtGraficznaWizualizacja.ChartAreas[0].AxisX.Minimum = dlXd;
            chtGraficznaWizualizacja.ChartAreas[0].AxisX.Maximum = dlXg;
            chtGraficznaWizualizacja.ChartAreas[0].AxisX.Interval = dlh;

            chtGraficznaWizualizacja.Series[0].IsVisibleInLegend = true;
            chtGraficznaWizualizacja.Legends.FindByName("Legend1").Docking = Docking.Bottom;

            for (int i = 0; dlX <= dlXg; i++, dlX = dlXd + i * dlh)
            {
                chtGraficznaWizualizacja.Series[0].Points.AddXY(i, ObliczenieWartościSumySzeregu(dlX, dlEps, out dlLicznikSumowanychWyrazów));

            }
        }
        bool PobranieDanychDlaCałkowania(out float dlEpsSzeregu, out float dlXdCałkowania, out float dlXgCałkowania, out float dlEpsCałkowania)
        {
            dlEpsSzeregu = dlXdCałkowania = dlXgCałkowania = dlEpsCałkowania = 0.0F;

            if (!float.TryParse(txtDolnaGranica.Text, out dlXdCałkowania))
            {
                errorProvider1.SetError(txtDolnaGranica, "ERROR: w zapisie wartości dolnej granicy całkowania wystąpił niedizwolony znak");
                return false;
            }
            else if (string.IsNullOrEmpty(txtDolnaGranica.Text))
            {
                errorProvider1.SetError(txtDolnaGranica, "ERROR: musisz wpisać wartość dolnej granicy całkowania");
                return false;
            }
            else
                errorProvider1.Dispose();


            if (!float.TryParse(txtGórnaGranica.Text, out dlXgCałkowania))
            {
                errorProvider1.SetError(txtGórnaGranica, "ERROR: w zapisie wartości górnej granicy całkowania wystąpił niedizwolony znak");
                return false;
            }
            else if (string.IsNullOrEmpty(txtGórnaGranica.Text))
            {
                errorProvider1.SetError(txtGórnaGranica, "ERROR: musisz wpisać wartość górnej granicy całkowania");
                return false;
            }
            else if (dlXgCałkowania <= dlXdCałkowania)
            {
                errorProvider1.SetError(txtGórnaGranica, "ERROR: górna granica całkowania musi być większa od dolnej granicy całkowania");
                return false;

            }
            else
                errorProvider1.Dispose();

            if (!float.TryParse(txtDokładnośćCałkowania.Text, out dlEpsCałkowania))
            {
                errorProvider1.SetError(txtDokładnośćCałkowania, "ERROR: w zapisie wartości dokładności całkowania wystápił niedozwolony znak");
                return false;
            }
            else if (string.IsNullOrEmpty(txtDokładnośćCałkowania.Text))
            {
                errorProvider1.SetError(txtDokładnośćCałkowania, "ERROR: musisz wpisać wartość dokładności obliczeń całkowania");
                return false;
            }
            else if ((dlEpsCałkowania <= 0.0F) || (dlEpsCałkowania >= 1.0F))
            {
                errorProvider1.SetError(txtDokładnośćCałkowania, "ERROR: dokładność obliczeń Eps musi spełniać warunek: 0.0 < Eps < 1.0");
                return false;
            }
            else
                errorProvider1.Dispose();

            if ((dlEpsCałkowania <= 0.0F) || (dlEpsSzeregu > 0.05F))
            {
                errorProvider1.SetError(txtDokładnośćCałkowania, "ERROR: dokładność obliczeń całkowania musi spełniać warunek: 0.0 < EpsCałkowania <= 0.05");
                return false;
            }
            else
                errorProvider1.Dispose();
            return true;

        }
        float ObliczenieWartościSumySzeregu(float dlX, float dlEps, out ushort dln)
        {
            float dlW, dlS;
            dln = 1;
            dlS = 0.0F;
            dlW = (float)((Math.Pow(3, dln + 1) / (Math.Pow(4, dln) * dln)) * Math.Pow(dlX, 2*(dln)));
            do
            {
                dln++;
                dlS = dlS + dlW;
                dlW = (float)((Math.Pow(3, dln + 1) / (Math.Pow(4, dln) * dln)) * Math.Pow(dlX, 2*(dln)));
            } while (Math.Abs(dlW) > dlEps);

            return dlS;
        }

        private void btnObliczenieFx_Click(object sender, EventArgs e)
        {
            float dlX;
            float dlEps;
            ushort dlIlośćZsumuwanychWyrażeń;
            if (!PobranieDanychWejściowych(out dlX, out dlEps))
                return;
            txtWartośćFunkcji.Text = string.Format("{0:0.00}", ObliczenieWartościSumySzeregu(dlX, dlEps, out dlIlośćZsumuwanychWyrażeń));
            txtIlośćWyrażeń.Text = dlIlośćZsumuwanychWyrażeń.ToString();
        }
        float ObliczanieCałkiMetodąProstokątów(float dlEpsSzeregu, float dla, float dlb, float dlEpsCałkowania, out ushort dlLicznikPrzedziałow, out float dlSzerokośćPrszedziału)
        {
            float dlh, dlCi, dlCi_1, dlSumaFx;
            ushort dlLicznikWyrazówSzeregu;
            dlLicznikPrzedziałow = 1;
            dlCi = (dlb - dla) * ObliczenieWartościSumySzeregu((dla + dlb) / 2.0F, dlEpsSzeregu, out dlLicznikWyrazówSzeregu);
            float dlX;
            do
            {
                dlCi_1 = dlCi;
                dlLicznikPrzedziałow++;
                dlh = (dlb - dla) / dlLicznikPrzedziałow;
                dlX = dla + dlh / 2.0F;
                dlSumaFx = 0.0F;
                for (ushort i = 0; i < dlLicznikPrzedziałow; i++)
                    dlSumaFx += ObliczenieWartościSumySzeregu(dlX + i * dlh, dlEpsSzeregu, out dlLicznikWyrazówSzeregu);
                dlCi = dlh * dlSumaFx;

            } while (Math.Abs(dlCi - dlCi_1) > dlEpsCałkowania);
            dlSzerokośćPrszedziału = dlh;
            return dlCi;
        }
        float ObliczenieCałkiMetodąTrapezów(float dla, float dlb, float dlEpsCałkowania, float dlEpsSzeregu)
        {

            float dlCi, dlCi_1, dlSumaFx;
            ushort dlLicznikWyrazówSzeregu;
            ushort dlLicznikPrzedziałów = 1;
            float dlSzerokośćPrzedziału = dlb - dla;
            float dlSumaFaFb = ObliczenieWartościSumySzeregu(dla, dlEpsSzeregu, out dlLicznikWyrazówSzeregu) + ObliczenieWartościSumySzeregu(dlb, dlEpsSzeregu, out dlLicznikWyrazówSzeregu);
            dlCi = dlSzerokośćPrzedziału * dlSumaFaFb / 2.0F;
            do
            {
                dlCi_1 = dlCi;
                dlLicznikPrzedziałów++;
                dlSzerokośćPrzedziału = (dlb - dla) / dlLicznikPrzedziałów;
                dlSumaFx = 0.0F;
                for (int i = 1; i < dlLicznikPrzedziałów; i++)
                    dlSumaFx += ObliczenieWartościSumySzeregu(dla + i * dlSzerokośćPrzedziału, dlEpsSzeregu, out dlLicznikWyrazówSzeregu);
                dlCi = dlSzerokośćPrzedziału * (dlSumaFaFb / 2.0F + dlSumaFx);

            } while (Math.Abs(dlCi - dlCi_1) > dlEpsCałkowania);

            return dlCi;

        }

        private void btnObliczenieCałki_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMetodaCałkowania.Text))
            {

            }
            else if (cmbMetodaCałkowania.SelectedIndex == 0)
            {
                float dlEpsSzeregu, dlXdCałkowania, dlXgCałkowania, dlEpsCałkowania;
                if (!PobranieDanychDlaCałkowania(out dlEpsSzeregu, out dlXdCałkowania, out dlXgCałkowania, out dlEpsCałkowania))
                    return;

                float dlWartośCałki, dlSzerokoścOstatniegoPodziału;

                ushort dlLicznikPodprzedziałów;

                dlWartośCałki = ObliczanieCałkiMetodąProstokątów(dlEpsSzeregu, dlXdCałkowania, dlXgCałkowania, dlEpsCałkowania, out dlLicznikPodprzedziałów, out dlSzerokoścOstatniegoPodziału);

                txtWynikObliczaniaCałki.Text = string.Format("{0:0.000}", dlWartośCałki);
                txtSzerokośćPodprzedziałów.Text = string.Format("{0:0.000000}", dlSzerokoścOstatniegoPodziału);
                txtLiczbaPodprzedziałów.Text = dlLicznikPodprzedziałów.ToString();
            }
            else if (cmbMetodaCałkowania.SelectedIndex == 1)
            {
                float dlEpsSzeregu, dlXdCałkowania, dlXgCałkowania, dlEpsCałkowania;
                if (!PobranieDanychDlaCałkowania(out dlEpsSzeregu, out dlXdCałkowania, out dlXgCałkowania, out dlEpsCałkowania))
                    return;

                float dlWartośCałki, dlSzerokoścOstatniegoPodziału;

                ushort dlLicznikPodprzedziałów;

                dlWartośCałki = ObliczenieCałkiMetodąTrapezów(dlXdCałkowania, dlXgCałkowania, dlEpsCałkowania, dlEpsSzeregu);

                txtWynikObliczaniaCałki.Text = string.Format("{0:0.000}", dlWartośCałki);
                txtSzerokośćPodprzedziałów.Text = "-";
                txtLiczbaPodprzedziałów.Text = "-";
            }
        }

        private void zapiszTabliceWPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float dlX, dlEps, dlXd, dlXg, dlh;
            ushort dlLicznikSumowanychWyrazów;
            if (!PobranieDanychDlaTablicowania(out dlXd, out dlXg, out dlh))
                return;
            if (!PobranieDanychWejściowych(out dlX, out dlEps))
                return;


            SaveFileDialog OknoZapisuPliku = new SaveFileDialog();
            OknoZapisuPliku.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            OknoZapisuPliku.FilterIndex = 1;
            OknoZapisuPliku.RestoreDirectory = true;
            OknoZapisuPliku.InitialDirectory = "D:\\";
            OknoZapisuPliku.Title = "Zapisanie wyników obliczeń(wierszy danych tabeli )";
            if (OknoZapisuPliku.ShowDialog() == DialogResult.OK)
            {
                StreamWriter PlikZnakowy = new StreamWriter(OknoZapisuPliku.OpenFile());
                for (int i = 0; dlX <= dlXg; i++, dlX = dlXd + i * dlh)
                {
                    PlikZnakowy.Write(string.Format("{0,8:0.00} \t", dlX));
                    PlikZnakowy.Write(string.Format("{0,8:0.00} \t", ObliczenieWartościSumySzeregu(dlX, dlEps, out dlLicznikSumowanychWyrazów)));
                    PlikZnakowy.Write(string.Format("{0,4} \t", dlLicznikSumowanychWyrazów));

                    PlikZnakowy.WriteLine("\t");
                }
                PlikZnakowy.Dispose();
                PlikZnakowy.Close();
            }
        }

        private void odczytajTablicęZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvTablicaWartości.Rows.Clear();
            OpenFileDialog OknoOdczytuPliku = new OpenFileDialog();
            OknoOdczytuPliku.Title = "Otrwarcie pliku z tablicowania wartości funkcji";
            if (OknoOdczytuPliku.ShowDialog() == DialogResult.OK)
            {
                string NazwaPliku = OknoOdczytuPliku.FileName;
                string[] ZawartośćPliku = File.ReadAllLines(NazwaPliku);
                dgvTablicaWartości.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                foreach (string WierszDanych in ZawartośćPliku)
                    dgvTablicaWartości.Rows.Add(WierszDanych.Split('\t'));
                dgvTablicaWartości.Visible = true;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            txtWartośćFunkcji.Clear();
            txtIlośćWyrażeń.Clear();
            txtX.Text = "";
            txtXd.Text = "";
            txtXg.Text = "";
            txtEps.Text = "";
            txth.Text = "";
            chtGraficznaWizualizacja.Visible = false;
            dgvTablicaWartości.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDolnaGranica.Text = "";
            txtGórnaGranica.Text = "";
            txtDokładnośćCałkowania.Text = "";
            txtWynikObliczaniaCałki.Clear();
            txtLiczbaPodprzedziałów.Clear();
            txtSzerokośćPodprzedziałów.Clear();
            cmbMetodaCałkowania.SelectedItem = null;
        }

        private void kolorTlaWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog OknoKolorów = new ColorDialog();

            OknoKolorów.Color = chtGraficznaWizualizacja.Series[0].Color;

            if (OknoKolorów.ShowDialog() == DialogResult.OK)
            {
                chtGraficznaWizualizacja.BackColor = OknoKolorów.Color;
                txtWziernikKoloruTłaDlaObszaruWykresu.BackColor = OknoKolorów.Color;
            }
        }

        private void kolorLiniiWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog OknoKolorów = new ColorDialog();

            OknoKolorów.Color = chtGraficznaWizualizacja.Series[0].Color;

            if (OknoKolorów.ShowDialog() == DialogResult.OK)
            {
                chtGraficznaWizualizacja.Series[0].Color = OknoKolorów.Color;
                txtWziernikKoloruLinii.BackColor = OknoKolorów.Color;
            }
        }

        private void kropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtGraficznaWizualizacja.Series[0].BorderDashStyle = ChartDashStyle.Dot;
        }

        private void kreskowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtGraficznaWizualizacja.Series[0].BorderDashStyle = ChartDashStyle.Dash;
        }

        private void kreskowokropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtGraficznaWizualizacja.Series[0].BorderDashStyle = ChartDashStyle.DashDot;
        }

        private void ciągłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chtGraficznaWizualizacja.Series[0].BorderDashStyle = ChartDashStyle.Solid;
        }

        private void cmbStylLiniiWykresu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbStylLiniiWykresu.SelectedIndex)
            {
                case 0:
                    chtGraficznaWizualizacja.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
                case 1:
                    chtGraficznaWizualizacja.Series[0].BorderDashStyle = ChartDashStyle.Dash;
                    break;
                case 2:
                    chtGraficznaWizualizacja.Series[0].BorderDashStyle = ChartDashStyle.Dot;
                    break;
                case 3:
                    chtGraficznaWizualizacja.Series[0].BorderDashStyle = ChartDashStyle.DashDot;

                    break;
                default:
                    chtGraficznaWizualizacja.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
            }
        }
    }
    
}
