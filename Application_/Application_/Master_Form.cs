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
    public partial class Master_Form : Form
    {
        public Master_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Master_key m_key=new Master_key();
            
            Random rand=new Random();
            Main_Form f = new Main_Form();
            if (m_key.control(textBox1.Text,m_key.Load_Pass()))
            {
                /*Main_Form f = new Main_Form();
                this.Hide();
                f.Show(this);*/
                f.cipher__ = 7;
               //m_key.cipher = 7;
            }
            else
            {
               /* MessageBox.Show("Введённый пароль неверен!!\nПопробуйте ещё раз.");
                    textBox1.Text="";*/
                //m_key.cipher = 
                    f.cipher__=rand.Next(8, 17);
            }
            
            
            this.Hide();
            f.Show(this);
        }

        private void Master_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
