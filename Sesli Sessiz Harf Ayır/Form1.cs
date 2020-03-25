using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sesli_Sessiz_Harf_Ayır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        char[] harf = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü', };

        string kelime;

        int x = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            kelime = textBox1.Text;
            
            foreach (char harf1 in kelime)
            {
                x = 0;

                for (int i = 0; i < harf.Length; i++)
                {
                    if (harf1==harf[i])
                    {
                        listBox1.Items.Add(harf1);
                        x++;
                        break;
                    }
                }

                if (x==0)
                {
                    listBox2.Items.Add(harf1);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://muratbilginerncfkr.blogspot.com");
        }

    }
}
