using System;
using System.Linq;

namespace GotToChoose
{
    /*
    David och/eller Dimitris
    Alltså. Jag ar inte van vid att göra saker på tid. Just nu går det lite runt i huvudet vad jag skall använda. 
    Måste träna mer på nestlade If-satser och mycket annat. Det kommer. Vet att detta skall inte räcker på långa vägar, 
    så det finns förbättringspotential. Vet att jag skulle lägga methoderna i en separat fil men ville få det att funka först här,
    vilket det inte gör fullt ut som det är nu. Skall fnula mer på detta.
    */

    //Hade ju tänkt använda mig av konstanter på något vis. Se nedan.

    //public class Constants
    //{
    //    public const int youth = 20, seninior = 64;
    //    public const int youths = 90, seniors = 90, adults = 120;
    //}
    class Program
    {
        //private static object s;
        static void Main(string[] args)
        {
            const int youth = 20, seninior = 64;
            const int youths = 90, seniors = 90, adults = 120;
            int youth_sum, senior_sum;
        bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello. You are in control.");
            Console.WriteLine("Menu.");
            Console.WriteLine("=========================");
            Console.WriteLine("Make your choice.");
            Console.WriteLine("0 - End program.");
            Console.WriteLine("1 - To the movies");
            Console.WriteLine("2 - Print random text 10x");
            Console.WriteLine("3 - Extract the third word. ");

            do
            {
                switch (Console.ReadLine())
                 {           
                                case "0":
                                    Environment.Exit(0);
                                    return false;
                                case "1":
                                    ToTheMovies();
                                    return false;
                                case "2":
                                    Repetition();
                                    return false;
                                case "3":
                                    ThirdWord();
                                    return false;
                                default:
                                    return true;
                 }           
            } while (true);
            
        }

       
        public static void ToTheMovies()
        {
           //Selection #1
           Console.Clear();
            int youth_sum, senior_sum;
            int youth = 20, senior = 64, adult;
           int youths = 90, seniors = 90, adults = 120;
        
            Console.WriteLine("Please specify age of your company i.e. ppl younger than 20 and seniors above 64.\n Youths 80 SEK, Seniors 90\n All others 120 SEK.");
            Console.WriteLine("To The Movies.");
            //Console.WriteLine("How big is the crowd?");
            //int crowd = int.Parse(Console.ReadLine());
            Console.WriteLine("How many are younger than 20?");
            int youth_counting = int.Parse(Console.ReadLine());
            Console.WriteLine("How many are older than 64?");
            int senior_counting = int.Parse(Console.ReadLine());
            Console.WriteLine("Adults?");
            int adult_counting = int.Parse(Console.ReadLine());
            
            int crowd = youth_counting + senior_counting + adult_counting;
            Console.WriteLine("People going: " + crowd);


            if (crowd > 0)
            {
                if (youth_counting > 0)
                {

                    youth_sum = youth_counting * youths;
                }

                if (senior_counting > 0)
                {
                    senior_sum = senior_counting * seniors;
                }
            }
        }

        public static void ThirdWord()
        {
            //Selection #3
            //private static object s;
            
            Console.WriteLine("Please enter a short sentence");
            var phrase = Console.ReadLine();
            string[] words = phrase.Split(" ");
            //Array.Sort(words);
            foreach(var s in words)
            {
                Console.WriteLine(s);
                
            }//Console.WriteLine("Third word is: " + s[2]);
            /*Varför säger den att "s" inte finns i kontexten? Har gjort detta i många andra program och 
                                                           det har funkat. Kan ju inte gärna lägga den inuti loopen.*/
            

            
        }
            
        public static void Repetition()
        {
            //Select #2
            Console.WriteLine("Please enter a text of your choice to be repeated 10x");
            var mytext = Console.ReadLine();
            for(int i = 1; i <= 10;i++)
            {
                //mytext = mytext.Replace(Environment.NewLine, "");
                Console.Write(i+"."+mytext+" ");
                //s = s.Replace(Environment.NewLine, " ");
                //string cleaned = example.Replace("\n", "").Replace("\r", "");
            }
        }
    }
}
