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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == textBox3.Text.Trim())
            {
                MessageBox.Show("ŞİFRELER UYUŞMUYOR");
                textBox2.Focus();
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=hekim1;Integrated Security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update giris Set sifre=@sifre Where kuladi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", con);
            cmd.Parameters.AddWithValue("@sifre", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ŞİFRENİZ DEĞİŞTİRİLDİ");

        }
    }
}
