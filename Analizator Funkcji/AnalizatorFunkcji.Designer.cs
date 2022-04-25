namespace Projekt3_Lazarenko51064
{
    partial class AnalizatorFunkcji
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalizatorFunkcji));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.btnObliczenieCałki = new System.Windows.Forms.Button();
            this.btnGraficznaWizualizacja = new System.Windows.Forms.Button();
            this.btnTabelarycznaWizualizacja = new System.Windows.Forms.Button();
            this.btnObliczenieFx = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtGórnaGranica = new System.Windows.Forms.TextBox();
            this.txtDokładnośćCałkowania = new System.Windows.Forms.TextBox();
            this.cmbMetodaCałkowania = new System.Windows.Forms.ComboBox();
            this.txtDolnaGranica = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.txth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIlośćWyrażeń = new System.Windows.Forms.TextBox();
            this.txtWartośćFunkcji = new System.Windows.Forms.TextBox();
            this.txtLiczbaPodprzedziałów = new System.Windows.Forms.TextBox();
            this.txtWynikObliczaniaCałki = new System.Windows.Forms.TextBox();
            this.txtSzerokośćPodprzedziałów = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszTabliceWPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytajTablicęZPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorTlaWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorLiniiWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciągłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowokropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTablicaWartości = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chtGraficznaWizualizacja = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtWziernikKoloruLinii = new System.Windows.Forms.TextBox();
            this.txtWziernikKoloruTłaDlaObszaruWykresu = new System.Windows.Forms.TextBox();
            this.cmbStylLiniiWykresu = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablicaWartości)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficznaWizualizacja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.cmbStylLiniiWykresu);
            this.panel1.Controls.Add(this.txtWziernikKoloruTłaDlaObszaruWykresu);
            this.panel1.Controls.Add(this.txtWziernikKoloruLinii);
            this.panel1.Controls.Add(this.btnResetuj);
            this.panel1.Controls.Add(this.btnObliczenieCałki);
            this.panel1.Controls.Add(this.btnGraficznaWizualizacja);
            this.panel1.Controls.Add(this.btnTabelarycznaWizualizacja);
            this.panel1.Controls.Add(this.btnObliczenieFx);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 652);
            this.panel1.TabIndex = 0;
            // 
            // btnResetuj
            // 
            this.btnResetuj.FlatAppearance.BorderSize = 0;
            this.btnResetuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetuj.Location = new System.Drawing.Point(0, 453);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(208, 51);
            this.btnResetuj.TabIndex = 7;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // btnObliczenieCałki
            // 
            this.btnObliczenieCałki.FlatAppearance.BorderSize = 0;
            this.btnObliczenieCałki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObliczenieCałki.Location = new System.Drawing.Point(3, 337);
            this.btnObliczenieCałki.Name = "btnObliczenieCałki";
            this.btnObliczenieCałki.Size = new System.Drawing.Size(208, 51);
            this.btnObliczenieCałki.TabIndex = 6;
            this.btnObliczenieCałki.Text = "Oblicz całkę";
            this.btnObliczenieCałki.UseVisualStyleBackColor = true;
            this.btnObliczenieCałki.Click += new System.EventHandler(this.btnObliczenieCałki_Click);
            // 
            // btnGraficznaWizualizacja
            // 
            this.btnGraficznaWizualizacja.FlatAppearance.BorderSize = 0;
            this.btnGraficznaWizualizacja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficznaWizualizacja.Location = new System.Drawing.Point(3, 266);
            this.btnGraficznaWizualizacja.Name = "btnGraficznaWizualizacja";
            this.btnGraficznaWizualizacja.Size = new System.Drawing.Size(208, 51);
            this.btnGraficznaWizualizacja.TabIndex = 5;
            this.btnGraficznaWizualizacja.Text = "Graficzna wizualizacja \r\nwartości funkcji F(x)";
            this.btnGraficznaWizualizacja.UseVisualStyleBackColor = true;
            this.btnGraficznaWizualizacja.Click += new System.EventHandler(this.btnGraficznaWizualizacja_Click);
            // 
            // btnTabelarycznaWizualizacja
            // 
            this.btnTabelarycznaWizualizacja.FlatAppearance.BorderSize = 0;
            this.btnTabelarycznaWizualizacja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelarycznaWizualizacja.Location = new System.Drawing.Point(3, 196);
            this.btnTabelarycznaWizualizacja.Name = "btnTabelarycznaWizualizacja";
            this.btnTabelarycznaWizualizacja.Size = new System.Drawing.Size(208, 51);
            this.btnTabelarycznaWizualizacja.TabIndex = 4;
            this.btnTabelarycznaWizualizacja.Text = "Tabelaryczna wizualizacja wartości funkcji F(x)";
            this.btnTabelarycznaWizualizacja.UseVisualStyleBackColor = true;
            this.btnTabelarycznaWizualizacja.Click += new System.EventHandler(this.btnTabelarycznaWizualizacja_Click);
            // 
            // btnObliczenieFx
            // 
            this.btnObliczenieFx.FlatAppearance.BorderSize = 0;
            this.btnObliczenieFx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObliczenieFx.Location = new System.Drawing.Point(3, 126);
            this.btnObliczenieFx.Name = "btnObliczenieFx";
            this.btnObliczenieFx.Size = new System.Drawing.Size(208, 51);
            this.btnObliczenieFx.TabIndex = 3;
            this.btnObliczenieFx.Text = "Obliczenie wartości \r\nfunkcji F(x)";
            this.btnObliczenieFx.UseVisualStyleBackColor = true;
            this.btnObliczenieFx.Click += new System.EventHandler(this.btnObliczenieFx_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 74);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.txtGórnaGranica);
            this.panel2.Controls.Add(this.txtDokładnośćCałkowania);
            this.panel2.Controls.Add(this.cmbMetodaCałkowania);
            this.panel2.Controls.Add(this.txtDolnaGranica);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(214, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 131);
            this.panel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Górna granica całkowania";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Dokładność całkowania";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dolna granica całkowania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Całkowanie";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(591, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 33);
            this.button6.TabIndex = 8;
            this.button6.Text = "Resetuj";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtGórnaGranica
            // 
            this.txtGórnaGranica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.txtGórnaGranica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGórnaGranica.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGórnaGranica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtGórnaGranica.Location = new System.Drawing.Point(200, 77);
            this.txtGórnaGranica.Multiline = true;
            this.txtGórnaGranica.Name = "txtGórnaGranica";
            this.txtGórnaGranica.Size = new System.Drawing.Size(169, 24);
            this.txtGórnaGranica.TabIndex = 5;
            this.txtGórnaGranica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDokładnośćCałkowania
            // 
            this.txtDokładnośćCałkowania.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.txtDokładnośćCałkowania.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDokładnośćCałkowania.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDokładnośćCałkowania.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtDokładnośćCałkowania.Location = new System.Drawing.Point(392, 77);
            this.txtDokładnośćCałkowania.Multiline = true;
            this.txtDokładnośćCałkowania.Name = "txtDokładnośćCałkowania";
            this.txtDokładnośćCałkowania.Size = new System.Drawing.Size(169, 24);
            this.txtDokładnośćCałkowania.TabIndex = 4;
            this.txtDokładnośćCałkowania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbMetodaCałkowania
            // 
            this.cmbMetodaCałkowania.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.cmbMetodaCałkowania.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMetodaCałkowania.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMetodaCałkowania.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.cmbMetodaCałkowania.FormattingEnabled = true;
            this.cmbMetodaCałkowania.Items.AddRange(new object[] {
            "Metoda Prostokątów",
            "Metoda Trapezów"});
            this.cmbMetodaCałkowania.Location = new System.Drawing.Point(591, 24);
            this.cmbMetodaCałkowania.Name = "cmbMetodaCałkowania";
            this.cmbMetodaCałkowania.Size = new System.Drawing.Size(194, 27);
            this.cmbMetodaCałkowania.TabIndex = 3;
            this.cmbMetodaCałkowania.Text = "Wybierz metodę całkowania";
            // 
            // txtDolnaGranica
            // 
            this.txtDolnaGranica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.txtDolnaGranica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDolnaGranica.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDolnaGranica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtDolnaGranica.Location = new System.Drawing.Point(6, 77);
            this.txtDolnaGranica.Multiline = true;
            this.txtDolnaGranica.Name = "txtDolnaGranica";
            this.txtDolnaGranica.Size = new System.Drawing.Size(169, 24);
            this.txtDolnaGranica.TabIndex = 0;
            this.txtDolnaGranica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX
            // 
            this.txtX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtX.Location = new System.Drawing.Point(220, 480);
            this.txtX.Multiline = true;
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(142, 24);
            this.txtX.TabIndex = 2;
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtXg
            // 
            this.txtXg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtXg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtXg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtXg.Location = new System.Drawing.Point(697, 480);
            this.txtXg.Multiline = true;
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(142, 24);
            this.txtXg.TabIndex = 3;
            this.txtXg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtXd
            // 
            this.txtXd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtXd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtXd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtXd.Location = new System.Drawing.Point(536, 480);
            this.txtXd.Multiline = true;
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(142, 24);
            this.txtXd.TabIndex = 4;
            this.txtXd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEps
            // 
            this.txtEps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtEps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEps.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtEps.Location = new System.Drawing.Point(378, 480);
            this.txtEps.Multiline = true;
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(142, 24);
            this.txtEps.TabIndex = 5;
            this.txtEps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txth
            // 
            this.txth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txth.Location = new System.Drawing.Point(857, 480);
            this.txth.Multiline = true;
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(142, 24);
            this.txth.TabIndex = 6;
            this.txth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 76);
            this.label2.TabIndex = 7;
            this.label2.Text = "   Wartość zmiennej\r\n        niezależnej \r\n X > (-infinity;+infinity)\r\n          " +
    "     (X)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(374, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 57);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wprowadż wartość Eps\r\n       0 < Eps < 1.0\r\n             (Eps)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(532, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 76);
            this.label4.TabIndex = 9;
            this.label4.Text = "W predziale zbieżności \r\nszeregu, spełniającego \r\n  warunek : Xd <= Xg\r\n         " +
    "      (Xd)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(693, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 76);
            this.label5.TabIndex = 10;
            this.label5.Text = "W predziale zbieżności \r\nszeregu, spełniającego \r\n  warunek : Xd <= Xg\r\n         " +
    "      (Xg)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(850, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 76);
            this.label6.TabIndex = 11;
            this.label6.Text = "Przyrost zmian wartości \r\n zmiennej niezależnej X\r\n         0.0 < h < 1.0\r\n      " +
    "           (h)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(865, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Wyniki";
            // 
            // txtIlośćWyrażeń
            // 
            this.txtIlośćWyrażeń.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtIlośćWyrażeń.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIlośćWyrażeń.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIlośćWyrażeń.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtIlośćWyrażeń.Location = new System.Drawing.Point(818, 196);
            this.txtIlośćWyrażeń.Multiline = true;
            this.txtIlośćWyrażeń.Name = "txtIlośćWyrażeń";
            this.txtIlośćWyrażeń.Size = new System.Drawing.Size(181, 24);
            this.txtIlośćWyrażeń.TabIndex = 13;
            this.txtIlośćWyrażeń.Text = "Ilość zsumuwanych wyrażeń";
            this.txtIlośćWyrażeń.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWartośćFunkcji
            // 
            this.txtWartośćFunkcji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtWartośćFunkcji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWartośćFunkcji.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWartośćFunkcji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtWartośćFunkcji.Location = new System.Drawing.Point(818, 153);
            this.txtWartośćFunkcji.Multiline = true;
            this.txtWartośćFunkcji.Name = "txtWartośćFunkcji";
            this.txtWartośćFunkcji.Size = new System.Drawing.Size(181, 24);
            this.txtWartośćFunkcji.TabIndex = 14;
            this.txtWartośćFunkcji.Text = "Wartość funkcji F(x)";
            this.txtWartośćFunkcji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLiczbaPodprzedziałów
            // 
            this.txtLiczbaPodprzedziałów.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtLiczbaPodprzedziałów.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLiczbaPodprzedziałów.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLiczbaPodprzedziałów.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtLiczbaPodprzedziałów.Location = new System.Drawing.Point(818, 293);
            this.txtLiczbaPodprzedziałów.Multiline = true;
            this.txtLiczbaPodprzedziałów.Name = "txtLiczbaPodprzedziałów";
            this.txtLiczbaPodprzedziałów.Size = new System.Drawing.Size(181, 24);
            this.txtLiczbaPodprzedziałów.TabIndex = 15;
            this.txtLiczbaPodprzedziałów.Text = "Liczba podpredziałów";
            this.txtLiczbaPodprzedziałów.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWynikObliczaniaCałki
            // 
            this.txtWynikObliczaniaCałki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtWynikObliczaniaCałki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWynikObliczaniaCałki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWynikObliczaniaCałki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtWynikObliczaniaCałki.Location = new System.Drawing.Point(818, 250);
            this.txtWynikObliczaniaCałki.Multiline = true;
            this.txtWynikObliczaniaCałki.Name = "txtWynikObliczaniaCałki";
            this.txtWynikObliczaniaCałki.Size = new System.Drawing.Size(181, 24);
            this.txtWynikObliczaniaCałki.TabIndex = 16;
            this.txtWynikObliczaniaCałki.Text = "Wynik obliczania całki";
            this.txtWynikObliczaniaCałki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSzerokośćPodprzedziałów
            // 
            this.txtSzerokośćPodprzedziałów.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtSzerokośćPodprzedziałów.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSzerokośćPodprzedziałów.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSzerokośćPodprzedziałów.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtSzerokośćPodprzedziałów.Location = new System.Drawing.Point(818, 337);
            this.txtSzerokośćPodprzedziałów.Multiline = true;
            this.txtSzerokośćPodprzedziałów.Name = "txtSzerokośćPodprzedziałów";
            this.txtSzerokośćPodprzedziałów.Size = new System.Drawing.Size(181, 24);
            this.txtSzerokośćPodprzedziałów.TabIndex = 17;
            this.txtSzerokośćPodprzedziałów.Text = "Szerokość podprzedziału";
            this.txtSzerokośćPodprzedziałów.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaWykresuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(214, 49);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszTabliceWPlikuToolStripMenuItem,
            this.odczytajTablicęZPlikuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszTabliceWPlikuToolStripMenuItem
            // 
            this.zapiszTabliceWPlikuToolStripMenuItem.Name = "zapiszTabliceWPlikuToolStripMenuItem";
            this.zapiszTabliceWPlikuToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.zapiszTabliceWPlikuToolStripMenuItem.Text = "Zapisz tablice w pliku";
            this.zapiszTabliceWPlikuToolStripMenuItem.Click += new System.EventHandler(this.zapiszTabliceWPlikuToolStripMenuItem_Click);
            // 
            // odczytajTablicęZPlikuToolStripMenuItem
            // 
            this.odczytajTablicęZPlikuToolStripMenuItem.Name = "odczytajTablicęZPlikuToolStripMenuItem";
            this.odczytajTablicęZPlikuToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.odczytajTablicęZPlikuToolStripMenuItem.Text = "Odczytaj tablicę z pliku";
            this.odczytajTablicęZPlikuToolStripMenuItem.Click += new System.EventHandler(this.odczytajTablicęZPlikuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ustawieniaWykresuToolStripMenuItem
            // 
            this.ustawieniaWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorToolStripMenuItem,
            this.stylLiniiToolStripMenuItem});
            this.ustawieniaWykresuToolStripMenuItem.Name = "ustawieniaWykresuToolStripMenuItem";
            this.ustawieniaWykresuToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.ustawieniaWykresuToolStripMenuItem.Text = "Ustawienia wykresu";
            // 
            // kolorToolStripMenuItem
            // 
            this.kolorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorTlaWykresuToolStripMenuItem,
            this.kolorLiniiWykresuToolStripMenuItem});
            this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
            this.kolorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolorToolStripMenuItem.Text = "Kolor";
            // 
            // kolorTlaWykresuToolStripMenuItem
            // 
            this.kolorTlaWykresuToolStripMenuItem.Name = "kolorTlaWykresuToolStripMenuItem";
            this.kolorTlaWykresuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolorTlaWykresuToolStripMenuItem.Text = "Kolor tla wykresu";
            this.kolorTlaWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorTlaWykresuToolStripMenuItem_Click);
            // 
            // kolorLiniiWykresuToolStripMenuItem
            // 
            this.kolorLiniiWykresuToolStripMenuItem.Name = "kolorLiniiWykresuToolStripMenuItem";
            this.kolorLiniiWykresuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolorLiniiWykresuToolStripMenuItem.Text = "Kolor linii wykresu";
            this.kolorLiniiWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorLiniiWykresuToolStripMenuItem_Click);
            // 
            // stylLiniiToolStripMenuItem
            // 
            this.stylLiniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kropkowaToolStripMenuItem,
            this.ciągłaToolStripMenuItem,
            this.kreskowaToolStripMenuItem,
            this.kreskowokropkowaToolStripMenuItem});
            this.stylLiniiToolStripMenuItem.Name = "stylLiniiToolStripMenuItem";
            this.stylLiniiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stylLiniiToolStripMenuItem.Text = "Styl linii";
            // 
            // kropkowaToolStripMenuItem
            // 
            this.kropkowaToolStripMenuItem.Name = "kropkowaToolStripMenuItem";
            this.kropkowaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.kropkowaToolStripMenuItem.Text = "Kropkowa";
            this.kropkowaToolStripMenuItem.Click += new System.EventHandler(this.kropkowaToolStripMenuItem_Click);
            // 
            // ciągłaToolStripMenuItem
            // 
            this.ciągłaToolStripMenuItem.Name = "ciągłaToolStripMenuItem";
            this.ciągłaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ciągłaToolStripMenuItem.Text = "Ciągła";
            this.ciągłaToolStripMenuItem.Click += new System.EventHandler(this.ciągłaToolStripMenuItem_Click);
            // 
            // kreskowaToolStripMenuItem
            // 
            this.kreskowaToolStripMenuItem.Name = "kreskowaToolStripMenuItem";
            this.kreskowaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.kreskowaToolStripMenuItem.Text = "Kreskowa";
            this.kreskowaToolStripMenuItem.Click += new System.EventHandler(this.kreskowaToolStripMenuItem_Click);
            // 
            // kreskowokropkowaToolStripMenuItem
            // 
            this.kreskowokropkowaToolStripMenuItem.Name = "kreskowokropkowaToolStripMenuItem";
            this.kreskowokropkowaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.kreskowokropkowaToolStripMenuItem.Text = "Kreskowo--kropkowa";
            this.kreskowokropkowaToolStripMenuItem.Click += new System.EventHandler(this.kreskowokropkowaToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Goldenrod;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(214, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(797, 49);
            this.panel4.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(268, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 290);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dgvTablicaWartości
            // 
            this.dgvTablicaWartości.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablicaWartości.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTablicaWartości.Location = new System.Drawing.Point(268, 89);
            this.dgvTablicaWartości.Name = "dgvTablicaWartości";
            this.dgvTablicaWartości.Size = new System.Drawing.Size(484, 290);
            this.dgvTablicaWartości.TabIndex = 21;
            this.dgvTablicaWartości.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "S(X)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Licznik zsumowanych wyrazów szeregu";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // chtGraficznaWizualizacja
            // 
            chartArea9.Name = "ChartArea1";
            this.chtGraficznaWizualizacja.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chtGraficznaWizualizacja.Legends.Add(legend9);
            this.chtGraficznaWizualizacja.Location = new System.Drawing.Point(268, 89);
            this.chtGraficznaWizualizacja.Name = "chtGraficznaWizualizacja";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chtGraficznaWizualizacja.Series.Add(series9);
            this.chtGraficznaWizualizacja.Size = new System.Drawing.Size(484, 290);
            this.chtGraficznaWizualizacja.TabIndex = 22;
            this.chtGraficznaWizualizacja.Text = "GraficznaWizualizacja";
            this.chtGraficznaWizualizacja.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtWziernikKoloruLinii
            // 
            this.txtWziernikKoloruLinii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.txtWziernikKoloruLinii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWziernikKoloruLinii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWziernikKoloruLinii.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtWziernikKoloruLinii.Location = new System.Drawing.Point(23, 600);
            this.txtWziernikKoloruLinii.Multiline = true;
            this.txtWziernikKoloruLinii.Name = "txtWziernikKoloruLinii";
            this.txtWziernikKoloruLinii.Size = new System.Drawing.Size(169, 24);
            this.txtWziernikKoloruLinii.TabIndex = 8;
            this.txtWziernikKoloruLinii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWziernikKoloruTłaDlaObszaruWykresu
            // 
            this.txtWziernikKoloruTłaDlaObszaruWykresu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.txtWziernikKoloruTłaDlaObszaruWykresu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWziernikKoloruTłaDlaObszaruWykresu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWziernikKoloruTłaDlaObszaruWykresu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.txtWziernikKoloruTłaDlaObszaruWykresu.Location = new System.Drawing.Point(23, 558);
            this.txtWziernikKoloruTłaDlaObszaruWykresu.Multiline = true;
            this.txtWziernikKoloruTłaDlaObszaruWykresu.Name = "txtWziernikKoloruTłaDlaObszaruWykresu";
            this.txtWziernikKoloruTłaDlaObszaruWykresu.Size = new System.Drawing.Size(169, 24);
            this.txtWziernikKoloruTłaDlaObszaruWykresu.TabIndex = 9;
            this.txtWziernikKoloruTłaDlaObszaruWykresu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbStylLiniiWykresu
            // 
            this.cmbStylLiniiWykresu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.cmbStylLiniiWykresu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStylLiniiWykresu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStylLiniiWykresu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStylLiniiWykresu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.cmbStylLiniiWykresu.FormattingEnabled = true;
            this.cmbStylLiniiWykresu.Items.AddRange(new object[] {
            "Ciągła",
            "Kreskowa ",
            "Kropkowa ",
            "Kreskowo-kropkowa "});
            this.cmbStylLiniiWykresu.Location = new System.Drawing.Point(23, 510);
            this.cmbStylLiniiWykresu.Name = "cmbStylLiniiWykresu";
            this.cmbStylLiniiWykresu.Size = new System.Drawing.Size(169, 27);
            this.cmbStylLiniiWykresu.TabIndex = 10;
            this.cmbStylLiniiWykresu.Text = "Wybież styl linii";
            this.cmbStylLiniiWykresu.SelectedIndexChanged += new System.EventHandler(this.cmbStylLiniiWykresu_SelectedIndexChanged);
            // 
            // AnalizatorFunkcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1011, 652);
            this.Controls.Add(this.chtGraficznaWizualizacja);
            this.Controls.Add(this.dgvTablicaWartości);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtSzerokośćPodprzedziałów);
            this.Controls.Add(this.txtWynikObliczaniaCałki);
            this.Controls.Add(this.txtLiczbaPodprzedziałów);
            this.Controls.Add(this.txtWartośćFunkcji);
            this.Controls.Add(this.txtIlośćWyrażeń);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.txtEps);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnalizatorFunkcji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalizatorFunkcji";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablicaWartości)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficznaWizualizacja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.Button btnObliczenieCałki;
        private System.Windows.Forms.Button btnGraficznaWizualizacja;
        private System.Windows.Forms.Button btnTabelarycznaWizualizacja;
        private System.Windows.Forms.Button btnObliczenieFx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbMetodaCałkowania;
        private System.Windows.Forms.TextBox txtDolnaGranica;
        private System.Windows.Forms.TextBox txtGórnaGranica;
        private System.Windows.Forms.TextBox txtDokładnośćCałkowania;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIlośćWyrażeń;
        private System.Windows.Forms.TextBox txtWartośćFunkcji;
        private System.Windows.Forms.TextBox txtLiczbaPodprzedziałów;
        private System.Windows.Forms.TextBox txtWynikObliczaniaCałki;
        private System.Windows.Forms.TextBox txtSzerokośćPodprzedziałów;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszTabliceWPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytajTablicęZPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorTlaWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorLiniiWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kropkowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciągłaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreskowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreskowokropkowaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTablicaWartości;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraficznaWizualizacja;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbStylLiniiWykresu;
        private System.Windows.Forms.TextBox txtWziernikKoloruTłaDlaObszaruWykresu;
        private System.Windows.Forms.TextBox txtWziernikKoloruLinii;
    }
}