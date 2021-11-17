using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/*
TODO: Finish meaning class
TODO: Clean more stuff
*/

namespace datingpredic_updated
{
    class Program
    {
        static void Main(string[] args)
        {
            //* New sub-classes

            user user = new user();
            crush crush = new crush();
            Person Boy = new Person();
            Person Girl = new Person();
            
            //* Actual program starts here

            Console.Write("Enter your gender : ");
            var gender = Console.ReadLine();
            while (string.IsNullOrEmpty(gender)) {
                    Console.WriteLine("Gender cant be empty. Please re-enter your gender");
                    gender = Console.ReadLine();
                }
            if(gender == "boy")
            {
                Boy.gender = "boy";
            }
            else 
            {
                Girl.gender = "girl";
            }
            //! DEBUGGING AND CALLING SECTION (USE THIS WHEN NEW FUNCTIONS IS MADE & WANTED TO BE CALLED)
            //user.check();
            //crush.check();
            Console.ReadKey();

            /**
            * *Example of Debugging
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
        /* class meaning { //! NOT USABLE
            public string open; 
            public string discipline;
            public string extrovert;
            public string neuroticism;
            public string considerate;
            public void meanings(){
            
            int answer;//? Set "answer" to be int.
            
            //? Prints out options and info.
            Console.WriteLine("Please pick one of the options below: ");
            Console.WriteLine("1. Agreeableness");
            Console.WriteLine("2. Openness to experience");
            Console.WriteLine("3. Neuroticism");
            Console.WriteLine("4. Extrovert");
            Console.WriteLine("5. Conscientiousness");
            Console.WriteLine("More info type 0");

            //? Switch statement for easier debugging.
            answer = Convert.ToInt32(Console.ReadLine());//? Taking inputs.
            switch (answer) {
               case 1:
               
               break;
               
               case 2:
               Console.WriteLine("OkayChamping");
               break;

               case 3:
               Console.WriteLine("Testing 3");
               break;

               case 4:
               Console.WriteLine("Testing 4");
               break;

               case 5:
               Console.WriteLine("Testing 5");
               break;

               case 0: //? Info on the personalities.
               var url = "https://en.wikipedia.org/wiki/Big_Five_personality_traits#Descriptions_of_the_particular_personality_traits";//? make a variable that links to the webpage
               var psi = new System.Diagnostics.ProcessStartInfo(); //? Makes a new process info
               psi.UseShellExecute = true; //? Set the new process info to use shell
               psi.FileName = url; //? assigns the psi variable to be the webpage.
               System.Diagnostics.Process.Start(psi);//? opens the webpage.
               break;

               default:
               Console.WriteLine("damn boi wrong aanswer");
               break;
            }
            }
        }
        */ class user { //! ADDING NEW FUNCTIONS
        
            public void check() {
            Person Boy = new Person();
            Person Girl = new Person();
            if(Boy.gender == "boy") {
                //? This part is pretty complicated...
                Console.Write("Enter your name in : ");
                Boy.name = Console.ReadLine();
                while (string.IsNullOrEmpty(Boy.name)) { //? This checks if the input is empty.
                    Console.WriteLine("Name cant be empty. Please re-enter your name");//? Then spits out an error
                    Boy.name = Console.ReadLine();//? Reprompt the input
                }
                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                while(!int.TryParse(ageAsString, out Boy.age)) {
                    Console.WriteLine("Please re-enter your age.");
                    ageAsString = Console.ReadLine();
                }
                Console.Write("Enter your personality here : ");
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
                Console.Write("Enter your personality here : ");
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
            string crushgender;
            Console.WriteLine("What is your crush's gender?");
            crushgender = Console.ReadLine();
            while(string.IsNullOrEmpty(crushgender)) {
                Console.WriteLine("Please state your crush's gender.");
                crushgender = Console.ReadLine();
            }

            if(crushgender == "boy") {
                Console.Write("Enter your name in : ");
                Girl.name = Console.ReadLine();
                while (string.IsNullOrEmpty(Girl.name)) {
                    Console.WriteLine("Name cant be empty. Please re-enter your name");
                    Girl.name = Console.ReadLine();
                }
                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                while(!int.TryParse(ageAsString, out Girl.age)) {
                    Console.WriteLine("Please re-enter your age.");
                    ageAsString = Console.ReadLine();
                }
                Console.Write("Enter your personality here : ");
                Girl.personality = Console.ReadLine();
                while(string.IsNullOrEmpty(Girl.personality)) {
                    Console.WriteLine("Personality cant be empty. Please re-enter your personality.");
                    Girl.personality = Console.ReadLine();
                }
                Console.WriteLine(Girl.name + " " + Girl.age + " " + Girl.personality);
            }
            else 
            {
                Console.Write("Enter your name in : ");
                Boy.name = Console.ReadLine();
                while (string.IsNullOrEmpty(Boy.name)) {
                    Console.WriteLine("Name cant be empty. Please re-enter your name");
                    Boy.name = Console.ReadLine();
                }
                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                while(!int.TryParse(ageAsString, out Boy.age)) {
                    Console.WriteLine("Please re-enter your age.");
                    ageAsString = Console.ReadLine();
                }
                Console.Write("Enter your personality here : ");
                Boy.personality = Console.ReadLine();
                while(string.IsNullOrEmpty(Boy.personality)) {
                    Console.WriteLine("Personality cant be empty. Please re-enter your personality.");
                    Boy.personality = Console.ReadLine();
                }
                Console.WriteLine(Boy.name + " " + Boy.age + " " + Boy.personality);

            }
        }  
    
        
        
    }
}