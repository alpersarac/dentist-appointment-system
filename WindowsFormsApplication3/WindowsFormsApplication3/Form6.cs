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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public string path = System.IO.Directory.GetCurrentDirectory();
        public DataClasses1DataContext db;


        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
	{
		 bilgiler uye = new bilgiler();
            bilgiler deneme = db.bilgilers.First(k => k.tc ==  Convert.ToInt32(textBox1.Text));
            db.bilgilers.DeleteOnSubmit(deneme);
            db.SubmitChanges();
            MessageBox.Show("İPTAL EDİLDİ");
	}
          
          
            
            
        
           


            /*/DataClasses1DataContext dc = new DataClasses1DataContext();
            kitapbilgisi kitap = dc.kitapbilgisis.First(k => k.id == 9);
            dc.kitapbilgisis.DeleteOnSubmit(kitap);
            dc.SubmitChanges(); /*/

         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext(path+"\\hekim2.sdf");
        } // sh'tf ve alt tu;larina birlikte basabilirmisin
    }
}
