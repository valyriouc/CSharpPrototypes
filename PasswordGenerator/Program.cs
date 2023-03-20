using System;
using System.Text;

namespace PasswordGenerator
{
    internal static class Program
    {

        public static void Main()
        {
            var password = GeneratePassword();
            Console.WriteLine(password);
        }

        public static string GeneratePassword()
        {
            int length = 12;
            Random rand = new Random();
            StringBuilder builder = new StringBuilder();
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_,\\/{}[]()/%&!?+*~#";

            for (int i = 0; i < length; i += 4)
            {
                List<char> letters = new List<char>()
                {
                    characters[rand.Next(0, 26)],
                    characters[rand.Next(26, 52)],
                    characters[rand.Next(52, 63)],
                    characters[rand.Next(63, characters.Length)]
                };

                for (int x = 0; x < 4; x++)
                {
                    int first = rand.Next(0, 4);
                    int second = rand.Next(0, 4);

                    char tmp = letters[first];
                    letters[first] = letters[second];
                    letters[second] = tmp;
                }

                if ((i + 4) == length + 1)
                {
                    builder.Append($"{letters[0]}{letters[1]}{letters[2]}");
                }
                else
                {
                    builder.Append($"{letters[0]}{letters[1]}{letters[2]}{letters[3]}");
                }
            }

            return builder.ToString();
        }
    }
}