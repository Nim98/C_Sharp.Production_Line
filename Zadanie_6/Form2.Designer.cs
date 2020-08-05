namespace Zadanie_6
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        Form1 rodzic;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.obecnosc = new System.Windows.Forms.Timer(this.components);
            this.wylogowanie = new System.Windows.Forms.Timer(this.components);
            this.aktywnosc_komunikat = new System.Windows.Forms.Label();
            this.aktywnosc_tekst = new System.Windows.Forms.Label();
            this.temperatura_tekst = new System.Windows.Forms.Label();
            this.komunikat_tekst = new System.Windows.Forms.Label();
            this.stopien_tekst = new System.Windows.Forms.Label();
            this.predkosc_tekst = new System.Windows.Forms.Label();
            this.tempo_tekst = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stopien_komunikat = new System.Windows.Forms.Label();
            this.temperatura_komunikat = new System.Windows.Forms.Label();
            this.predkosc_komunikat = new System.Windows.Forms.Label();
            this.tempo_komunikat = new System.Windows.Forms.Label();
            this.stopien_wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temperatura_wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.predkosc_wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tempo_wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.predkosc_zmiana = new System.Windows.Forms.TrackBar();
            this.tempo_zmiana = new System.Windows.Forms.TrackBar();
            this.wykres = new System.Windows.Forms.Timer(this.components);
            this.start_stop = new System.Windows.Forms.Button();
            this.losowe_zdarzenie = new System.Windows.Forms.Timer(this.components);
            this.zdarzenie = new System.Windows.Forms.Label();
            this.kontrola = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopien_wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatura_wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predkosc_wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempo_wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predkosc_zmiana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempo_zmiana)).BeginInit();
            this.SuspendLayout();
            // 
            // obecnosc
            // 
            this.obecnosc.Interval = 15000;
            this.obecnosc.Tick += new System.EventHandler(this.obecnosc_Tick);
            // 
            // wylogowanie
            // 
            this.wylogowanie.Interval = 30000;
            this.wylogowanie.Tick += new System.EventHandler(this.wylogowanie_Tick);
            // 
            // aktywnosc_komunikat
            // 
            this.aktywnosc_komunikat.AutoSize = true;
            this.aktywnosc_komunikat.BackColor = System.Drawing.Color.LimeGreen;
            this.aktywnosc_komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktywnosc_komunikat.Location = new System.Drawing.Point(350, 10);
            this.aktywnosc_komunikat.Name = "aktywnosc_komunikat";
            this.aktywnosc_komunikat.Size = new System.Drawing.Size(134, 15);
            this.aktywnosc_komunikat.TabIndex = 0;
            this.aktywnosc_komunikat.Text = "Pracownik jest aktywny.";
            // 
            // aktywnosc_tekst
            // 
            this.aktywnosc_tekst.AutoSize = true;
            this.aktywnosc_tekst.BackColor = System.Drawing.SystemColors.Menu;
            this.aktywnosc_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktywnosc_tekst.Location = new System.Drawing.Point(110, 10);
            this.aktywnosc_tekst.Name = "aktywnosc_tekst";
            this.aktywnosc_tekst.Size = new System.Drawing.Size(76, 15);
            this.aktywnosc_tekst.TabIndex = 1;
            this.aktywnosc_tekst.Text = "Aktywność:";
            // 
            // temperatura_tekst
            // 
            this.temperatura_tekst.AutoSize = true;
            this.temperatura_tekst.BackColor = System.Drawing.SystemColors.Menu;
            this.temperatura_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperatura_tekst.Location = new System.Drawing.Point(110, 46);
            this.temperatura_tekst.Name = "temperatura_tekst";
            this.temperatura_tekst.Size = new System.Drawing.Size(213, 15);
            this.temperatura_tekst.TabIndex = 2;
            this.temperatura_tekst.Text = "Temperatura rdzenia procesora:";
            // 
            // komunikat_tekst
            // 
            this.komunikat_tekst.AutoSize = true;
            this.komunikat_tekst.BackColor = System.Drawing.SystemColors.Menu;
            this.komunikat_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komunikat_tekst.Location = new System.Drawing.Point(12, 10);
            this.komunikat_tekst.Name = "komunikat_tekst";
            this.komunikat_tekst.Size = new System.Drawing.Size(91, 17);
            this.komunikat_tekst.TabIndex = 3;
            this.komunikat_tekst.Text = "Komunikaty";
            // 
            // stopien_tekst
            // 
            this.stopien_tekst.AutoSize = true;
            this.stopien_tekst.BackColor = System.Drawing.SystemColors.Menu;
            this.stopien_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopien_tekst.Location = new System.Drawing.Point(110, 28);
            this.stopien_tekst.Name = "stopien_tekst";
            this.stopien_tekst.Size = new System.Drawing.Size(220, 15);
            this.stopien_tekst.TabIndex = 4;
            this.stopien_tekst.Text = "Stopień wykorzystania procesora:";
            // 
            // predkosc_tekst
            // 
            this.predkosc_tekst.AutoSize = true;
            this.predkosc_tekst.BackColor = System.Drawing.SystemColors.Menu;
            this.predkosc_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.predkosc_tekst.Location = new System.Drawing.Point(110, 64);
            this.predkosc_tekst.Name = "predkosc_tekst";
            this.predkosc_tekst.Size = new System.Drawing.Size(220, 15);
            this.predkosc_tekst.TabIndex = 5;
            this.predkosc_tekst.Text = "Prędkość obrotowa wentylatorów:";
            // 
            // tempo_tekst
            // 
            this.tempo_tekst.AutoSize = true;
            this.tempo_tekst.BackColor = System.Drawing.SystemColors.Menu;
            this.tempo_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempo_tekst.Location = new System.Drawing.Point(110, 82);
            this.tempo_tekst.Name = "tempo_tekst";
            this.tempo_tekst.Size = new System.Drawing.Size(206, 15);
            this.tempo_tekst.TabIndex = 6;
            this.tempo_tekst.Text = "Tempo pracy linii produkcyjnej:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(110, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 95);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // stopien_komunikat
            // 
            this.stopien_komunikat.AutoSize = true;
            this.stopien_komunikat.BackColor = System.Drawing.Color.LimeGreen;
            this.stopien_komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopien_komunikat.Location = new System.Drawing.Point(350, 28);
            this.stopien_komunikat.Name = "stopien_komunikat";
            this.stopien_komunikat.Size = new System.Drawing.Size(10, 15);
            this.stopien_komunikat.TabIndex = 8;
            this.stopien_komunikat.Text = ".";
            // 
            // temperatura_komunikat
            // 
            this.temperatura_komunikat.AutoSize = true;
            this.temperatura_komunikat.BackColor = System.Drawing.Color.LimeGreen;
            this.temperatura_komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperatura_komunikat.Location = new System.Drawing.Point(350, 46);
            this.temperatura_komunikat.Name = "temperatura_komunikat";
            this.temperatura_komunikat.Size = new System.Drawing.Size(10, 15);
            this.temperatura_komunikat.TabIndex = 9;
            this.temperatura_komunikat.Text = ".";
            // 
            // predkosc_komunikat
            // 
            this.predkosc_komunikat.AutoSize = true;
            this.predkosc_komunikat.BackColor = System.Drawing.Color.LemonChiffon;
            this.predkosc_komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.predkosc_komunikat.Location = new System.Drawing.Point(350, 64);
            this.predkosc_komunikat.Name = "predkosc_komunikat";
            this.predkosc_komunikat.Size = new System.Drawing.Size(10, 15);
            this.predkosc_komunikat.TabIndex = 10;
            this.predkosc_komunikat.Text = ".";
            // 
            // tempo_komunikat
            // 
            this.tempo_komunikat.AutoSize = true;
            this.tempo_komunikat.BackColor = System.Drawing.Color.LemonChiffon;
            this.tempo_komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempo_komunikat.Location = new System.Drawing.Point(350, 82);
            this.tempo_komunikat.Name = "tempo_komunikat";
            this.tempo_komunikat.Size = new System.Drawing.Size(10, 15);
            this.tempo_komunikat.TabIndex = 11;
            this.tempo_komunikat.Text = ".";
            // 
            // stopien_wykres
            // 
            chartArea5.Name = "ChartArea1";
            this.stopien_wykres.ChartAreas.Add(chartArea5);
            this.stopien_wykres.Location = new System.Drawing.Point(40, 120);
            this.stopien_wykres.Name = "stopien_wykres";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.SteelBlue;
            series5.Name = "Series1";
            this.stopien_wykres.Series.Add(series5);
            this.stopien_wykres.Size = new System.Drawing.Size(300, 300);
            this.stopien_wykres.TabIndex = 12;
            this.stopien_wykres.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Stopień wykorzystania procesora [%]";
            this.stopien_wykres.Titles.Add(title5);
            this.stopien_wykres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            // 
            // temperatura_wykres
            // 
            chartArea6.Name = "ChartArea1";
            this.temperatura_wykres.ChartAreas.Add(chartArea6);
            this.temperatura_wykres.Location = new System.Drawing.Point(380, 120);
            this.temperatura_wykres.Name = "temperatura_wykres";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.SteelBlue;
            series6.Name = "Series1";
            this.temperatura_wykres.Series.Add(series6);
            this.temperatura_wykres.Size = new System.Drawing.Size(300, 300);
            this.temperatura_wykres.TabIndex = 13;
            this.temperatura_wykres.Text = "chart2";
            title6.Name = "Title1";
            title6.Text = "Temperatura rdzenia procesora [°C]";
            this.temperatura_wykres.Titles.Add(title6);
            this.temperatura_wykres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            // 
            // predkosc_wykres
            // 
            chartArea7.AxisX.Maximum = 1D;
            chartArea7.AxisX.Minimum = 1D;
            chartArea7.AxisY.Maximum = 100D;
            chartArea7.AxisY.Minimum = 0D;
            chartArea7.Name = "ChartArea1";
            this.predkosc_wykres.ChartAreas.Add(chartArea7);
            this.predkosc_wykres.Location = new System.Drawing.Point(720, 120);
            this.predkosc_wykres.Name = "predkosc_wykres";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.SteelBlue;
            series7.Name = "Series1";
            this.predkosc_wykres.Series.Add(series7);
            this.predkosc_wykres.Size = new System.Drawing.Size(100, 250);
            this.predkosc_wykres.TabIndex = 14;
            this.predkosc_wykres.Text = "chart1";
            title7.Name = "Title1";
            title7.Text = "Prędkość obrotowa wentylatorów [%]";
            this.predkosc_wykres.Titles.Add(title7);
            this.predkosc_wykres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            // 
            // tempo_wykres
            // 
            chartArea8.AxisX.Maximum = 1D;
            chartArea8.AxisX.Minimum = 1D;
            chartArea8.AxisY.Maximum = 100D;
            chartArea8.AxisY.Minimum = 0D;
            chartArea8.Name = "ChartArea1";
            this.tempo_wykres.ChartAreas.Add(chartArea8);
            this.tempo_wykres.Location = new System.Drawing.Point(860, 120);
            this.tempo_wykres.Name = "tempo_wykres";
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.SteelBlue;
            series8.Name = "Series1";
            this.tempo_wykres.Series.Add(series8);
            this.tempo_wykres.Size = new System.Drawing.Size(100, 250);
            this.tempo_wykres.TabIndex = 15;
            this.tempo_wykres.Text = "chart2";
            title8.Name = "Title1";
            title8.Text = "Tempo pracy linii produkcyjnej [%]";
            this.tempo_wykres.Titles.Add(title8);
            this.tempo_wykres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            // 
            // predkosc_zmiana
            // 
            this.predkosc_zmiana.LargeChange = 10;
            this.predkosc_zmiana.Location = new System.Drawing.Point(720, 375);
            this.predkosc_zmiana.Maximum = 100;
            this.predkosc_zmiana.Name = "predkosc_zmiana";
            this.predkosc_zmiana.Size = new System.Drawing.Size(100, 45);
            this.predkosc_zmiana.TabIndex = 16;
            this.predkosc_zmiana.TickFrequency = 100;
            this.predkosc_zmiana.Scroll += new System.EventHandler(this.predkosc_zmiana_Scroll);
            this.predkosc_zmiana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            // 
            // tempo_zmiana
            // 
            this.tempo_zmiana.LargeChange = 10;
            this.tempo_zmiana.Location = new System.Drawing.Point(860, 375);
            this.tempo_zmiana.Maximum = 100;
            this.tempo_zmiana.Name = "tempo_zmiana";
            this.tempo_zmiana.Size = new System.Drawing.Size(100, 45);
            this.tempo_zmiana.TabIndex = 17;
            this.tempo_zmiana.TickFrequency = 100;
            this.tempo_zmiana.Scroll += new System.EventHandler(this.tempo_zmiana_Scroll);
            this.tempo_zmiana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            // 
            // wykres
            // 
            this.wykres.Interval = 3000;
            this.wykres.Tick += new System.EventHandler(this.wykres_Tick);
            // 
            // start_stop
            // 
            this.start_stop.Location = new System.Drawing.Point(15, 40);
            this.start_stop.Name = "start_stop";
            this.start_stop.Size = new System.Drawing.Size(80, 60);
            this.start_stop.TabIndex = 18;
            this.start_stop.Text = "Zatrzymaj pracę linii produkcyjnej";
            this.start_stop.UseVisualStyleBackColor = true;
            this.start_stop.Click += new System.EventHandler(this.start_stop_Click);
            this.start_stop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            // 
            // losowe_zdarzenie
            // 
            this.losowe_zdarzenie.Interval = 7500;
            this.losowe_zdarzenie.Tick += new System.EventHandler(this.losowe_zdarzenie_Tick);
            // 
            // zdarzenie
            // 
            this.zdarzenie.AutoSize = true;
            this.zdarzenie.BackColor = System.Drawing.SystemColors.Menu;
            this.zdarzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zdarzenie.Location = new System.Drawing.Point(40, 430);
            this.zdarzenie.Name = "zdarzenie";
            this.zdarzenie.Size = new System.Drawing.Size(0, 15);
            this.zdarzenie.TabIndex = 19;
            // 
            // kontrola
            // 
            this.kontrola.Interval = 1;
            this.kontrola.Tick += new System.EventHandler(this.kontrola_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zadanie_6.Properties.Resources.Form2_tlo;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.zdarzenie);
            this.Controls.Add(this.start_stop);
            this.Controls.Add(this.tempo_zmiana);
            this.Controls.Add(this.predkosc_zmiana);
            this.Controls.Add(this.tempo_wykres);
            this.Controls.Add(this.predkosc_wykres);
            this.Controls.Add(this.temperatura_wykres);
            this.Controls.Add(this.stopien_wykres);
            this.Controls.Add(this.tempo_komunikat);
            this.Controls.Add(this.predkosc_komunikat);
            this.Controls.Add(this.temperatura_komunikat);
            this.Controls.Add(this.stopien_komunikat);
            this.Controls.Add(this.tempo_tekst);
            this.Controls.Add(this.predkosc_tekst);
            this.Controls.Add(this.stopien_tekst);
            this.Controls.Add(this.komunikat_tekst);
            this.Controls.Add(this.temperatura_tekst);
            this.Controls.Add(this.aktywnosc_tekst);
            this.Controls.Add(this.aktywnosc_komunikat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linia produkcyjna";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopien_wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatura_wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predkosc_wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempo_wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predkosc_zmiana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempo_zmiana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer obecnosc;
        private System.Windows.Forms.Timer wylogowanie;
        private System.Windows.Forms.Label aktywnosc_komunikat;
        private System.Windows.Forms.Label aktywnosc_tekst;
        private System.Windows.Forms.Label temperatura_tekst;
        private System.Windows.Forms.Label komunikat_tekst;
        private System.Windows.Forms.Label stopien_tekst;
        private System.Windows.Forms.Label predkosc_tekst;
        private System.Windows.Forms.Label tempo_tekst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label stopien_komunikat;
        private System.Windows.Forms.Label temperatura_komunikat;
        private System.Windows.Forms.Label predkosc_komunikat;
        private System.Windows.Forms.Label tempo_komunikat;
        private System.Windows.Forms.DataVisualization.Charting.Chart stopien_wykres;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatura_wykres;
        private System.Windows.Forms.DataVisualization.Charting.Chart predkosc_wykres;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempo_wykres;
        private System.Windows.Forms.TrackBar predkosc_zmiana;
        private System.Windows.Forms.TrackBar tempo_zmiana;
        private System.Windows.Forms.Timer wykres;
        private System.Windows.Forms.Button start_stop;
        private System.Windows.Forms.Timer losowe_zdarzenie;
        private System.Windows.Forms.Label zdarzenie;
        private System.Windows.Forms.Timer kontrola;
    }
}