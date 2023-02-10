using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vigenere_cipher
{
    public partial class vigenerecipher : Form
    {
        public vigenerecipher()
        {
            InitializeComponent();
        }

        public void vigenereencrypt(ref StringBuilder s, string key)
        {
            for(int i = 0; i < s.Length; i++) 
                s[i] = char.ToUpper(s[i]);
            
            key = key.ToUpper();
            int j = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i])) // checks if char is a unicode char
                { 
                    s[i] = (char)(s[i] + key[j] - 'A');

                    if (s[i] > 'Z')
                        s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                }

                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }

        public void vigeneredecrypt(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++)
                s[i] = char.ToUpper(s[i]);

            key = key.ToUpper();
            int j = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = s[i] >= key[j] ?
                        (char)(s[i] - key[j] + 'A') :
                        (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                }

                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }

        private void encryptb_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(encrypttb.Text);
            string key = keytb.Text;
            
            vigenereencrypt(ref s, key);
            ciphertb.Text = Convert.ToString(s);
        }

        private void decryptb_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(ciphertexttb.Text);
            string key = keydtb.Text;

            vigeneredecrypt(ref s, key);
            plaintexttb.Text = Convert.ToString(s).ToLower();
        }
    }
}
