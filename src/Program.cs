using System.Diagnostics;
using System.Runtime.InteropServices;

/*
TODO: Finish this program once and for all 
!: Lets try to do this ^
TODO: release final
!: lets try ^
*/

namespace Dating_Prediction
{
    public class def {
        public static string? gender;
        public static string? finalGender;
        public static Person Boy = new Person();
        public static Person Girl = new Person();
    }
    public class Program
    {

        static void Main(string[] args)
        {
            StartScript();
        }

        private static void StartScript() 
        {
            //* New sub-classes
            gender_check gCheck = new gender_check();
            personalities perc = new personalities();
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

            //? Drawing the ascii art
            
            Console.WriteLine(asciiArt);
            
            //? Calls the gender check method to determine the primary gender for input
            
            gCheck.check();
            
            //? Starts the process of getting the information
            
            user.check();
            crush.check();
            
            //? Prints out values from the respective variables

            Console.WriteLine(def.Boy.name + " " + def.Boy.str_personality + " " + def.Boy.personality + " " + def.Boy.age);
            Console.WriteLine(def.Girl.name + " " + def.Girl.str_personality + " " + def.Girl.personality + " " + def.Girl.age);
            
            //? Prints out the conclusion

            conclusion.agePredicts();

            //? Prints out the selection of personalities
            
            // perc.lazyPrint();
            
            //? Displays an animation for the ending
            
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
}