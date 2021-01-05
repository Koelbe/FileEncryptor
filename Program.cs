using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace FileEncryptor
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Select the file you would like to encrypt or decrypt.");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            OpenFileDialog fileDialog = new OpenFileDialog();

            if(fileDialog.ShowDialog() == DialogResult.OK) 
            {
                var fs = fileDialog.OpenFile();
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("File Selected: {0}",fileDialog.FileName);
                Console.WriteLine();
                string input = "";
                while (true) 
                {
                    Console.Write("Would you like to encrypt/decrypt: ");
                    input = Console.ReadLine();
                    input.ToLower();
                    if(input == "encrypt") { break; }
                    if(input == "decrypt") { break; }
                }

                if (input == "encrypt")
                {
                    Console.WriteLine("You chose ENCRYPT");
                    Console.Write("Encryption password: ");
                    string encryptionPassword = Console.ReadLine();
                    string encryptedString = encryptStringWithPassword(encryptionPassword);//RETURNS NULL, NOT IMPLEMENTED
                }

                if (input == "decrypt")
                {
                    Console.WriteLine("You chose DECRYPT");
                    Console.Write("Decryption password: ");
                    string decryptionPassword = Console.ReadLine();
                    string decryptedString = decryptStringWithPassword(decryptionPassword);//RETURNS NULL, NOT IMPLEMENTED
                }

                Console.ReadKey();
            }

            string encryptStringWithPassword(string password)//NEEDS FLESHED OUT
            {
                Console.WriteLine("DID NOT ENCRYPT FILE, CODE NEEDS IMPLEMENTED");
                return null;
            }

            string decryptStringWithPassword(string password)//NEEDS FLESHED OUT
            {
                Console.WriteLine("DID NOT DECRYPT FILE, CODE NEEDS IMPLEMENTED");
                return null;
            }


        }
    }
}
