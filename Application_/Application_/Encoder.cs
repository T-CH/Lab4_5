using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Application_
{
    public class Encoder
    {
        
        
        public Entry encode(Entry x, int cipher)
        {
            //cipher = m_key.cipher;
            string s = "";
            int k;
            for (int i = 0; i < x.key.Length; i++)
            {
                k = (int)x.key[i] + cipher;
                s += (char)k;
            }
            x.key = s;
            s = "";
            for (int i = 0; i < x.comment.Length; i++)
            {
                k = (int)x.comment[i] + cipher;
                s += (char)k;
            }
            x.comment = s;
            return x;
        }
        public Entry decode(Entry x, int cipher)
        {
            //cipher = m_key.cipher;
            string s = "";
            int k;
            for (int i = 0; i < x.key.Length; i++)
            {
                k = (int)x.key[i] - cipher;
                s += (char)k;
            }
            x.key = s;
            s = "";
            for (int i = 0; i < x.comment.Length; i++)
            {
                k = (int)x.comment[i] - cipher;
                s += (char)k;
            }
            x.comment = s;
            return x;
        }
    }
}
