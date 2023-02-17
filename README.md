# polyaphabetic-vigenere-cipher

__instruction:__
create your own version of encrypting windows files other types of conventional encryption algorithm. do not use *ceasar cipher*.

the code below is the code for encrypting files on windows using *ceasar cipher*.
```
FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate);
int[] temp = new int[fs.Length]; // storage of data of the file

for (int x = 0; x < temp.Length; x++)
{
  temp[x] = fs.ReadByte();
}

fs.Close();

// perform and encyrption scheme on the array of data
// do a ceasar cipher k=3
for (int x = 0; x < temp.Length; x++)
{
  temp[x] += 3;
}

fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate);

for (int x = 0; x < temp.Length; x++)
{
  fs.WriteByte((byte)temp[x]);
}

fs.Close();
```

### text encryption and decryption
before doing file encryption and decryption with vigenere cipher, i first checked if the text encryption is working well.
![text](https://user-images.githubusercontent.com/52037251/218015268-1bf92680-a489-4e5d-8f4e-8a349d9740d1.png)

the image above shows that the encryption and decryption is working well and is ready for file encryption



** encryption 
```
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
```

** decryption
```
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
```

# file encryption
1. encrypt and decrypt text files
2. encrypt images
3. encrypt videos
