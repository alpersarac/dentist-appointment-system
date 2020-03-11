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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Boş değer girilmesini engelliyoruz.
            if (String.IsNullOrWhiteSpace(textBox1.Text) ||
                String.IsNullOrWhiteSpace(textBox2.Text)) 
            {
                MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", "HATA",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory();
       
                DataClasses1DataContext db = new DataClasses1DataContext(path+"\\hekim2.sdf");
                bool kayitli = db.kayits.Any(k => 
                    k.kuladi.ToLower() == textBox1.Text.ToLower() && 
                    k.sifre == textBox2.Text);

                if (kayitli)
                {
                    MessageBox.Show("Hoşgeldin " + textBox1.Text);
                    Form2 frm2 = new Form2();
                    frm2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Veritabanında böyle bir kullanıcı bulunamadı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        


        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=hekim1;Integrated Security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO giris (kuladi,sifre) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Tamamlanmıştır");
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yENİKAYITOLUŞTURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm2 = new Form5();
            frm2.Show();
        }

        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frm2 = new Form9();
            frm2.ShowDialog();
        }

        private void şİFREDEĞİŞTİRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 frm2 = new Form10();
            frm2.ShowDialog();
        }
    }
}
