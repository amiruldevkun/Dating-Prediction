using System.Diagnostics;
using System.Runtime.InteropServices;
using DatingPrediction.Core;


/*
TODO: Finish this program once and for all 
!: Lets try to do this ^
TODO: release final
!: lets try ^
*/

namespace Dating_Prediction
{
    public class Entry
    {
        
        
         public static void Main()
        {
            //* Initializing objects
            ConsoleIH _IH = new ConsoleIH();
            PersonObj person = new PersonObj();
            genderCheck gCheck = new genderCheck(_IH, person);
            infoGatherer _IG = new infoGatherer(_IH);            
            string url = "https://en.wikipedia.org/wiki/Big_Five_personality_traits#Descriptions_of_the_particular_personality_traits";

            //* Actual program starts here 
            
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
                    Proc.StartInfo.FileName = "/usr/bin/firefox";
                    Proc.StartInfo.Arguments = url;
                    Proc.Start();
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                    Console.WriteLine("FORCED TELEMETRY IS COOL!!");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}"));
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                    Console.WriteLine("I PAY EXCESSIVE AMOUNT OF MONEY FOR AN ABUNDANCE OF PAYWALLS");
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
            
            gCheck.input();
            
            //? Starts the process of getting the information

            _IG.getValues(person.User.gender);
            
            //? Prints out values from the respective variables

            // Console.WriteLine(def.Boy.name + " " + def.Boy.str_personality + " " + def.Boy.personality + " " + def.Boy.age);
            // Console.WriteLine(def.Girl.name + " " + def.Girl.str_personality + " " + def.Girl.personality + " " + def.Girl.age);
            
            //? Prints out the conclusion

            //conclusion.agePredicts();

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
}