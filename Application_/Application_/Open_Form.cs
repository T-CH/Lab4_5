using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_
{
    public partial class Open_Form : Form        
    {        
        public Open_Form()
        {
            InitializeComponent();           
        }   
        public Entry entry1 = new Entry();
        BDRepository Repos = new BDRepository();
        public int number;
        public int cipher;
        Encoder encod = new Encoder();
        private void Load_entry()
        {
            textBox7.Text = number.ToString();
            textBox4.Text =  entry1.key;
            textBox5.Text = entry1.login;
            textBox6.Text = entry1.comment;
        }
        private void button1_Click(object sender, EventArgs e)//изменить
        {
            entry1.create(textBox4.Text,textBox5.Text,textBox6.Text);
            encod.encode(entry1,cipher);
            Repos.update(entry1, Convert.ToInt32(textBox7.Text));
            /*textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";*/
            /*Main_Form mf = new Main_Form();
            mf.UPDATE_();*/
            this.Close();
        }       
        private void Open_Form_Load(object sender, EventArgs e)
        {
            Load_entry();
        }
    }
}
