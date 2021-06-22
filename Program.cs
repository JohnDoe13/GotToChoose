using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace GotToChoose
{
    /*
    David och/eller Dimitris
    Alltså. Jag ar inte van vid att göra saker på tid. Just nu går det lite runt i huvudet vad jag skall använda. 
    Måste träna mer på nestlade If-satser och mycket annat. Det kommer. Vet att detta inte räcker på långa vägar, 
    så det finns förbättringspotential. Vet att jag skulle lägga methoderna i en separat fil men ville få det att funka först här,
    vilket det inte gör fullt ut som det är nu. Skall fnula mer på detta vid tillfälle.
    */

    //Hade ju tänkt använda mig av konstanter på något vis. Se nedan.

    
    class Program
    {
        //private static object s;

        public static void Main(string[] args)
        {
            

            {
                Console.WriteLine("Welcome to the Movies Inc.");
                Console.WriteLine("Press Y(es) or N(o) to continue.");
                string yesorno = Console.ReadLine();
                if (yesorno=="Y" || yesorno=="y")
                {
                    MainMenu();
                }
                else
                {
                    Environment.Exit(0);
                }
            }



        }


        public static void MainMenu()
        {
            do
            {

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Hello. You are in control.");
            Console.WriteLine("Menu.");
            Console.WriteLine("=========================");
            Console.WriteLine("Make your choice.");
            Console.WriteLine("0 - End program or continue.");
            Console.WriteLine("1 - To the movies");
            Console.WriteLine("2 - Print random text 10x");
            Console.WriteLine("3 - Extract the third word. ");

            switch (Console.ReadLine())
            {
                    case "0":
                        Environment.Exit(0);
                        break;
                case "1":
                    ToTheMovies();
                    break;
                case "2":
                    Repetition();
                    break;
                case "3":
                    ThirdWord();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            } while (true);
        }

    

        public static void ToTheMovies()
        {
           //Selection #1
           Console.Clear();
            int youth_sum, senior_sum;
            int youth = 20, senior = 64, adult;
           int youths = 90, seniors = 75, adults = 120;
        
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
            Console.WriteLine("Total amount: "+ ((youth_counting*youths)+(senior_counting*seniors)+(adult_counting*adults)));
            Console.WriteLine("Type 0 (zero) to continue.");


            
        }

        public static void ThirdWord()
        {
            //Selection #3
            //private static object s;
            
            Console.WriteLine("Please enter a short sentence");
            var phrase = Console.ReadLine();
            string[] words = phrase.Split(" ");
            //Array.Sort(words);
            foreach(string s in words)
            
            {
                Console.Write(s);
                
            }

            //Validation starts here. I guess you can reverse the order of the If-statement to come before the foreach.
            
            if (phrase.Length <= 2)
            {
                Console.WriteLine("Sentence must be more than three words");
                MainMenu();

            } else
            {
                try
                {
                    Console.Write("\nThird word is: " + words[2]);
                }

                catch (Exception e)
                {
                    Console.WriteLine("\n"+e.Message);
                }

                    
            }
            
            Console.WriteLine("\n" + "\nType c (letter c) to continue.");
            



        }
        
        
        public static void Repetition()
        {
            //Select #2
            //I think the first CW is quite selfexplanatory.
            Console.WriteLine("Please enter a text of your choice to be repeated 10x");
            var mytext = Console.ReadLine();
            for(int i = 1; i <= 10;i++)
            {
                //mytext = mytext.Replace(Environment.NewLine, "");
                Console.Write(i+"."+mytext+" ");
                //s = s.Replace(Environment.NewLine, " ");
                //string cleaned = example.Replace("\n", "").Replace("\r", "");
            }
            Console.WriteLine("\n"+"\nType c (letter c) to continue.");
        }
    }
}
