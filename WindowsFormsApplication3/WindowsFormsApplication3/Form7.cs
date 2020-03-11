using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public string path = System.IO.Directory.GetCurrentDirectory();
        public DataClasses1DataContext db;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("KULLANICI ADI BOŞ OLAMAZ");
                textBox1.Focus();
                return;

            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("ŞİFRE BOŞ OLAMAZ");
                textBox2.Focus();
                return;

            }
                try
                {
                    kayit uye = new kayit();
                    uye.kuladi = textBox1.Text;
                    uye.sifre = textBox2.Text;
                    db.kayits.InsertOnSubmit(uye);
                    db.SubmitChanges();
                    MessageBox.Show("kayıt başarılı");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

               
           
           



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext(path + "\\hekim2.sdf");
        }
    }
}
