using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.ConstrainedExecution;

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
            /* text encryption code below
             * 
             * StringBuilder s = new StringBuilder(encrypttb.Text);
             string key = keytb.Text;

             vigenereencrypt(ref s, key);
             ciphertb.Text = Convert.ToString(s);*/

            openFileDialog1.ShowDialog();
        }

        private void decryptb_Click(object sender, EventArgs e)
        {
            /*StringBuilder s = new StringBuilder(foldertb.Text);
            string key = keytb.Text;

            vigeneredecrypt(ref s, key);
            *//*plaintexttb.Text = Convert.ToString(s).ToLower();*/

            saveFileDialog1.ShowDialog();
        }

        private void vigenerecipher_Load(object sender, EventArgs e)
        {

        }

        private void keyl_Click(object sender, EventArgs e)
        {

        }

        private void keytb_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate);
            char[] key = keytb.Text.ToCharArray();
            int[] temp = new int[fs.Length];

            for (int x = 0; x < fs.Length; x++)
            {
                temp[x] = fs.ReadByte();
            }
            fs.Close();

            // polyalphabetic - vigenere encryption
            fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate);
            int j = 0;

            for (int i = 0; i < fs.Length; i++)
            {
                int x = 0; 

                while (i % 2 == 0)
                {
                    temp[x] = temp[i];
                    x++;
                }

                while (i % 2 != 0)
                {
                    temp[x] = temp[i];
                    x++;
                }

                /*int keyindex = j++ % key.Length;
                int x = key[keyindex] - 'a';
                int y = ((temp[i] - 'a' + 1) + x) % 26;
                temp[i] = (char)(y + 'a' - 1);  // cipher

                // since z goes -> `
                if (temp[i] == '`')
                    temp[i] = 'z';  */

                fs.WriteByte((byte)temp[x]);
            }
            fs.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
            char[] key = keytb.Text.ToCharArray();
            int[] temp = new int[fs.Length];

            for (int x = 0; x < fs.Length; x++)
            {
                temp[x] = fs.ReadByte();
            }
            fs.Close();

            // polyalphabetic - vigenere encryption
            int j = 0;

            fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);

            for (int i = 0; i < fs.Length; i++)
            {
                // plaintext received
                int x = (temp[i] - 'a') - ((key[j++] - 'a') - 1);

                j %= key.Length;

                if (x <= 0)
                    x += 26;

                temp[i] = (x %= 26) + 96;

                fs.WriteByte((byte)(temp[i]));
            }

            fs.Close();
        }
    }
}
