using System.Security.Cryptography.X509Certificates;

namespace Text_Adventure
{
    internal class Program
    {
        public string playerName ;
        static void TypeLine(string line, int delay = 50)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                Thread.Sleep(delay); // Sleep for 150 milliseconds
            }
        }

        //static void TypeLine(string line, int delay = 50)
        //{
        //    for (int i = 0; i < line.Length; i++)
        //    {
        //        Console.Write(line[i]);
        //        Thread.Sleep(delay); // Sleep for 150 milliseconds
        //    }
        //}



        static void Main(string[] args)
        {
            Random r = new Random();
            int rInt = r.Next(60,110);


            TypeLine("This is how i type is  it normal or to fast or too slow\r\n", rInt);
            Console.WriteLine(rInt);

            rInt = r.Next(60,110);
            TypeLine("This is how i type is  it normal or to fast or too slow\r\n", rInt);
            Console.WriteLine(rInt);

            rInt = r.Next(60,110);
            TypeLine("This is how i type is  it normal or to fast or too slow\r\n", rInt);
            Console.WriteLine(rInt);

            rInt = r.Next(60,110);
            TypeLine("This is how i type is  it normal or to fast or too slow\r\n", rInt);
            Console.WriteLine(rInt);

            rInt = r.Next(60,110);
            TypeLine("This is how i type is  it normal or to fast or too slow\r\n", rInt);
            Console.WriteLine(rInt);



            //Console.WriteLine("What is Your Name");
            //string playerName = Console.ReadLine();
            //Console.WriteLine("why " + playerName);

            //Console.WriteLine("\r\nI will take over this dying world");
            //Console.WriteLine("Will you struggle or die");


            string input = Console.ReadLine();
            if (input == "Yes" || input == "Y" || input == "yes" || input == "YES" || input == "y")
            {
                Console.WriteLine("Lame");
            }
            else if (input.ToUpper() == "NO" || input.ToUpper() == "N")
            {
                Console.WriteLine("Dude y");
            }
            else
            {
                Console.WriteLine("tank");
            }
            Console.ReadKey();
        }
        

    }
}
