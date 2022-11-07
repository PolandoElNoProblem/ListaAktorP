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

namespace lufenMachen
{
    public partial class LISTA : Form
    {
        public LISTA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OdczytZPliku();
        }

        private void usuńWybraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuwanieDanych();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            */
        }
        private void DodawanieDanych(string tytul, string rezyser, string data, string aktor)
        {
            ListViewItem item = new ListViewItem(new string[] {tytul, rezyser, data, aktor});
            listView1.Items.Add(item);
        }
        private void DodawanieDanych(string[] dane)
        {
            ListViewItem item = new ListViewItem(dane);
            listView1.Items.Add(item);
        }
        private void UsuwanieDanych()
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }

            listView1.Refresh();
        }
        private string[] WierszeDoPliku()
        {
            string[] linie = new string[listView1.Items.Count];
            int i = 0;
            foreach(ListViewItem item in listView1.Items)
            {
                linie[i] = "";
                for (int k = 0; k<item.SubItems.Count;k++)
                    linie[i] += item.SubItems[k].Text + "*";

                i++;
                
            }
            return linie;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Zap_Click(object sender, EventArgs e)
        {
            string[] linie = WierszeDoPliku();
            File.WriteAllLines("filmy.txt", linie);
            MessageBox.Show("Pomyślnie zapisano!");
        }
        private void OdczytZPliku()
        {
            if (!File.Exists("filmy.txt") )
                return;

            string[] linie=File.ReadAllLines("filmy.txt");
            foreach(string linia in linie)
            {
                string[] temp = linia.Split('*');
                DodawanieDanych(temp);
            }
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            // listView1.Items.Add(Tytul2,Rez2,dp2,GR3);
            DodawanieDanych(Tytul2.Text,Rez2.Text, dp2.Text, GR3.Text);
        }

        private void Zam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tytul2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
