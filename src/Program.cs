using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Python.Runtime;


/*
TODO: Finish this program once and for all 
!: ^^^^^^^^^^^^^^^^^^ this will surely never happen
TODO: release final
!: ^^^^^^^^^ THIS TOo
*/

namespace Dating_Prediction
{
    public class Program
    {

        public class def {
            public static string gender;
            public static string finalGender;
            public static Person Boy = new Person();
            public static Person Girl = new Person();
        }
        static void Main(string[] args)
        {
            //* New sub-classes
            var gCheck = new gender_check();
            user user = new user();
            crush crush = new crush();
            var perc = new personalities();
            def d = new def();
            predictions p = new predictions();
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

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                    Console.WriteLine("I AM LINUX");
                    Process Proc = new System.Diagnostics.Process();
                    Proc.StartInfo.FileName = "/usr/bin/placeholder";
                    Proc.StartInfo.Arguments = url;
                    Proc.Start();
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                    Console.WriteLine("FORCED TELEMETRY IS COOL!!");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}"));
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                    Console.WriteLine("I PAY EXCESSIVE AMOUNT OF MONEY FOR SHIT HARDWARE");
                    Process.Start("open", url);
                }
                else {
                    Console.WriteLine("idk man. your os is weird");
                    System.Environment.Exit(0);
                }
            }


            Console.Write("Do you want to refer the personality resources used? : ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "y":
                    personaResource(url);
                    Console.WriteLine("When your browser closes, press anything to continue (ignore the gtk message)");
                    Console.ReadKey();
                    break;
                case "yes":
                    personaResource(url);
                    Console.WriteLine("When your browser closes, press anything to continue");
                    Console.ReadKey();
                    break;
                case "Yes":
                    personaResource(url);
                    Console.WriteLine("When your browser closes, press anything to continue");
                    Console.ReadKey();
                    break;
                default:
                    Console.Write("Don't worry, you can always refer the resources later.\n");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    break;
            }
            Console.Clear();

            //* Drawing the ascii art
            Console.WriteLine(asciiArt);
            python py = new python();
            py.callPythonStuff();
            //gCheck.check();
            //user.check();
            //crush.check();
            //p.ageCall();
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

    public class Person { //! FIXED CLASS
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
    }

    class user { //! ADDING NEW FUNCTIONS

        public void check() {
            // Person Program.def.Boy = new Person();
            // Person Program.def.Girl = new Person();
            personalities perc = new personalities();
            Program.def d = new Program.def();
            if (Program.def.finalGender == "Boy") {
                //* This part is pretty complicated... OH WHO AM I KIDDING!

                Console.Write("Enter your name in : ");
                Program.def.Boy.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(Program.def.Boy.name)) { //? This checks if the input is empty. If it is empty,
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your name");//? Then it spits out an error
                    Program.def.Boy.name = Console.ReadLine();//? Reprompt the input
                }

                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out Program.def.Boy.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your age.");
                    ageAsString = Console.ReadLine();
                }

                perc.lazyPrint();
                Console.Write("Enter your personality here : ");
                var personaAsStr = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(personaAsStr, out Program.def.Boy.personality)) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your personality.");
                    personaAsStr = Console.ReadLine();
                }
                switch (Program.def.Boy.personality) {
                    case 1:
                        Program.def.Boy.str_personality = "Openness";
                        break;
                    case 2:
                        Program.def.Boy.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        Program.def.Boy.str_personality = "Extraversion";
                        break;
                    case 4:
                        Program.def.Boy.str_personality = "Agreeableness";
                        break;
                    case 5:
                        Program.def.Boy.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        Program.def.Boy.personality = Int32.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine(Program.def.Boy.name + " " + Program.def.Boy.age + " " + Program.def.Boy.str_personality);
            }
            else
            {
                Console.Write("Enter your name in : ");
                Program.def.Girl.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(Program.def.Girl.name))
                {
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your name");
                    Program.def.Girl.name = Console.ReadLine();
                }

                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out Program.def.Girl.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your age: ");
                    ageAsString = Console.ReadLine();
                }
                perc.lazyPrint(); 
                Console.Write("Enter your personality here : ");
                Program.def.Girl.personality = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                while (string.IsNullOrEmpty(Program.def.Girl.personality.ToString())) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your personality.");
                    Program.def.Girl.personality = Int32.Parse(Console.ReadLine());
                }

                switch (Program.def.Girl.personality)
                {
                    case 1:
                        Program.def.Girl.str_personality = "Openness";
                        break;
                    case 2:
                        Program.def.Girl.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        Program.def.Girl.str_personality = "Extraversion";
                        break;
                    case 4:
                        Program.def.Girl.str_personality = "Agreeableness";
                        break;
                    case 5:
                        Program.def.Girl.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        Program.def.Girl.personality = Int32.Parse(Console.ReadLine());
                        break;
                }

                Console.WriteLine(Program.def.Girl.name + " " + Program.def.Girl.age + " " + Program.def.Girl.str_personality);
            }
        }
    }

    class crush {
        public void check() {
            // Person Boy = new Person();
            // Person Program.def.Girl = new Person();
            personalities perc = new personalities();
            Program.def d = new Program.def();

            if (Program.def.finalGender == "Boy") {

                Console.Write("Enter your crush's name in : ");
                Program.def.Girl.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(Program.def.Girl.name)) {
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your crush's name");
                    Program.def.Girl.name = Console.ReadLine();
                }

                Console.Write("Enter your crush's age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out Program.def.Girl.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your crush's age.");
                    ageAsString = Console.ReadLine();
                }
                perc.lazyPrint();
                Console.Write("Enter your crush's personality here : ");
                Program.def.Girl.personality = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                while (string.IsNullOrEmpty(Program.def.Girl.personality.ToString())) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your crush's personality.");
                    Program.def.Girl.personality = Int32.Parse(Console.ReadLine());
                }

                switch (Program.def.Girl.personality)
                {
                    case 1:
                        Program.def.Girl.str_personality = "Openness";
                        break;
                    case 2:
                        Program.def.Girl.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        Program.def.Girl.str_personality = "Extraversion";
                        break;
                    case 4:
                        Program.def.Girl.str_personality = "Agreeableness";
                        break;
                    case 5:
                        Program.def.Girl.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        Program.def.Girl.personality = Int32.Parse(Console.ReadLine());
                        break;
                }

                Console.WriteLine(Program.def.Girl.name + " " + Program.def.Girl.age + " " + Program.def.Girl.str_personality);

            }
            else
            {
                Console.Write("Enter your crush's name in : ");
                Program.def.Boy.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(Program.def.Boy.name)) {
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your crush's name");
                    Program.def.Boy.name = Console.ReadLine();
                }

                Console.Write("Enter your crush's age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out Program.def.Boy.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your crush's age.");
                    ageAsString = Console.ReadLine();
                }
                perc.lazyPrint();
                Console.Write("Enter your crush's personality here : ");
                Program.def.Boy.personality = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                while (string.IsNullOrEmpty(Program.def.Boy.personality.ToString())) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your crush's personality.");
                    Program.def.Boy.personality = Int32.Parse(Console.ReadLine());
                }

                switch (Program.def.Boy.personality)
                {
                    case 1:
                        Program.def.Boy.str_personality = "Openness";
                        break;
                    case 2:
                        Program.def.Boy.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        Program.def.Boy.str_personality = "Extraversion";
                        break;
                    case 4:
                        Program.def.Boy.str_personality = "Agreeableness";
                        break;
                    case 5:
                        Program.def.Boy.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        Program.def.Boy.personality = Int32.Parse(Console.ReadLine());
                        break;
                }

                Console.WriteLine(Program.def.Boy.name + " " + Program.def.Boy.age + " " + Program.def.Boy.str_personality);

            }
        }
    }
    class personalities
    {
        private static string pers1;
        private static string pers2;
        private static string pers3;
        private static string pers4;
        private static string pers5;
        //private bool cool_bool;
        public readonly string[] PP = { pers1, pers2, pers3, pers4, pers5 };

        public personalities()
        {
            pers1 = "Openness"; //? curious and open about new things
            pers2 = "Conscientiousness"; //? organized and keen
            pers3 = "Extraversion"; //? high energy and socialable
            pers4 = "Agreeableness"; //? understanding and softie
            pers5 = "Neuroticism"; //? react badly to high stress situation
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
    }
    class python
    {
        public void callPythonStuff()
        {
            Runtime.PythonDLL = @"C:\Users\amiru\AppData\Local\Programs\Python\Python311\python311.dll";
            string pathToVirtualEnv = @"C:\Users\amiru\Desktop\Dating-Prediction\venv";
    
            // Environment.SetEnvironmentVariable("PATH", pathToVirtualEnv, EnvironmentVariableTarget.Process);
            // Environment.SetEnvironmentVariable("PYTHONHOME", pathToVirtualEnv, EnvironmentVariableTarget.Process);
            // Environment.SetEnvironmentVariable("PYTHONPATH", $"{pathToVirtualEnv}\\Lib\\site-packages;{pathToVirtualEnv}\\Lib", EnvironmentVariableTarget.Process);
    
    
            PythonEngine.PythonHome = pathToVirtualEnv;
            PythonEngine.PythonPath = PythonEngine.PythonPath + ";" + Environment.GetEnvironmentVariable("PYTHONPATH", EnvironmentVariableTarget.Process);
    
            PythonEngine.Initialize();
            PythonEngine.Exec(@"C:\Users\amiru\Desktop\Dating-Prediction\python_scripts\test.py");
        }
    } 
}
