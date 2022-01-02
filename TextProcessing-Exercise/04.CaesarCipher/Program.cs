using System;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            StringBuilder decryptedMessage = new StringBuilder();

            foreach (char letter in encryptedMessage)
            {
                decryptedMessage.Append((char)(letter + 3));
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
