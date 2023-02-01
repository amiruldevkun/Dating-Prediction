namespace Dating_Prediction 
{
    static class user { //! ADDING NEW FUNCTIONS

        public static void check() {
            // Person def.Boy = new Person();
            // Person def.Girl = new Person();
            personalities perc = new personalities();
            def d = new def();
            if (def.finalGender == "Boy") {
                //* This part is pretty complicated... OH WHO AM I KIDDING!

                Console.Write("Enter your name in : ");
                def.Boy.name = Console.ReadLine();
                Console.WriteLine();
                //? This function checks for empty or null strings
                while (string.IsNullOrEmpty(def.Boy.name)) { //? This checks if the input is empty. If it is empty,
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your name");//? Then it spits out an error
                    def.Boy.name = Console.ReadLine();//? Reprompt the input
                }

                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                //* This is an age checker
                while (!int.TryParse(ageAsString, out def.Boy.age)) { //? This checks if the input is empty by changing the input from string to int by parsing the answer
                    Console.WriteLine(); //? If the function detects a discrepency, it will prompt you to reinput the age 
                    Console.WriteLine("Please re-enter your age.");
                    ageAsString = Console.ReadLine(); //? this will then accepts the newly inputed answer
                }

                //? This is gonna print out a list of personalities
                perc.lazyPrint();
                Console.Write("Enter your personality here using the selected number : ");
                var personaAsStr = Console.ReadLine(); //? We will ask for the input to be in integer
                Console.WriteLine();
                while (!int.TryParse(personaAsStr, out def.Boy.personality)) { //? same business as usual with the top one
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your personality.");
                    personaAsStr = Console.ReadLine();
                }
                //? This switch statement will then check if the variable value is valid or not
                //? if it is valid, then it will assign it with the number inputted by the user.
                switch (def.Boy.personality) {
                    case 1:
                        def.Boy.str_personality = "Openness";
                        break;
                    case 2:
                        def.Boy.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        def.Boy.str_personality = "Extraversion";
                        break;
                    case 4:
                        def.Boy.str_personality = "Agreeableness";
                        break;
                    case 5:
                        def.Boy.str_personality = "Neuroticism";
                        break;
                    default: //? if its not valid, it will reprompt the user again
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        def.Boy.personality = Int32.Parse(Console.ReadLine());
                        break;
                }
            }
            else
            {
                Console.Write("Enter your name in : ");
                def.Girl.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(def.Girl.name))
                {
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your name");
                    def.Girl.name = Console.ReadLine();
                }

                Console.Write("Enter your age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out def.Girl.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your age: ");
                    ageAsString = Console.ReadLine();
                }
                perc.lazyPrint(); 
                Console.Write("Enter your personality here : ");
                def.Girl.personality = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                while (string.IsNullOrEmpty(def.Girl.personality.ToString())) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your personality.");
                    def.Girl.personality = Int32.Parse(Console.ReadLine());
                }

                switch (def.Girl.personality)
                {
                    case 1:
                        def.Girl.str_personality = "Openness";
                        break;
                    case 2:
                        def.Girl.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        def.Girl.str_personality = "Extraversion";
                        break;
                    case 4:
                        def.Girl.str_personality = "Agreeableness";
                        break;
                    case 5:
                        def.Girl.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        def.Girl.personality = Int32.Parse(Console.ReadLine());
                        break;
                }
            }
        }
    }

    static class crush {
        public static void check() {
            // Person Boy = new Person();
            // Person def.Girl = new Person();
            personalities perc = new personalities();
            def d = new def();

            if (def.finalGender == "Boy") {

                Console.Write("Enter your crush's name in : ");
                def.Girl.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(def.Girl.name)) {
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your crush's name");
                    def.Girl.name = Console.ReadLine();
                }

                Console.Write("Enter your crush's age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out def.Girl.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your crush's age.");
                    ageAsString = Console.ReadLine();
                }
                perc.lazyPrint();
                Console.Write("Enter your crush's personality here : ");
                def.Girl.personality = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                while (string.IsNullOrEmpty(def.Girl.personality.ToString())) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your crush's personality.");
                    def.Girl.personality = Int32.Parse(Console.ReadLine());
                }

                switch (def.Girl.personality)
                {
                    case 1:
                        def.Girl.str_personality = "Openness";
                        break;
                    case 2:
                        def.Girl.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        def.Girl.str_personality = "Extraversion";
                        break;
                    case 4:
                        def.Girl.str_personality = "Agreeableness";
                        break;
                    case 5:
                        def.Girl.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        def.Girl.personality = Int32.Parse(Console.ReadLine());
                        break;
                }
            }
            else
            {
                Console.Write("Enter your crush's name in : ");
                def.Boy.name = Console.ReadLine();
                Console.WriteLine();
                while (string.IsNullOrEmpty(def.Boy.name)) {
                    Console.WriteLine();
                    Console.WriteLine("Name cant be empty. Please re-enter your crush's name");
                    def.Boy.name = Console.ReadLine();
                }

                Console.Write("Enter your crush's age : ");
                var ageAsString = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(ageAsString, out def.Boy.age)) {
                    Console.WriteLine();
                    Console.WriteLine("Please re-enter your crush's age.");
                    ageAsString = Console.ReadLine();
                }
                perc.lazyPrint();
                Console.Write("Enter your crush's personality here : ");
                def.Boy.personality = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                while (string.IsNullOrEmpty(def.Boy.personality.ToString())) {
                    Console.WriteLine();
                    Console.WriteLine("Personality cant be empty. Please re-enter your crush's personality.");
                    def.Boy.personality = Int32.Parse(Console.ReadLine());
                }

                switch (def.Boy.personality)
                {
                    case 1:
                        def.Boy.str_personality = "Openness";
                        break;
                    case 2:
                        def.Boy.str_personality = "Conscientiousness";
                        break;
                    case 3:
                        def.Boy.str_personality = "Extraversion";
                        break;
                    case 4:
                        def.Boy.str_personality = "Agreeableness";
                        break;
                    case 5:
                        def.Boy.str_personality = "Neuroticism";
                        break;
                    default:
                        Console.WriteLine("Invalid personality. Please reinput it after this line");
                        def.Boy.personality = Int32.Parse(Console.ReadLine());
                        break;
                }
            }
        }    
    }
}