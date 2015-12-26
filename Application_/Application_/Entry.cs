using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_
{
    public class Entry
    {
        public String key {get; set;}
        public String login {get; set;}
        public String comment{get; set;}
        public Entry()
        {
            key = "";
            login = "";
            comment = "";
        }
        public void create(string key_, string log, string com)
        {
            key = key_;
            login = log;
            comment = com;
        }
    }
}
