using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;


/*
TODO: Finish meaning class
TODO: Clean more stuff
*/

namespace datingpredic_updated
{
    public class Program
    {

        public class def {
            public static string gender;
            public static string finalGender;
        }
        static void Main(string[] args)
        {
            //* New sub-classes
            var gCheck = new gender_check();
            user user = new user();
            crush crush = new crush();
            Person Boy = new Person();
            Person Girl = new Person();
            var perc = new predictions();
            def d = new def();
            string url = "https://en.wikipedia.org/wiki/Big_Five_personality_traits#Descriptions_of_the_particular_personality_traits";

            //* Actual program starts here
            Console.Title = "Dating Predictions by AmirulDevKun";
            String asciiArt = @"
                                
██████╗░░█████╗░████████╗██╗███╗░░██╗░██████╗░
██╔══██╗██╔══██╗╚══██╔══╝██║████╗░██║██╔════╝░
██║░░██║███████║░░░██║░░░██║██╔██╗██║██║░░██╗░
██║░░██║██╔══██║░░░██║░░░██║██║╚████║██║░░╚██╗
██████╔╝██║░░██║░░░██║░░░██║██║░╚███║╚██████╔╝
╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝░╚═════╝░

██████╗░██████╗░███████╗██████╗░██╗░█████╗░████████╗██╗░█████╗░███╗░░██╗░██████╗
██╔══██╗██╔══██╗██╔════╝██╔══██╗██║██╔══██╗╚══██╔══╝██║██╔══██╗████╗░██║██╔════╝
██████╔╝██████╔╝█████╗░░██║░░██║██║██║░░╚═╝░░░██║░░░██║██║░░██║██╔██╗██║╚█████╗░
██╔═══╝░██╔══██╗██╔══╝░░██║░░██║██║██║░░██╗░░░██║░░░██║██║░░██║██║╚████║░╚═══██╗
██║░░░░░██║░░██║███████╗██████╔╝██║╚█████╔╝░░░██║░░░██║╚█████╔╝██║░╚███║██████╔╝
╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═════╝░╚═╝░╚════╝░░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚══╝╚═════╝░

by AmirulDevKun
                ";

            //ScriptAnim();

            //* Prompt for opening personality refrences / definitions.
            
            void personaResource(string url)
            {
                if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    Process.Start(new ProcessStartInfo(url));
            }
            
            Console.Write("Do you want to refer the personality resources used? : ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "y":
                    personaResource(url);
                    break;
                case "yes":
                    personaResource(url);
                    break;
                case "Yes":
                    personaResource(url);
                    break;
                default:
                    break;
            }
            Console.Clear();

            Console.WriteLine(asciiArt);
            gCheck.check();

            // Console.Write("Enter your gender : ");
            // def.gender = Console.ReadLine();
            // Console.WriteLine();
            // while (string.IsNullOrEmpty(def.gender)) {
            //     Console.WriteLine();
            //     Console.WriteLine("Gender cant be empty. Please re-enter your gender");
            //     def.gender = Console.ReadLine();
            // }


            // switch (def.gender) {
            //     case "boy":
            //     def.finalGender = "boy";
            //     break;

            //     case "man":
            //     def.finalGender = "boy";
            //     break;

            //     case "girl":
            //     def.finalGender = "girl";
            //     break;

            //     case "woman":
            //     def.finalGender = "girl";
            //     break;

            //     default:
            //     Console.WriteLine("This script has ended. Please press any key to exit");
            //     Console.ReadLine();
            //     System.Environment.Exit(0);

            //     // if(def.gender != "boy") {
            //     //     if(def.gender != "man"){
            //     //         if(def.gender != "girl"){
            //     //             if(def.gender != "woman"){
            //     //                 Console.Write("Unrecognizeable gender. Please Reinput: ");
            //     //                 def.gender = Console.ReadLine();
            //     //             }
            //     //         }
            //     //     }
            //     // }
            //     break;
            // }
            
            //* not useable because it can be skipped and a bug where
            //* the str_personality thing will not print the dedicated personality
            //
            // if (def.gender == "boy" || def.gender == "man")
            // {
            //     def.finalGender = "boy";
            // }
            // else if (def.gender == "girl" || def.gender == "woman")
            // {
            //     def.finalGender = "girl";
            // }
            // else {
            //     Console.WriteLine("Gender Input Wrong. Please Put it again");
            //     def.gender = Console.ReadLine();
            // }

            user.check();
            crush.check();
            //perc.lazyPrint();
            Console.WriteLine("The script has ended. Press any key to end the session.");
            Console.ReadKey();
            //EndScriptAnim();

        }
        private static void ScriptAnim() {
            Console.WriteLine("Loading the script...");
            using (var progress = new ProgressBar()) {
                for (int i = 0; i < 100; i++) {
                    progress.Report((double)i / 100);
                    System.Threading.Thread.Sleep(100);
                }
            }
            Console.Clear();
            Console.WriteLine("Script loaded.");
        }

        private static void EndScriptAnim() {
            Console.Clear();
            Console.WriteLine("Unloading script...");
            using (var progress = new ProgressBar()) {
                for (int i = 0; i < 100; i++) {
                    progress.Report((double)i / 50);
                    System.Threading.Thread.Sleep(50);
                }
            }
            // Console.Clear();
            // Console.WriteLine("Script loaded.");
        }
    }

    class Person { //! FIXED CLASS
        public string name;
        public int age;
        public int personality;
        public string str_personality;
        public string gender;

        public Person() {
            name = "";
            age = 0;
            personality = 0;
            gender = "";
            str_personality = "";
        }

        // public void personality_check(string personality) {
        //     Person Boy = new Person();
        //     Person Girl = new Person();

        //     Console.Write("Enter your personality here: ");
        //     Console.ReadLine();
        //     Console.WriteLine();

        // }
    }
    class user { //! ADDING NEW FUNCTIONS

        public void check() {
            Person Boy = new Person();
            Person Girl = new Person();
            var perc = new predictions();
            Program.def d = new Program.def();
            if (Program.def.finalGender == "boy") {
                //* This part is pretty complicated... OH WHO AM I KIDDING!

                Console.Write("Enter your name in : ");
                Boy.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(Boy.name)) { //? This checks if the input is empty. If it is empty,
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your name");//? Then it spits out an error
                    Boy.name = Console.ReadLine();//? Reprompt the input
                }

                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out Boy.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your age.");
                    ageAsString = Console.ReadLine();
                }

                perc.lazyPrint();
                Console.Write("Enter your personality here : ");
                var personaAsStr = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(personaAsStr, out Boy.personality)) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your personality.");
                    personaAsStr = Console.ReadLine();
                }
                switch (Boy.personality) {
                    case 1:
                        Boy.str_personality = "Openness";
                        break;
                    case 2:
                        Boy.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        Boy.str_personality = "Extraversion";
                        break;
                    case 4:
                        Boy.str_personality = "Agreeableness";
                        break;
                    case 5:
                        Boy.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        Boy.personality = Int32.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine(Boy.name + " " + Boy.age + " " + Boy.str_personality);
            }
            else
            {
                Console.Write("Enter your name in : ");
                Girl.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(Girl.name))
                {
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your name");
                    Girl.name = Console.ReadLine();
                }

                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out Girl.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your age: ");
                    ageAsString = Console.ReadLine();
                }
                perc.lazyPrint();
                Console.Write("Enter your personality here : ");
                Girl.personality = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                while (string.IsNullOrEmpty(Girl.personality.ToString())) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your personality.");
                    Girl.personality = Int32.Parse(Console.ReadLine());
                }

                switch (Girl.personality)
                {
                    case 1:
                        Girl.str_personality = "Openness";
                        break;
                    case 2:
                        Girl.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        Girl.str_personality = "Extraversion";
                        break;
                    case 4:
                        Girl.str_personality = "Agreeableness";
                        break;
                    case 5:
                        Girl.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        Girl.personality = Int32.Parse(Console.ReadLine());
                        break;
                }

                Console.WriteLine(Girl.name + " " + Girl.age + " " + Girl.str_personality);
            }
        }
    }

    class crush { //! ADDING NEW FUNCTIONS
        public void check() {
            Person Boy = new Person();
            Person Girl = new Person();
            var perc = new predictions();
            Program.def d = new Program.def();

            if (Program.def.finalGender == "boy") {

                Console.Write("Enter your crush's name in : ");
                Girl.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(Girl.name)) {
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your crush's name");
                    Girl.name = Console.ReadLine();
                }

                Console.Write("Enter your crush's age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out Girl.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your crush's age.");
                    ageAsString = Console.ReadLine();
                }
                perc.lazyPrint();
                Console.Write("Enter your crush's personality here : ");
                Girl.personality = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                while (string.IsNullOrEmpty(Girl.personality.ToString())) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your crush's personality.");
                    Girl.personality = Int32.Parse(Console.ReadLine());
                }

                switch (Girl.personality)
                {
                    case 1:
                        Girl.str_personality = "Openness";
                        break;
                    case 2:
                        Girl.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        Girl.str_personality = "Extraversion";
                        break;
                    case 4:
                        Girl.str_personality = "Agreeableness";
                        break;
                    case 5:
                        Girl.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        Girl.personality = Int32.Parse(Console.ReadLine());
                        break;
                }

                Console.WriteLine(Girl.name + " " + Girl.age + " " + Girl.str_personality);

            }
            else
            {
                Console.Write("Enter your crush's name in : ");
                Boy.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(Boy.name)) {
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your crush's name");
                    Boy.name = Console.ReadLine();
                }

                Console.Write("Enter your crush's age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out Boy.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your crush's age.");
                    ageAsString = Console.ReadLine();
                }
                perc.lazyPrint();
                Console.Write("Enter your crush's personality here : ");
                Boy.personality = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                while (string.IsNullOrEmpty(Boy.personality.ToString())) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your crush's personality.");
                    Boy.personality = Int32.Parse(Console.ReadLine());
                }

                switch (Boy.personality)
                {
                    case 1:
                        Boy.str_personality = "Openness";
                        break;
                    case 2:
                        Boy.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        Boy.str_personality = "Extraversion";
                        break;
                    case 4:
                        Boy.str_personality = "Agreeableness";
                        break;
                    case 5:
                        Boy.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        Boy.personality = Int32.Parse(Console.ReadLine());
                        break;
                }

                Console.WriteLine(Boy.name + " " + Boy.age + " " + Boy.str_personality);

            }
        }
    }
    class predictions
    {
        private static string pers1;
        private static string pers2;
        private static string pers3;
        private static string pers4;
        private static string pers5;
        //private bool cool_bool;
        public readonly string[] PP = { pers1, pers2, pers3, pers4, pers5 };

        public predictions()
        {
            pers1 = "Openness";
            pers2 = "Conscientiousness";
            pers3 = "Extraversion";
            pers4 = "Agreeableness";
            pers5 = "Neuroticism";
            //cool_bool = true;
        }

        //! Lazy implementation of array printing.
        public void lazyPrint()
        {
            string[] PP = { pers1, pers2, pers3, pers4, pers5 };

            //for (int i = 0; i < PP.Length; i++)
            //{
            //Console.WriteLine(PP[i]);
            //}

            Console.WriteLine("1." + PP[0]);
            Console.WriteLine("2." + PP[1]);
            Console.WriteLine("3." + PP[2]);
            Console.WriteLine("4." + PP[3]);
            Console.WriteLine("5." + PP[4]);

            Console.WriteLine();
        }

        //public void finalize() {
        //    Person Boy = new Person();
        //    Person Girl = new Person();
        //    predictions perc = new predictions();

        //    var rand = new Random();
        //    var percentage = rand.Next(1, 100);
        //    if (percentage > 50) {
        //        Console.WriteLine("Good Job!");
        //    }
        //    else {
        //        Console.WriteLine("You need to work on your personality");
        //    }
        //}

        public static void whichPersonality() //using logic to determine if the personality is compatible
        {
            Person Boy = new Person();
            Person Girl = new Person();
            Program p = new Program();

            if (Boy.personality == 1 && Girl.personality == 3 || Boy.personality == 3 && Girl.personality == 1)
            {
                Console.WriteLine("You might have an opportunity. Take it when you see it");
            } 

        }
    }
}
