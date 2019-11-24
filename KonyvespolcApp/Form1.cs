using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KonyvespolcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            aktualis_num.Maximum = 9999;
            max_num.Maximum = 9999;
        }

        private void hozzaad_button_Click(object sender, EventArgs e)
        {
            if(konyv_text.Text == "")
            {
                Console.WriteLine("Nem adtad meg a könyv nevét!");
                return;
            }
            lista.Items.Add(konyv_text.Text);
        }

        private void label_per_Click(object sender, EventArgs e)
        {
            
        }

        private void mentes_button_Click(object sender, EventArgs e)
        {
            string asd;
            try
            {
                asd = lista.SelectedItem.ToString();
            }catch
            {
                MessageBox.Show("nem választottál ki könyvet");
                return;
            }
            if(aktualis_num.Value > max_num.Value)
            {
                MessageBox.Show("Az aktuális oldal nem lehet nagyobb, mint az összes oldal!"); ;
                return;
            }
            if(aktualis_num.Value < 0 || max_num.Value < 0)
            {
                //ennek igazából semmi értelme, mert a numeric up down minimum értéke 0, de erre csak akkor jöttem rá mikor már megírtam.
                MessageBox.Show("Az oldalak száma nem lehet negatív szám!");
                return;
            }
            string kivalasztottkonyv = lista.SelectedItem.ToString();
            int aktualis = Convert.ToInt32(aktualis_num.Value), max = Convert.ToInt32(max_num.Value);
            var konyvek = new List<String>();
            for (int i = 0; i < lista.Items.Count; i++)
            {
                lista.SetSelected(i, false);
            }
            for (int i = 0; i < lista.Items.Count; i++)
            {
                lista.SetSelected(i, true);
                konyvek.Add(lista.SelectedItem.ToString());
            }
            StreamWriter sw = new StreamWriter("asd.txt");
            sw.WriteLine(kivalasztottkonyv);
            sw.WriteLine(aktualis);
            sw.WriteLine(max);
            foreach (var x in konyvek)
            {
                sw.WriteLine(x);
            }
            sw.Close();
        }

        private void betoltes_button_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("asd.txt");
            string kivalasztottkonyv = sr.ReadLine().ToString();
            int aktualis = Convert.ToInt32(sr.ReadLine());
            int max = Convert.ToInt32(sr.ReadLine());
            var konyvek = new List<String>();
            while(!sr.EndOfStream)
            {
                konyvek.Add(sr.ReadLine().ToString());
            }
            aktualis_num.Value = aktualis;
            max_num.Value = max;
            foreach(var x in konyvek)
            {
                lista.Items.Add(x);
            }
            sr.Close();
        }
    }
}
