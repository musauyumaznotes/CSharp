using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kura_Çekimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Takim> takimlar;
        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox>gruplar = new List<ListBox>();
        private void Form1_Load(object sender, EventArgs e)
        {
            takimlar = new List<Takim>();
            Takim yeniTakim;
             yeniTakim= new Takim("Bayern Münih", "Almanya");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Fc Barcelona", "İspanya");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Chelsea", "İngiltere");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Fenerbahçe", "Türkiye");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Napoli", "İtalya");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Celtic", "İskoçya");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Victoria Plzen", "Çek Cumhuriyeti");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Roma", "İtalya");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Austria Wien", "Avusturya");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Real Sociedad", "İspanya");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Beşiktaş", "Türkiye");
            takimlar.Add(yeniTakim);
             yeniTakim= new Takim("Trabzonspor", "Türkiye");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Galatasaray", "Türkiye");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Olympiakos", "Yunanistan");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Borussia Dortmund", "Almanya");
            takimlar.Add(yeniTakim);
             yeniTakim = new Takim("Basel", "İsviçre");
            takimlar.Add(yeniTakim);
             yeniTakim= new Takim("Ajax", "Hollanda");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Real Madrid", "İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Manchester United", "İngiltere");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Arsenal", "İngiltere");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Porto", "Portekiz");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Benfica", "Portekiz");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Atletico Madrid", "İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Shaktar Donetsk", "Ukrayna");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Milan", "İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Schalke 04", "Almanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Marsilya", "Fransa");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("CSKA Moskova", "Rusya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Paris-Saint Germain", "Fransa");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Juventus", "İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Zenit", "Rusya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Manchester City", "İngiltere");
            takimlar.Add(yeniTakim);
           






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilenTakimlar = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                secilenTakimlar.Clear();
                for (int j = 0; j < 8; j++)
                {
                    int secilenTakim = rastgele.Next(0,takimlar.Count/4);

                    if (secilenTakimlar.Contains(secilenTakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilenTakimlar.Add(secilenTakim);
                    }
                }
                bool ayniUlkedenTakimVar = false;
                for (int k = 0; k < 8; k++)
                {
                    ayniUlkedenTakimVar = AyniUlkedenTakimVarMi(gruplar[k], torbalar[i].Items[secilenTakimlar[k]] as Takim);
                    if (ayniUlkedenTakimVar)
                    {
                        break;
                    }
                }
                if (!ayniUlkedenTakimVar)
                {
                    listBox1.Items.Add(torbalar[i].Items[secilenTakimlar[0]]as Takim);
                    listBox2.Items.Add(torbalar[i].Items[secilenTakimlar[1]] as Takim);
                    listBox3.Items.Add(torbalar[i].Items[secilenTakimlar[2]] as Takim);
                    listBox4.Items.Add(torbalar[i].Items[secilenTakimlar[3]] as Takim);
                    listBox5.Items.Add(torbalar[i].Items[secilenTakimlar[4]] as Takim);
                    listBox6.Items.Add(torbalar[i].Items[secilenTakimlar[5]] as Takim);
                    listBox7.Items.Add(torbalar[i].Items[secilenTakimlar[6]] as Takim);
                    listBox8.Items.Add(torbalar[i].Items[secilenTakimlar[7]] as Takim);

                }
                else
                {
                    i--;
                }
            }
            
        }
        private bool AyniUlkedenTakimVarMi(ListBox grup,Takim takim)
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim grupTakim = grup.Items[i] as Takim;
                if (grupTakim.Ulke==takim.Ulke)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilenTakimlar = new List<int>();
            for (int i = 0; i < takimlar.Count; i++)
            {
                int secilenTakim = rastgele.Next(0,takimlar.Count);
                if (secilenTakimlar.Contains(secilenTakim))
                {
                    i--;
                }
                else
                {
                    secilenTakimlar.Add(secilenTakim);
                }
            }
            for (int i = 0; i < secilenTakimlar.Count; i++)
            {
                if (i<8)
                {
                    lstTorba1.Items.Add(takimlar[secilenTakimlar[i]]);
                }
                else if (i<16)
                {
                    lstTorba2.Items.Add(takimlar[secilenTakimlar[i]]);
                }
                else if (i < 24)
                {
                    lstTorba3.Items.Add(takimlar[secilenTakimlar[i]]);
                }
                else if (i < 32)
                {
                    lstTorba4.Items.Add(takimlar[secilenTakimlar[i]]);
                }
            }
            torbalar.Add(lstTorba1);
            torbalar.Add(lstTorba2);
            torbalar.Add(lstTorba3);
            torbalar.Add(lstTorba4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
        }
    }
}
