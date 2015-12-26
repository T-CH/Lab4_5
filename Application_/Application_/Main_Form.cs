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
    public partial class Main_Form : Form
    {
        public int cipher__;
        BDRepository Repos = new BDRepository();
        Entry entry = new Entry();
        Encoder encod = new Encoder();
        public Main_Form()
        {
            InitializeComponent();
            UPDATE_();
        }
        public void UPDATE_()
        {
            Repos.LoadPassw(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }    
        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)//добавить
        {
            entry.create(dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[3].Value.ToString());
            encod.encode(entry,cipher__);
            Repos.add(entry);
            UPDATE_();
        }

        private void button3_Click(object sender, EventArgs e)//просмотр пароля
        {          
            entry.create(dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[3].Value.ToString());
            Open_Form ff = new Open_Form();
            ff.number = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ff.cipher = cipher__;
            encod.decode(entry,cipher__);
            ff.entry1 = entry;
            ff.Show();
            UPDATE_();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Master ff = new Update_Master();
            ff.Show();
        }

        private void button4_Click(object sender, EventArgs e)//удалить
        {
            entry.create(dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[3].Value.ToString());
            Repos.remove(entry, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            UPDATE_();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UPDATE_();
        }
        /*private void LoadPassw()
        {
            string ConString = @"Data Source=TCH\SQLEXPRESS;Initial Catalog=Passw;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(string.Format(@"select * from Passwords"), con);
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("keys", "Ключ");
            dataGridView1.Columns.Add("logins", "Логин");
            dataGridView1.Columns.Add("comments", "Комментарий");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["id"].ToString(), reader["keys"].ToString(),
                    reader["logins"].ToString(), reader["comments"].ToString());
            }
            reader.Close();
            dataGridView1.Columns[0].Visible = false;
        }*/

    }
}
