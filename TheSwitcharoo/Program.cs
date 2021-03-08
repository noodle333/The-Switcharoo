using System;

namespace TheSwitcharoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase!");
            string x = Console.ReadLine();

            Console.WriteLine("Your switcharoo phrase is : " + Switcheroo(x));
            Console.ReadLine();
        }

        public static string Switcheroo(string x)
        {
            char[] charArray = x.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'a')
                {
                    charArray[i] = 'b';
                }
                else if (charArray[i] == 'b')
                {
                    charArray[i] = 'a';
                }
            }
            return new string(charArray);
        }
    }
}
