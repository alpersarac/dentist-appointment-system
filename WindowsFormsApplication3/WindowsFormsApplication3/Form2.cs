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
    public partial class Form2 : Form
    {
        public static Form2 frmAna;
        public Form2()
        {
            InitializeComponent();
            frmAna = this;

        }
        public string path = System.IO.Directory.GetCurrentDirectory();
        public DataClasses1DataContext db;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {





            db = new DataClasses1DataContext(path + "\\hekim2.sdf");

            ComboBox1.Items.Add("Kanal Tedavisi");

            ComboBox1.Items.Add("Dolgu");

            ComboBox1.Items.Add("Kaplama");

            comboBox2.Items.Add("09:00");
            comboBox2.Items.Add("10:00");
            comboBox2.Items.Add("11:00");
            comboBox2.Items.Add("12:00");
            comboBox2.Items.Add("13:00");
            comboBox2.Items.Add("14:00");
            comboBox2.Items.Add("15:00");
            comboBox2.Items.Add("16:00");
            comboBox2.Items.Add("17:00");

            comboBox3.Items.Add("");
            comboBox3.Items.Add("09:00");
            comboBox3.Items.Add("10:00");
            comboBox3.Items.Add("11:00");
            comboBox3.Items.Add("12:00");
            comboBox3.Items.Add("13:00");
            comboBox3.Items.Add("14:00");
            comboBox3.Items.Add("15:00");
            comboBox3.Items.Add("16:00");
            comboBox3.Items.Add("17:00");
            
               
                
                




            Control ad, soyad, iletisim, dipnot, tc, tarih, saat, tedavi;
            ad = TextBox1;
            soyad = TextBox2;
            iletisim = TextBox3;
            dipnot = TextBox4;
            tc = textBox5;
            tarih = dateTimePicker1;
            saat = comboBox2;
            tedavi = ComboBox1;
            helpProvider1.SetHelpString(ad, "Hasta ad");
            helpProvider1.SetHelpString(soyad, "Hasta soyad");
            helpProvider1.SetHelpString(iletisim, "Hasta iletisim bilgileri");
            helpProvider1.SetHelpString(dipnot, "Özel olarak belirtilen durum");
            helpProvider1.SetHelpString(tc, "Hasta tc kimlik numarasi");
            helpProvider1.SetHelpString(tarih, "Randevu Tarihi");
            helpProvider1.SetHelpString(saat, "Randevu Saati");
            helpProvider1.SetHelpString(tedavi, "tedavi sekli");

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form3 frm2 = new Form3();
            // frm3.ShowDialog();
        }



        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (textBox5.TextLength == 11)
            {
                e.Handled = true;
            }
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }

        }



        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("TC KİMLİK NUMARASI BOŞ OLAMAZ");
                textBox5.Focus();
                return;

            }
            if (TextBox1.Text.Trim() == "")
            {
                MessageBox.Show("AD BOŞ OLAMAZ");
                textBox5.Focus();
                return;

            }

            if (true)
            {

            }


            bilgiler uye = new bilgiler();

            uye.ad = TextBox1.Text;
            uye.soyad = TextBox2.Text;
            uye.ilet = TextBox3.Text;
            uye.dipnot = TextBox4.Text;
            uye.tc = Convert.ToInt32(textBox5.Text);
            uye.tedavi = ComboBox1.Text;
            uye.tarih = dateTimePicker1.Value.Date;
            uye.saat = comboBox2.Text;
            uye.kutu = checkBox1.Checked;
            uye.kutu1 = checkBox2.Checked;
            uye.kutu2 = checkBox3.Checked;
            uye.kutu3 = checkBox4.Checked;
            uye.kutu4 = checkBox5.Checked;
            uye.kutu5 = checkBox6.Checked;
            uye.kutu6 = checkBox7.Checked;
            uye.kutu7 = checkBox8.Checked;
            uye.kutu8 = checkBox9.Checked;
            uye.kutu9 = checkBox10.Checked;
            uye.kutu10 = checkBox11.Checked;
            uye.kutu11 = checkBox12.Checked;
            uye.kutu12 = checkBox13.Checked;
            uye.kutu13 = checkBox14.Checked;
            uye.kutu14 = checkBox15.Checked;
            uye.kutu15 = checkBox16.Checked;
            uye.kutu16 = checkBox17.Checked;
            uye.kutu17 = checkBox18.Checked;
            uye.kutu18 = checkBox19.Checked;
            uye.kutu19 = checkBox20.Checked;
            uye.kutu20 = checkBox21.Checked;
            uye.kutu21 = checkBox22.Checked;
            uye.kutu22 = checkBox23.Checked;
            uye.kutu23 = checkBox24.Checked;
            uye.kutu24 = checkBox25.Checked;
            uye.kutu25 = checkBox26.Checked;
            uye.kutu26 = checkBox27.Checked;
            uye.kutu27 = checkBox28.Checked;
            uye.kutu28 = checkBox29.Checked;
            uye.kutu29 = checkBox30.Checked;
            uye.kutu30 = checkBox31.Checked;
            uye.kutu31 = checkBox32.Checked;





            db.bilgilers.InsertOnSubmit(uye);
            db.SubmitChanges();
            MessageBox.Show("RANDEVU KAYIT EDİLDİ");


            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            textBox5.Clear();
            comboBox4.Items.Clear();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.bilgilers.OrderByDescending(f => f.tc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=hekim1;Integrated Security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE bilgiler1 SET tedavi=@tedavi,adi=@adi,soyadi=@soyadi,ilet=@ilet,dipnot=@dipnot", con);
            cmd.Parameters.AddWithValue("tedavi", ComboBox1.Text);
            cmd.Parameters.AddWithValue("adi", TextBox1.Text);
            cmd.Parameters.AddWithValue("soyadi", TextBox2.Text);
            cmd.Parameters.AddWithValue("ilet", TextBox3.Text);
            cmd.Parameters.AddWithValue("dipnot", TextBox4.Text);
            cmd.Parameters.AddWithValue("tc", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Düzeltilmiştir");
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form6 frm2 = new Form6();
            frm2.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.ShowDialog();

        }

        private void yENİKULLANICIGİRİŞİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }



        private void rANDEVUİPTALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm2 = new Form6();
            frm2.ShowDialog();
        }

        private void dOKTORKAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yENİGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.ShowDialog();
            Close();
        }

        private void rANDEVUİPTALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 frm2 = new Form6();
            frm2.ShowDialog();
        }

        private void dOKTORKAYITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button6_Click_1(object sender, EventArgs e)
        {



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            var kayitlar = db.bilgilers.Where(k => k.ad.StartsWith(textBox6.Text.Trim()));
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }





        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {


                var hasta = ((IEnumerable<bilgiler>)dataGridView1.DataSource).ToArray()[e.RowIndex];
                var hasta2 = ((IEnumerable<doktor>)dataGridView1.DataSource).ToArray()[e.RowIndex];


                if (hasta != null)
                if (hasta2!=null)
                {
                    TextBox1.Text = hasta2.adi;
                    TextBox1.Text = hasta.ad;
                    TextBox2.Text = hasta.soyad;
                    TextBox3.Text = hasta.ilet;
                    TextBox4.Text = hasta.dipnot;
                    dateTimePicker1.Text = Convert.ToString(hasta.tarih);
                    textBox5.Text = Convert.ToString(hasta.tc);
                    ComboBox1.Text = hasta.tedavi;
                    comboBox2.Text = hasta.saat;
                    checkBox1.Checked = hasta.kutu;
                    checkBox2.Checked = hasta.kutu1;
                    checkBox3.Checked = hasta.kutu2;
                    checkBox4.Checked = hasta.kutu3;
                    checkBox5.Checked = hasta.kutu4;
                    checkBox6.Checked = hasta.kutu5;
                    checkBox7.Checked = hasta.kutu6;
                    checkBox8.Checked = hasta.kutu7;
                    checkBox9.Checked = hasta.kutu8;
                    checkBox10.Checked = hasta.kutu9;
                    checkBox11.Checked = hasta.kutu10;
                    checkBox12.Checked = hasta.kutu11;
                    checkBox13.Checked = hasta.kutu12;
                    checkBox14.Checked = hasta.kutu13;
                    checkBox15.Checked = hasta.kutu14;
                    checkBox16.Checked = hasta.kutu15;
                    checkBox17.Checked = hasta.kutu16;
                    checkBox18.Checked = hasta.kutu17;
                    checkBox19.Checked = hasta.kutu18;
                    checkBox20.Checked = hasta.kutu19;
                    checkBox21.Checked = hasta.kutu20;
                    checkBox22.Checked = hasta.kutu21;
                    checkBox23.Checked = hasta.kutu22;
                    checkBox24.Checked = hasta.kutu23;
                    checkBox25.Checked = hasta.kutu24;
                    checkBox26.Checked = hasta.kutu25;
                    checkBox27.Checked = hasta.kutu26;
                    checkBox28.Checked = hasta.kutu27;
                    checkBox29.Checked = hasta.kutu28;
                    checkBox30.Checked = hasta.kutu29;
                    checkBox31.Checked = hasta.kutu30;
                    checkBox32.Checked = hasta.kutu31;

                }



            }



        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Form6 frm2 = new Form6();
            frm2.ShowDialog();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            DataTable dtArananHastaBilgileri = new DataTable();
            dtArananHastaBilgileri.Columns.Add("TC");
            dtArananHastaBilgileri.Columns.Add("Tedavi");
            dtArananHastaBilgileri.Columns.Add("Ad Soyad");
            dtArananHastaBilgileri.Columns.Add("Telefon");
            dtArananHastaBilgileri.Columns.Add("Not");
            dtArananHastaBilgileri.Columns.Add("Tarih");
            dtArananHastaBilgileri.Columns.Add("Saat");
            dtArananHastaBilgileri.Columns.Add("hastaid");
            dtArananHastaBilgileri.Columns.Add("adi");


            var aramasonuc = (from u in db.bilgilers where u.tc == Convert.ToInt32(textBox6.Text) select u);
            foreach (var bilgiler in aramasonuc)
            {
                DataRow dtArananHastaBilgileriSatirlari = dtArananHastaBilgileri.NewRow();

                dtArananHastaBilgileriSatirlari["TC"] = bilgiler.tc;
                dtArananHastaBilgileriSatirlari["Tedavi"] = bilgiler.tedavi;
                dtArananHastaBilgileriSatirlari["Ad Soyad"] = bilgiler.ad + " " + bilgiler.soyad;
                dtArananHastaBilgileriSatirlari["Telefon"] = bilgiler.ilet;
                dtArananHastaBilgileriSatirlari["Not"] = bilgiler.dipnot;
                dtArananHastaBilgileriSatirlari["Tarih"] = bilgiler.tarih;
                dtArananHastaBilgileriSatirlari["Saat"] = bilgiler.saat;
                dtArananHastaBilgileriSatirlari["hastaid"] = bilgiler.hastaid;

                dtArananHastaBilgileri.Rows.Add(dtArananHastaBilgileriSatirlari);

                dataGridView1.DataSource = dtArananHastaBilgileri;
            }
        }

        private void comboBox2_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dtArananHastaBilgileri = new DataTable();
            dtArananHastaBilgileri.Columns.Add("TC");
            dtArananHastaBilgileri.Columns.Add("Tedavi");
            dtArananHastaBilgileri.Columns.Add("Ad Soyad");
            dtArananHastaBilgileri.Columns.Add("Telefon");
            dtArananHastaBilgileri.Columns.Add("Not");
            dtArananHastaBilgileri.Columns.Add("Tarih");
            dtArananHastaBilgileri.Columns.Add("Saat");
            dtArananHastaBilgileri.Columns.Add("hastaid");


            var aramasonuc = (from u in db.bilgilers where u.saat == comboBox3.Text select u);
            foreach (var bilgiler in aramasonuc)
            {
                DataRow dtArananHastaBilgileriSatirlari = dtArananHastaBilgileri.NewRow();

                dtArananHastaBilgileriSatirlari["TC"] = bilgiler.tc;
                dtArananHastaBilgileriSatirlari["Tedavi"] = bilgiler.tedavi;
                dtArananHastaBilgileriSatirlari["Ad Soyad"] = bilgiler.ad + " " + bilgiler.soyad;
                dtArananHastaBilgileriSatirlari["Telefon"] = bilgiler.ilet;
                dtArananHastaBilgileriSatirlari["Not"] = bilgiler.dipnot;
                dtArananHastaBilgileriSatirlari["Tarih"] = bilgiler.tarih;
                dtArananHastaBilgileriSatirlari["Saat"] = bilgiler.saat;
                dtArananHastaBilgileriSatirlari["hastaid"] = bilgiler.hastaid;

                dtArananHastaBilgileri.Rows.Add(dtArananHastaBilgileriSatirlari);

                dataGridView1.DataSource = dtArananHastaBilgileri;
            }


        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dtArananHastaBilgileri = new DataTable();
            dtArananHastaBilgileri.Columns.Add("TC");
            dtArananHastaBilgileri.Columns.Add("Tedavi");
            dtArananHastaBilgileri.Columns.Add("Ad Soyad");
            dtArananHastaBilgileri.Columns.Add("Telefon");
            dtArananHastaBilgileri.Columns.Add("Not");
            dtArananHastaBilgileri.Columns.Add("Tarih");
            dtArananHastaBilgileri.Columns.Add("Saat");
            dtArananHastaBilgileri.Columns.Add("hastaid");


            var aramasonuc = (from u in db.bilgilers where u.tarih == dateTimePicker1.Value.Date select u);
            foreach (var bilgiler in aramasonuc)
            {
                DataRow dtArananHastaBilgileriSatirlari = dtArananHastaBilgileri.NewRow();

                dtArananHastaBilgileriSatirlari["TC"] = bilgiler.tc;
                dtArananHastaBilgileriSatirlari["Tedavi"] = bilgiler.tedavi;
                dtArananHastaBilgileriSatirlari["Ad Soyad"] = bilgiler.ad + " " + bilgiler.soyad;
                dtArananHastaBilgileriSatirlari["Telefon"] = bilgiler.ilet;
                dtArananHastaBilgileriSatirlari["Not"] = bilgiler.dipnot;
                dtArananHastaBilgileriSatirlari["Tarih"] = bilgiler.tarih;
                dtArananHastaBilgileriSatirlari["Saat"] = bilgiler.saat;
                dtArananHastaBilgileriSatirlari["hastaid"] = bilgiler.hastaid;

                dtArananHastaBilgileri.Rows.Add(dtArananHastaBilgileriSatirlari);

                dataGridView1.DataSource = dtArananHastaBilgileri;
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            textBox5.Clear();
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void yENİGİRİŞToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Form1 frm2 = new Form1();
            frm2.ShowDialog();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            comboBox4.Refresh();
        }

        private void rANDEVUİPTALToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form6 frm2 = new Form6();
            frm2.ShowDialog();
        }

        private void dOKTORKAYITToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.ShowDialog();
        }

        private void çIKIŞToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void aRKAPLANRENGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void yAZIRENKLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label10.BackColor = colorDialog1.Color;
            Label1.BackColor = colorDialog1.Color;
            Label2.BackColor = colorDialog1.Color;
            Label3.BackColor = colorDialog1.Color;
            Label4.BackColor = colorDialog1.Color;
            label7.BackColor = colorDialog1.Color;
            Label6.BackColor = colorDialog1.Color;
            label7.BackColor = colorDialog1.Color;
            label8.BackColor = colorDialog1.Color;
            label9.BackColor = colorDialog1.Color;
            label11.BackColor = colorDialog1.Color;
            label12.BackColor = colorDialog1.Color;
            label5.BackColor = colorDialog1.Color;
        }

       

       

        

        
       
    }
}



