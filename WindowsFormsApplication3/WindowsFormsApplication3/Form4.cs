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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                string path = System.IO.Directory.GetCurrentDirectory();

                DataClasses1DataContext db = new DataClasses1DataContext(path + "\\hekim2.sdf");
                doktor uye = new doktor();
                doktor deneme = db.doktors.First(k => k.tc1 == Convert.ToInt32(textBox1.Text));
                db.doktors.DeleteOnSubmit(deneme);
                db.SubmitChanges();
                MessageBox.Show("KAYIT SİLİNDİ");
            }

            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
