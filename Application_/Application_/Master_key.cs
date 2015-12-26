using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Application_
{
    public class Master_key
    {
       public int cipher;
        public string Load_Pass()
        {
            string mas_key = "";
            StreamReader sr = new StreamReader("mas.txt");
            mas_key = sr.ReadToEnd();
            sr.Close();
            return mas_key;
        }
        public bool control(String k1, string mas_key)
        {
           /* Random rand = new Random();
            if (k1 == mas_key)
                cipher = 7;
            else cipher = rand.Next(8, 17);*/
            return k1 == mas_key;
        }
        public void update(string key)
        {
            StreamWriter sw = new StreamWriter("mas.txt");
            sw.Write(key);
            sw.Close();
        }
    }
}
