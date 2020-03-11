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
    public partial class Form3 : Form
    {
       
        public Form3()
        {

            InitializeComponent();
        }

        public string path = System.IO.Directory.GetCurrentDirectory();
        public DataClasses1DataContext db; 
        private void button1_Click(object sender, EventArgs e)
        {
            doktor uye = new doktor();
            uye.adi = textBox1.Text;
            uye.soyadi = textBox2.Text;
            uye.tc1 = Convert.ToInt32(textBox3.Text);
            uye.telefon = Convert.ToInt32(textBox4.Text);
            uye.eposta = textBox5.Text;
            uye.cinsiyet = comboBox1.Text;

            db.doktors.InsertOnSubmit(uye);
            db.SubmitChanges();
            MessageBox.Show("DOKTOR KAYIT EDİLDİ");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            Form2.frmAna.comboBox4.Items.Clear();
            var doktorlar = from doktor in db.doktors select doktor.adi;
            foreach (var doktor in doktorlar) Form2.frmAna.comboBox4.Items.Add(doktor);
            



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext(path + "\\hekim2.sdf");
            comboBox1.Items.Add("ERKEK");
            comboBox1.Items.Add("BAYAN");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["cins"].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["adi"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["soyadi"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["tc"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["telefon"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.doktors.OrderByDescending(f => f.tc1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm2 = new Form4();
            frm2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }
    }
}
