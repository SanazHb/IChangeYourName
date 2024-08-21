namespace IChangeYourName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int i;
            for (; ; )
            {
                Console.WriteLine("Enter your name please:");
                name = Console.ReadLine();
                var len = name.Length;
                //reverse
                string reverse = Reverse(name);
                Console.WriteLine(reverse);

                //Changing string to lower case
                for (i = 0; i < len - (len - 1); i++)
                {
                    Console.WriteLine("changed to lower cases:");
                    Console.WriteLine(name.ToLower());
                }
                //changing string to upper case
                Console.WriteLine("Do you want to change it to upper case? answer: yes/no");
                string answer = Console.ReadLine();
                if (answer == "yes" || answer == "YES" || answer == "y" || answer == "Y")
                {
                    for (i = 0; i < len - (len - 1); i++)
                    {
                        Console.WriteLine("changed to upper cases:");
                        Console.WriteLine(name.ToUpper());
                    }
                }
                else
                {
                    Console.WriteLine("It is over!");
                }
                Console.WriteLine("Do you want to play again? answer: yes/no");
                string ans = Console.ReadLine();
                if (ans == "yes" || ans == "YES" || ans == "y" || ans == "Y")
                    continue;
                else
                    break;
            }
            Console.ReadLine();
        }
        static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
