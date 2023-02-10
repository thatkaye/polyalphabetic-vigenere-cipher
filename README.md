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
