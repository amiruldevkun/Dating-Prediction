using System;

namespace datingpredic_updated {
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
                    case "boy":
                    Program.def.finalGender = "boy";
                    break;

                    case "man":
                    Program.def.finalGender = "boy";
                    break;

                    case "girl":
                    Program.def.finalGender = "girl";
                    break;

                    case "woman":
                    Program.def.finalGender = "girl";
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
                        case "boy":
                        Program.def.finalGender = "boy";
                        break;

                        case "man":
                        Program.def.finalGender = "boy";
                        break;

                        case "girl":
                        Program.def.finalGender = "girl";
                        break;

                        case "woman":
                        Program.def.finalGender = "girl";
                        break;

                        // default:
                        // // Console.WriteLine("Unrecognizeable gender. Please Reinput: ");
                        // // Program.def.gender = Console.ReadLine();

                        
                    }
                }
            }
        }
    }
}