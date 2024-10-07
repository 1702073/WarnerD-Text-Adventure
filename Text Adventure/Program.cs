using System.Security.Cryptography.X509Certificates;

namespace Text_Adventure
{
    internal class Program
    {
        static void TypeLine(string line, int delay = 50)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                Thread.Sleep(delay); // Sleep for 150 milliseconds
            }
        }
        static void Main(string[] args)
        {

            Random r = new Random();
            int rInt = r.Next(9000, 10000);

            TypeLine("tamriel\r\n", rInt);
            Console.WriteLine(rInt);
            TypeLine("tamriel\r\n", rInt);
            rInt = r.Next(0, 10);
            Console.WriteLine(rInt);

            //Console.WriteLine("What is Your Name");
            //string playerName = Console.ReadLine();
            //Console.WriteLine("why " + playerName);

            //Console.WriteLine("\r\nI will take over this dying world");
            //Console.WriteLine("Will you struggle or die");


            //string input = Console.ReadLine();
            //if (input == "Yes" || input == "Y" || input == "yes" || input == "YES" || input == "y")
            //{
            //    Console.WriteLine("Lame");
            //}
            //else if (input.ToUpper() == "NO" || input.ToUpper() == "N")
            //{
            //    Console.WriteLine("Dude y");
            //}
            //else
            //{
            //    Console.WriteLine("tank");
            //}
            Console.ReadKey();
        }
        

    }
}
