using System;
using System.Text;

namespace PW23
{
    class CaesarCipher
    {
        private readonly string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private readonly int shift;

        public CaesarCipher(int shift)
        {
            this.shift = shift % 32;
        }

        public string Encrypt(string message)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in message.ToLower())
            {
                int index = alphabet.IndexOf(c);

                if (index == -1)
                {
                    sb.Append(c);
                }
                else
                {
                    int shiftedIndex = (index + shift) % 32;
                    sb.Append(alphabet[shiftedIndex]);
                }
            }

            return sb.ToString();
        }

        public string Decrypt(string message)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in message.ToLower())
            {
                int index = alphabet.IndexOf(c);

                if (index == -1)
                {
                    sb.Append(c);
                }
                else
                {
                    int shiftedIndex = (index - shift + 32) % 32;
                    sb.Append(alphabet[shiftedIndex]);
                }
            }

            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            CaesarCipher cipher = new CaesarCipher(3);

            Console.WriteLine("Введите текст:");
            string originalMessage = Console.ReadLine();

            string encryptedMessage = cipher.Encrypt(originalMessage);
            string decryptedMessage = cipher.Decrypt(encryptedMessage);

            Console.WriteLine($"Зашифроврованный вид: {encryptedMessage}");
            Console.WriteLine($"Расшифроврованный вид: {decryptedMessage}");
        }
    }
}
