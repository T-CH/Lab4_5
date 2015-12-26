using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Application_
{
    public abstract class RepositoryInterface
    {
        public RepositoryInterface()
        {

        }
        public abstract void add(Entry x);
        public abstract void remove(Entry x, int id);
        public abstract void update(Entry x, int id);

    }
    public class BDRepository : RepositoryInterface
    {
        private string ConnectionString = @"Data Source=TCH\SQLEXPRESS;Initial Catalog=Passw;Integrated Security=True";        
        public BDRepository() {  }
        public override void add(Entry x)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(string.Format(@"insert into Passwords(keys,logins,comments) values('{0}','{1}','{2}')",
                                                          x.key, x.login, x.comment), con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            con.Close();
        }
        public override void remove(Entry x, int id)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(string.Format(@"delete from Passwords where 
                                                id={0}", id), con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }            
            con.Close();

        }
        public override void update(Entry x,int id)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();            
            SqlCommand cmd = new SqlCommand(string.Format(@"update Passwords set keys='{0}', logins='{1}', comments='{2}'
                where id={3}",
                x.key,x.login,x.comment, id), con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            con.Close();
        }
        public void LoadPassw(DataGridView dataGridView1)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
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
            //dataGridView1.Columns[0].Visible = false;
        }

    }
}
