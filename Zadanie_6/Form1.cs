using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6
{
    public partial class Form1 : Form
    {

        String[] login_list = {"191030", "309827", "102040", "1"};
        String[] haslo_list = {"kodzik0", "haslo123", "mama4", "1"};
        Boolean sprawdz = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sprawdzenie();
                if (sprawdz == true)
                {
                    this.Hide();
                    this.okno1 = new Form2(this);
                    okno1.ShowDialog();
                    this.Close();
                }
                
            }
        }

        private void sprawdzenie()
        {
            for (int i = 0; i < login_list.Length; i++)
            {
                if ((login.Text == login_list[i]) && (haslo.Text == haslo_list[i]))
                {
                    sprawdz = true;
                }                
            }
            if (sprawdz == false)
            {
                MessageBox.Show("Podane dane są nieprawidłowe!");
            }
        }
    }
}
