using System.Security.Cryptography.X509Certificates;

namespace Text_Adventure
{
    internal class Program
    {
        static bool isDev = false;
        static int rInt;
        static int lineDelay = 500;

        /// <summary>
        /// this both types words letter by letter but doesn't starts the next line 
        /// </summary>
        /// <param name="line">The text your going to display</param>
        /// <param name="delay">The time between each key type </param>
        static void Type(string line, int delay = 50)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                Thread.Sleep(delay); // Sleep for 150 milliseconds
            }
        }


        /// <summary>
        /// this both types words letter by letter and starts the next line 
        /// </summary>
        /// <param name="line">The text your going to display</param>
        /// <param name="delay">The time between each key type </param>
        static void TypeLine(string line, int delay = 50, int lineDelay = 250)
        {
            Type(line, delay);
            Console.WriteLine();
            Thread.Sleep(lineDelay);
        }

        static int GetR()
        {
            Random r = new Random();
            if (!isDev)
            {
                return r.Next(60, 110);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// this is like the main code part
        /// </summary>
        /// <param name="args">I don't know what args are </param>
        static void Main(string[] args)
        {
            // set random text speed
            rInt = GetR(); // get a new random number

            TypeLine("What is your name", rInt);

            //ask name of character
            string playerName = Console.ReadLine();


            //Dev Mode (Make text immediate)
            if (playerName == "Dev")
            {
                isDev = true;
                lineDelay = 0;
                rInt = 0;
            }


            TypeLine("Hello " + playerName + " welcome to Sno-isle a place trying so hard to keep a superficial stabilty only mimicing that of pre-pandemic", GetR());
            Console.Clear();

            Console.Beep(800, 500);

            Thread.Sleep(700);

            TypeLine("You have mail", GetR());


            Console.Beep(800, 500);






            //test code
            {
                //TypeLine("This is how i type is  it normal or to fast or too slow\r\n", GetR());
                //Console.WriteLine(rInt);

                //TypeLine("This is how i type is  it normal or to fast or too slow\r\n", GetR());
                //Console.WriteLine(rInt);

                //TypeLine("This is how i type is  it normal or to fast or too slow\r\n", GetR());
                //Console.WriteLine(rInt);

                //TypeLine("This is how i type is  it normal or to fast or too slow\r\n", GetR());
                //Console.WriteLine(rInt);
            }

            //example code
            {
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
            }

            //make it so game doesn't just close on end
            Console.ReadKey();
        }        
    }
}
