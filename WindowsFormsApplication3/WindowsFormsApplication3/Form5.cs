﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                Form7 frm2 = new Form7();
                frm2.Show();
                Close();
                

                
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("KULLANICI ADI VE ŞİFRE BOŞ BIRAKILAMAZ");
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "")
            {
                MessageBox.Show("ŞİFRE BOŞ BIRAKILAMAZ");
            }
            else if (textBox1.Text != "admin" && textBox2.Text != "admin")
            {
                MessageBox.Show("KULLANICI ADI VE ŞİFRE HATALI");
            }
            else if (textBox1.Text != "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("KULLANICI ADI HATALI");
            }
            else if (textBox1.Text == "admin" && textBox2.Text != "admin")
            {
                MessageBox.Show(" ŞİFRE HATALI");
            }
        }
        }
    }

