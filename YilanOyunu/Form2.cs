﻿using MetroFramework.Forms;
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

namespace YilanOyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SkorlariOku();
        }

        private void SkorlariOku()
        {
            try
            {
                string[] satirlar = File.ReadAllLines("skorlar.txt");

                var sira = 1;
                foreach (var satir in satirlar)
                {
                    string[] hucreler = satir.Split(';');
                    int puan = Convert.ToInt32(hucreler[0]);
                    DateTime zaman = DateTime.Parse(hucreler[1]);
                    string ad = hucreler[2];
                    SkorTablosunaEkle(sira, ad, puan, zaman);
                    sira++;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Henüz Skor Yok");
            }

        }

        private void SkorTablosunaEkle(int sira, string ad, int puan, DateTime zaman)
        {
            ListViewItem lvi = new ListViewItem(sira.ToString());
            lvi.SubItems.Add(ad);
            lvi.SubItems.Add(puan.ToString("0000"));
            lvi.SubItems.Add(zaman.ToString());
            lvwSkorlar.Items.Add(lvi);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
