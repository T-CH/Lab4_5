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
    public partial class Update_Master : Form
    {
        public Update_Master()
        {
            InitializeComponent();
        }
        Master_key master = new Master_key();
        private void button1_Click(object sender, EventArgs e)
        {
            if (master.control(textBox1.Text,master.Load_Pass()) && textBox2.Text == textBox3.Text)
            {
                master.update(textBox3.Text);
            }
            else
            { MessageBox.Show("Ошибка в введенных данных, попробуйте еще раз!"); }
            

        }

       
        
    }
}
