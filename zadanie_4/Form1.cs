using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace zadanie_4 
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Odwracanie kolejnoœci ci¹gu znaków
        public static string Reverse(string s)
        {
            char[] reversedArray = s.ToCharArray();
            Array.Reverse(reversedArray);
            return new string(reversedArray);
        }

        //Zamiana wulgaryzmu na znaki "*"
        public static string Change(int n)
        {
            string word = null;
            for (int i = 0; i <= n; i++)
            {
                word += "*";
            }
            return word;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message;
            message = this.textBox1.Text;
            string[] lines = System.IO.File.ReadAllLines("grubo.txt");

            // Sprawdzenie zawartoœci pod k¹tem wulgaryzmów
            foreach (string line in lines)
            {
                bool contain = message.Contains(line);
                if (contain)
                {
                    int index = message.IndexOf(line);
                    if (index >= 0)
                    {
                        message = message.Replace(line, Change(line.Length));
                    }
                }
            }

            byte[] bytes = Encoding.ASCII.GetBytes(message);    //dekodowanie znaków ASCII na ci¹g bitów
            foreach (byte b in bytes)
            {
                dane[i] = Convert.ToString(b, 2).PadLeft(8, '0');   //Zamiana z typu bite na typ string
                dane_reversed[i] = Reverse(dane[i]);    //Zamiana kolejnoœci LSB <-> MSB
                i++;
            }
            int x = i;
            i = 0;
            for (int j = 0; x > j; j++)
            {
                ciag_binarny = ciag_binarny + "0" + dane_reversed[j] + "11";    //Dodanie bitów startu i stopu
            }
            this.textBox3.Text = ciag_binarny;  //Wyœwietlenie zakodowanej wiadomoœci w formie binarnej

            //Wyœwietlenie w odbiorniku
            this.textBox2.Text = "";
            int k = ciag_binarny.Length;
            int m = 0;
            for (int l = 0; l < k; l = l + 11)
            {
                String substring = ciag_binarny.Substring(l + 1, 8);
                wiadomosc_odebrana_odwrocona[m] = substring;
                wiadomosc_odebrana = wiadomosc_odebrana + Reverse(wiadomosc_odebrana_odwrocona[m]);
                m++;
            }

            var data = GetBytesFromBinaryString(wiadomosc_odebrana);
            var text = Encoding.ASCII.GetString((byte[])data);
            this.textBox2.Text = text;
            this.textBox1.Clear();
            ciag_binarny = null;
            wiadomosc_odebrana = null;
        }

        private object GetBytesFromBinaryString(string wiadomosc_odebrana)
        {
            var list = new List<Byte>();
            for (int i = 0; i < wiadomosc_odebrana.Length; i += 8)
            {
                string t = wiadomosc_odebrana.Substring(i, 8);
                list.Add(Convert.ToByte(t, 2));
            }
            return list.ToArray();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
