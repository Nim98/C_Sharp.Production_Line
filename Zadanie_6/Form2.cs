using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6
{
    public partial class Form2 : Form
    {
        int key_number;
        Random random = new Random();
        System.Media.SoundPlayer alarm = new System.Media.SoundPlayer(Properties.Resources.alarm);

        int stopien_wartosc, temperatura_wartosc, predkosc_wartosc, tempo_wartosc;
        int stopien_wzor = 0;
        int temperatura_wzor = 0;
        int losowe;
        double stopien_temperatura, stopien_tempo, stopien_temperatura_zdarzenie1, stopien_tempo_zdarzenie1, stopien_temperatura_zdarzenie2, stopien_tempo_zdarzenie2;
        double temperatura_predkosc, temperatura_tempo, temperatura_predkosc_zdarzenie1, temperatura_tempo_zdarzenie1, temperatura_predkosc_zdarzenie2, temperatura_tempo_zdarzenie2;
        Boolean wylosowane = false;

        public Form2(Form1 okno_rodzic)
        {
            InitializeComponent();
            this.rodzic = okno_rodzic;  
            
            predkosc_wartosc = random.Next(41, 54);
            predkosc_wykres.Series[0].Points.AddY(predkosc_wartosc);
            predkosc_zmiana.Value = predkosc_wartosc;
            predkosc_komunikat.Text = "Obecna wartość prędkości to " + predkosc_wartosc + "% największej możliwej wartości.";

            tempo_wartosc = random.Next(29, 36);
            tempo_wykres.Series[0].Points.AddY(tempo_wartosc);
            tempo_zmiana.Value = tempo_wartosc;
            tempo_komunikat.Text = "Obecna wartość tempa to " + tempo_wartosc + "% największej możliwej wartości.";

            stopien();
            temperatura();

            wykres.Start();
            obecnosc.Start();
            kontrola.Start();
        }

        private void stopien()
        {
            stopien_wyliczenie();
            if (stopien_wartosc > 100)
            {
                stopien_komunikat.Text = "Wartość poza granicą!!!";
                stopien_komunikat.BackColor = Color.Red;
            }
            else if ((stopien_wartosc <= 100) && (stopien_wartosc > 85))
            {
                stopien_komunikat.Text = "Obecny stopień wykorzystania procesora to " + stopien_wartosc + "% największej możliwej wartości. Wartość zbliża się do granicy.";
                stopien_komunikat.BackColor = Color.Red;
            }
            else if ((stopien_wartosc <= 85) && (stopien_wartosc > 65))
            {
                stopien_komunikat.Text = "Obecny stopień wykorzystania procesora to " + stopien_wartosc + "% największej możliwej wartości. Wartość jest optymalna.";
                stopien_komunikat.BackColor = Color.LimeGreen;
            }
            else
            {
                stopien_komunikat.Text = "Obecny stopień wykorzystania procesora to " + stopien_wartosc + "% największej możliwej wartości. Wartość jest stosunkowo niska.";
                stopien_komunikat.BackColor = Color.Yellow;
            }
        }

        private void stopien_wyliczenie()
        {            
            if (stopien_wzor == 0)
            {
                stopien_temperatura = 0.3 * temperatura_wartosc;
                stopien_tempo = 1.7 * tempo_wartosc;
                stopien_wartosc = (int)(stopien_temperatura + stopien_tempo);
            }
            else if (stopien_wzor == 1)
            {
                stopien_temperatura_zdarzenie1 = 0.01 * temperatura_wartosc;
                stopien_tempo_zdarzenie1 = 1.99 * tempo_wartosc;
                stopien_wartosc = (int)(stopien_temperatura_zdarzenie1 + stopien_tempo_zdarzenie1);
            }
            else if (stopien_wzor == 2)
            {
                stopien_temperatura_zdarzenie2 = 1.1 * temperatura_wartosc;
                stopien_tempo_zdarzenie2 = 0.9 * tempo_wartosc;
                stopien_wartosc = (int)(stopien_temperatura_zdarzenie2 + stopien_tempo_zdarzenie2);
            }
        }

        private void temperatura()
        {
            temperatura_wyliczenie();
            if (temperatura_wartosc > 85)
            {
                temperatura_komunikat.Text = "Temperatura wynosi " + temperatura_wartosc + "°C. Temperatura jest za wysoka!";
                temperatura_komunikat.BackColor = Color.Red;
            }
            else if ((temperatura_wartosc <= 85) && (temperatura_wartosc > 75))
            {
                temperatura_komunikat.Text = "Temperatura wynosi " + temperatura_wartosc + "°C. Temperatura zbliża się do górnej granicy.";
                temperatura_komunikat.BackColor = Color.Yellow;
            }
            else if ((temperatura_wartosc <= 75) && (temperatura_wartosc > 55))
            {
                temperatura_komunikat.Text = "Temperatura wynosi " + temperatura_wartosc + "°C. Temperatura jest optymalna.";
                temperatura_komunikat.BackColor = Color.LimeGreen;
            }
            else
            {
                temperatura_komunikat.Text = "Temperatura wynosi " + temperatura_wartosc + "°C. Temperatura jest niska.";
                temperatura_komunikat.BackColor = Color.Yellow;
            }
        }

        private void temperatura_wyliczenie()
        {            
            if (temperatura_wzor == 0)
            {
                temperatura_predkosc = 1.1 * predkosc_wartosc;
                temperatura_tempo = 0.4 * tempo_wartosc;
                temperatura_wartosc = (int)(temperatura_predkosc + temperatura_tempo);
            }
            else if (temperatura_wzor == 1)
            {
                temperatura_predkosc_zdarzenie1 = 1.49 * predkosc_wartosc;
                temperatura_tempo_zdarzenie1 = 0.01 * tempo_wartosc;
                temperatura_wartosc = (int)(temperatura_predkosc_zdarzenie1 + temperatura_tempo_zdarzenie1);
            }
            else if (temperatura_wzor == 2)
            {
                temperatura_predkosc_zdarzenie2 = 0.6 * predkosc_wartosc;
                temperatura_tempo_zdarzenie2 = 0.9 * tempo_wartosc;
                temperatura_wartosc = (int)(temperatura_predkosc_zdarzenie2 + temperatura_tempo_zdarzenie2);
            }
        }

        private void predkosc_zmiana_Scroll(object sender, EventArgs e)
        {
            if ((aktywnosc_komunikat.Text == "Pracownik jest aktywny.") || (aktywnosc_komunikat.Text == "Dziękujemy za potwierdzenie. Pracownik jest aktywny.") || (aktywnosc_komunikat.Text == "Wznowiono pracę."))
            {
                obecnosc_reset();
                predkosc_wartosc = predkosc_zmiana.Value;
                predkosc_wykres.Series[0].Points[0].SetValueY(predkosc_wartosc);
                predkosc_wykres.Refresh();
                predkosc_komunikat.Text = "Obecna wartość prędkości to " + predkosc_wartosc + "% największej możliwej wartości.";
            } 
        }

        private void tempo_zmiana_Scroll(object sender, EventArgs e)
        {
            if ((aktywnosc_komunikat.Text == "Pracownik jest aktywny.") || (aktywnosc_komunikat.Text == "Dziękujemy za potwierdzenie. Pracownik jest aktywny.") || (aktywnosc_komunikat.Text == "Wznowiono pracę."))
            {
                obecnosc_reset();
                potwierdzenie_aktywnosci();
                aktywnosc_komunikat.Text = "Pracownik jest aktywny.";
                tempo_wartosc = tempo_zmiana.Value;
                tempo_wykres.Series[0].Points[0].SetValueY(tempo_wartosc);
                tempo_wykres.Refresh();
                tempo_komunikat.Text = "Obecna wartość tempa to " + tempo_wartosc + "% największej możliwej wartości.";
            }
        }

        private void losowe_zdarzenie_Tick(object sender, EventArgs e)
        {
            losuj();
        }

        private void losuj()
        {
            losowe = random.Next(4);
            losowe_zdarzenie.Stop();
            wylosowane = true;
            if (losowe == 0)
            {
                zdarzenie.Text = "Wystąpiło zdarzenie: Pojawila się awaria podajnika elementów, która została już naprawiona. Przyśpiesz linię produkcyjną, aby nadrobić straty.";
                stopien_wzor = 1;
            }

            else if (losowe == 1)
            {
                zdarzenie.Text = "Wystąpiło zdarzenie: Pojawiło się nieoczekiwane zadanie obciążające procesor. Zmniejsz tempo pracy.";
                stopien_wzor = 2;
            }

            else if (losowe == 2)
            {
                zdarzenie.Text = "Wystąpiło zdarzenie: Zakupiono nowy wentylator, możesz zmniejszyć prędkość obrotową.";
                temperatura_wzor = 1;
            }

            else if (losowe == 3)
            {
                zdarzenie.Text = "Wystąpiło zdarzenie: Jeden z wentylatorów przestał działać. Zwiększ prędkość obrotową.";
                temperatura_wzor = 2;
            }
        }

        private void kontrola_Tick(object sender, EventArgs e)
        {
            stopien();
            temperatura();
            if ((stopien_komunikat.BackColor == Color.LimeGreen) && (temperatura_komunikat.BackColor == Color.LimeGreen))
            {
                if (wylosowane == true)
                {
                    losuj();
                }
                else
                {
                    zdarzenie.Text = "Rozwiązano problem.";
                    losowe_zdarzenie.Start();
                }                
            }
            else
            {
                wylosowane = false;
            }
        }

        private void wykres_Tick(object sender, EventArgs e)
        {
            stopien_wykres.Series[0].Points.AddY(stopien_wartosc);
            temperatura_wykres.Series[0].Points.AddY(temperatura_wartosc);
        }

        private void obecnosc_Tick(object sender, EventArgs e)
        {
            wylogowanie.Start();
            obecnosc.Stop();
            key_number = random.Next(10);
            aktywnosc_komunikat.Text = "Wykryto brak aktywności przez dłuższy czas, naciśnij klawisz "+key_number+".";
            aktywnosc_komunikat.BackColor = Color.Red;
        }

        private void obecnosc_reset()
        {
            obecnosc.Stop();
            wylogowanie.Stop();
            obecnosc.Start();
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '1') && (key_number == 1)) { potwierdzenie_aktywnosci(); }
            else if ((e.KeyChar == '2') && (key_number == 2)) { potwierdzenie_aktywnosci(); }
            else if ((e.KeyChar == '3') && (key_number == 3)) { potwierdzenie_aktywnosci(); }
            else if ((e.KeyChar == '4') && (key_number == 4)) { potwierdzenie_aktywnosci(); }
            else if ((e.KeyChar == '5') && (key_number == 5)) { potwierdzenie_aktywnosci(); }
            else if ((e.KeyChar == '6') && (key_number == 6)) { potwierdzenie_aktywnosci(); }
            else if ((e.KeyChar == '7') && (key_number == 7)) { potwierdzenie_aktywnosci(); }
            else if ((e.KeyChar == '8') && (key_number == 8)) { potwierdzenie_aktywnosci(); }
            else if ((e.KeyChar == '9') && (key_number == 9)) { potwierdzenie_aktywnosci(); }
            else if ((e.KeyChar == '0') && (key_number == 0)) { potwierdzenie_aktywnosci(); }
        }

        private void potwierdzenie_aktywnosci()
        {
            wylogowanie.Stop();
            aktywnosc_komunikat.Text = "Dziękujemy za potwierdzenie. Pracownik jest aktywny.";
            aktywnosc_komunikat.BackColor = Color.LimeGreen;
        }

        private void wylogowanie_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Form1 okno0 = new Form1();
            alarm.Play();
            const string wylogowanie_wiadomosc = "Natąpiło wylogowanie z systemu. Alarm został włączony.";
            const string wylogowanie_tytul = "Wylogowanie";
            var wylogowanie_odpowiedz = MessageBox.Show(wylogowanie_wiadomosc, wylogowanie_tytul, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (wylogowanie_odpowiedz == DialogResult.OK)
            {
                alarm.Stop();
                okno0.ShowDialog();
                this.Close();                
            }
        }

        private void start_stop_Click(object sender, EventArgs e)
        {
            potwierdzenie_aktywnosci();
            if (start_stop.Text == "Zatrzymaj pracę linii produkcyjnej")
            {
                wykres.Stop();
                start_stop.Text = "Wznów pracę linii produkcyjnej";
                start_stop.BackColor = System.Drawing.SystemColors.ButtonShadow;
                start_stop.FlatStyle = FlatStyle.Flat;
                aktywnosc_komunikat.Text = "Przerwa.";
                aktywnosc_komunikat.BackColor = Color.Yellow;
                obecnosc.Stop();
                losowe_zdarzenie.Stop();
            }
            else
            {
                wykres.Start();
                start_stop.Text = "Zatrzymaj pracę linii produkcyjnej";
                start_stop.BackColor = System.Drawing.SystemColors.ButtonFace;
                start_stop.FlatStyle = FlatStyle.Standard;
                aktywnosc_komunikat.Text = "Wznowiono pracę.";
                obecnosc.Start();
            }
        }
    }
}
