using System;

namespace Dating_Prediction {
    public class gender_check {
        public void check() {
            Program.def def = new Program.def();
            Console.Write("Enter your gender : ");
            Program.def.gender = Console.ReadLine();
            Console.WriteLine();
            
            while (string.IsNullOrEmpty(Program.def.gender)) {
                Console.WriteLine();
                Console.WriteLine("Gender cant be empty. Please re-enter your gender");
                Program.def.gender = Console.ReadLine();
            }
            
            switch (Program.def.gender) {
                    case "Boy":
                    Program.def.finalGender = "Boy";
                    break;

                    case "man":
                    Program.def.finalGender = "Boy";
                    break;

                    case "Girl":
                    Program.def.finalGender = "Girl";
                    break;

                    case "woman":
                    Program.def.finalGender = "Girl";
                    break;

                    // default:
                    // Console.WriteLine("Unrecognizeable gender. Please Reinput: ");
                    // Program.def.gender = Console.ReadLine();

            }
            if(!string.IsNullOrEmpty(Program.def.gender)){

                while (string.IsNullOrEmpty(Program.def.finalGender)) {
                    Console.WriteLine();
                    Console.WriteLine("Gender not recognized. Please reinput: ");
                    Program.def.gender = Console.ReadLine();
                        switch (Program.def.gender) {
                        case "Boy":
                        Program.def.finalGender = "Boy";
                        break;

                        case "man":
                        Program.def.finalGender = "Boy";
                        break;

                        case "Girl":
                        Program.def.finalGender = "Girl";
                        break;

                        case "woman":
                        Program.def.finalGender = "Girl";
                        break;

                        // default:
                        // Console.WriteLine("Unrecognizeable gender. Please Reinput: ");
                        // Program.def.gender = Console.ReadLine();

                        
                    }
                }
            }
        }
    }
}