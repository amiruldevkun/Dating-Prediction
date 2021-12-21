using System;
using System.Collections.Generic;



/*
TODO: Finish meaning class
TODO: Clean more stuff
*/

namespace datingpredic_updated
{
    public class Program
    {
        private static System.Timers.Timer tm;
        
        public class def {
            public static string gender;
        }
        static void Main(string[] args)
        {
            //* New sub-classes

            user user = new user();
            crush crush = new crush();
            Person Boy = new Person();
            Person Girl = new Person();
            var perc = new predictions();
            def d = new def();
            
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
            ScriptAnim();
            Console.WriteLine(asciiArt);
            Console.Write("Enter your gender : ");
            def.gender = Console.ReadLine();
            while (string.IsNullOrEmpty(def.gender)) {
                    Console.WriteLine("Gender cant be empty. Please re-enter your gender");
                    def.gender = Console.ReadLine();
            }

            if(def.gender == "boy" || def.gender == "man")
            {
                Boy.gender = "boy";
            }
            else if (def.gender == "girl" || def.gender == "woman")
            {
                Girl.gender = "girl";
            }
            else {
                Console.WriteLine("Gender Input Wrong. Please Put it again");
                def.gender = Console.ReadLine();
            }

            //? DEBUGGING AND CALLING SECTION (USE THIS WHEN NEW FUNCTIONS IS MADE & WANTED TO BE CALLED)
            // user.check();
            // crush.check();
            perc.lazyPrint();
            Console.WriteLine("The script has ended. Press any key to end the session.");
            Console.ReadKey();
            EndScriptAnim();

            /**
            * *Example of my style of Debugging(TM)
            * 
            *
            //user.check(); Not being tested / debugged
            //crush.check(); Not being tested / debugged
        **  bruh.meanings(); This one is the function that is being tested / debugged
        *!  Console.ReadKey(); Ignore this
            *
            *
            *
            */
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
            public string personality;
            public string gender;

            public Person() {
                name = "";
                age = 0;
                personality = "";
                gender = "";
            }
        }
        class user { //! ADDING NEW FUNCTIONS
        
            public void check() {
            Person Boy = new Person();
            Person Girl = new Person();
            var perc = new predictions();
            if(Boy.gender == "boy") {
                //* This part is pretty complicated... OH WHO AM I KIDDING!
                
                Console.Write("Enter your name in : ");
                Boy.name = Console.ReadLine();
                while (string.IsNullOrEmpty(Boy.name)) { //? This checks if the input is empty. If it is empty,
                    Console.WriteLine("Name cant be empty. Please re-enter your name");//? Then it spits out an error
                    Boy.name = Console.ReadLine();//? Reprompt the input
                }

                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                while(!int.TryParse(ageAsString, out Boy.age)) {
                    Console.WriteLine("Please re-enter your age.");
                    ageAsString = Console.ReadLine();
                }

                for (int i =0; i < perc.PP.Length; i++) {
                    Console.WriteLine(perc.PP[i]);
                }
                Console.WriteLine("Enter your personality here : ");
                Boy.personality = Console.ReadLine();
                while(string.IsNullOrEmpty(Boy.personality)) {
                    Console.WriteLine("Personality cant be empty. Please re-enter your personality.");
                    Boy.personality = Console.ReadLine();
                }
                Console.WriteLine(Boy.name + " " + Boy.age + " " + Boy.personality);
            }
            else 
            {
                Console.Write("Enter your name in : ");
                Girl.name = Console.ReadLine();
                while (string.IsNullOrEmpty(Girl.name)) {
                    Console.WriteLine("Name cant be empty. Please re-enter your name");
                    Boy.name = Console.ReadLine();
                }
                
                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                while(!int.TryParse(ageAsString, out Girl.age)) {
                    Console.WriteLine("Please re-enter your age name.");
                    ageAsString = Console.ReadLine();
                }
                for (int i =0; i < perc.PP.Length; i++) {
                    Console.WriteLine(perc.PP[i]);
                }
                Console.WriteLine("Enter your personality here : ");
                Girl.personality = Console.ReadLine();
                while(string.IsNullOrEmpty(Girl.personality)) {
                    Console.WriteLine("Personality cant be empty. Please re-enter your personality.");
                    Girl.personality = Console.ReadLine();
                }

                Console.WriteLine(Girl.name + " " + Girl.age + " " + Girl.personality);
            }
        }
        }
        
        class crush { //! ADDING NEW FUNCTIONS
            public void check() {
            Person Boy = new Person();
            Person Girl = new Person();
            var perc = new predictions();
            string crushgender;
            Console.WriteLine("What is your crush's gender?");
            crushgender = Console.ReadLine();
            while(string.IsNullOrEmpty(crushgender)) {
                Console.WriteLine("Please state your crush's gender.");
                crushgender = Console.ReadLine();
            }

            if(crushgender == "boy") {
                
                Console.Write("Enter your crush's name in : ");
                Girl.name = Console.ReadLine();
                while (string.IsNullOrEmpty(Girl.name)) {
                    Console.WriteLine("Name cant be empty. Please re-enter your crush's name");
                    Girl.name = Console.ReadLine();
                }
                
                Console.Write("Enter your crush's age : ");
                var ageAsString = Console.ReadLine();
                while(!int.TryParse(ageAsString, out Girl.age)) {
                    Console.WriteLine("Please re-enter your crush's age.");
                    ageAsString = Console.ReadLine();
                }
                for (int i =0; i < perc.PP.Length; i++) {
                    Console.WriteLine(perc.PP[i]);
                }
                Console.WriteLine("Enter your crush's personality here : ");
                Girl.personality = Console.ReadLine();
                while(string.IsNullOrEmpty(Girl.personality)) {
                    Console.WriteLine("Personality cant be empty. Please re-enter your crush's personality.");
                    Girl.personality = Console.ReadLine();
                }
                Console.WriteLine(Girl.name + " " + Girl.age + " " + Girl.personality);
            
            }
            else 
            {
                Console.Write("Enter your crush's name in : ");
                Boy.name = Console.ReadLine();
                while (string.IsNullOrEmpty(Boy.name)) {
                    Console.WriteLine("Name cant be empty. Please re-enter your crush's name");
                    Boy.name = Console.ReadLine();
                }
                
                Console.Write("Enter your crush's age : ");
                var ageAsString = Console.ReadLine();
                while(!int.TryParse(ageAsString, out Boy.age)) {
                    Console.WriteLine("Please re-enter your crush's age.");
                    ageAsString = Console.ReadLine();
                }
                for (int i =0; i < perc.PP.Length; i++) {
                    Console.WriteLine(perc.PP[i]);
                }
                Console.Write("Enter your crush's personality here : ");
                Boy.personality = Console.ReadLine();
                while(string.IsNullOrEmpty(Boy.personality)) {
                    Console.WriteLine("Personality cant be empty. Please re-enter your crush's personality.");
                    Boy.personality = Console.ReadLine();
                }
                Console.WriteLine(Boy.name + " " + Boy.age + " " + Boy.personality);

            }
            }
        }
        class predictions {
            private static string pers1;
            private static string pers2;
            private static string pers3;
            private static string pers4;
            private static string pers5;
            private bool cool_bool;
            public readonly string [] PP = {pers1, pers2, pers3, pers4, pers5};        
        
            public predictions(){
                pers1 = "Openness";
                pers2 = "Conscientiousness";
                pers3 = "Extraversion";
                pers4 = "Agreeableness";
                pers5 = "Neuroticism";
                cool_bool = true;
            }

            //! Lazy implementation of array printing.
            public void lazyPrint()
            {
            string[] PP = { pers1, pers2, pers3, pers4, pers5 };
            
                for (int i = 0; i < PP.Length; i++)
                {
                Console.WriteLine(PP[i]);
                }
            }
            public static void which() {
                Person Boy = new Person();
                Person Girl = new Person();
                predictions perc = new predictions();
                Program.def d = new Program.def();
                if(Program.def.gender == "boy" || Program.def.gender == "man") {
                    
                    //* Compatible Predictions
                    
                    if (Boy.personality == pers5 && Girl.personality == pers4 || Boy.personality == pers4 && Girl.personality == pers5) {
                        Console.WriteLine("You will have a chance to be with her/him. Take the chance when you see it.");
                        return;
                    }
                    else if (Boy.personality == pers3 && Girl.personality == pers2 || Boy.personality == pers2 && Girl.personality == pers3) {
                        Console.WriteLine("You will have a chance to be with her/him. Take the chance when you see it.");
                        return;
                    }
                    else if (Boy.personality == pers4 && Girl.personality == pers2 || Boy.personality == pers2 && Girl.personality == pers4) {
                        Console.WriteLine("You will have a chance to be with her/him. Take the chance when you see it.");
                        return;
                    }
                    else if (Boy.personality == pers4 && Girl.personality == pers1 || Boy.personality == pers1 && Girl.personality == pers4) {
                        Console.WriteLine("You will have a chance to be with her/him. Take the chance when you see it.");
                        return;
                    }
                    
                    //* Incompatible Predictions

                    else if (Boy.personality == pers5 && Girl.personality == pers3 || Boy.personality == pers3 && Girl.personality == pers5) {
                        Console.WriteLine("You still have a chance. but, it's  very slim.");
                        return;
                    }
                    else if (Boy.personality == pers3 && Girl.personality == pers4 || Boy.personality == pers4 && Girl.personality == pers3) {
                        Console.WriteLine("Youstill have a chance. But, it's very slim.");
                        return;
                    }
                    else if (Boy.personality == pers1 && Girl.personality == pers2 || Boy.personality == pers2 && Girl.personality == pers1) {
                        Console.WriteLine("You still have a chance. But, it's very slim.");
                        return;
                    }
                    else if (Boy.personality == pers2 && Girl.personality == pers5 || Boy.personality == pers5 && Girl.personality == pers2) {
                        Console.WriteLine("You still have a chance. But, it's very slim");
                        return;
                    }
                }
                
            }
            public void finalize() {
                Person Boy = new Person();
                Person Girl = new Person();
                predictions perc = new predictions();
                // print a percentage at random
                // then print a message
                // if the percentage is more than 50%
                // then print a message saying "Good Job!"
                // else print a message saying "You need to work on your personality"

                var rand = new Random();
                var percentage = rand.Next(1, 100);
                if (percentage > 50) {
                    Console.WriteLine("Good Job!");
                }
                else {
                    Console.WriteLine("You need to work on your personality");
                }
            }
        }  
}
