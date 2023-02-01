using System;

namespace Dating_Prediction {
    public class gender_check {
        public void check() {
            def def = new def();
            Console.Write("Enter your gender : ");
            def.gender = Console.ReadLine();
            Console.WriteLine();
            
            while (string.IsNullOrEmpty(def.gender)) {
                Console.WriteLine();
                Console.WriteLine("Gender cant be empty. Please re-enter your gender");
                def.gender = Console.ReadLine();
            }
            
            switch (def.gender) {
                    case "Boy":
                    def.finalGender = "Boy";
                    break;

                    case "man":
                    def.finalGender = "Boy";
                    break;

                    case "boy":
                    def.finalGender = "Boy";
                    break;

                    case "Girl":
                    def.finalGender = "Girl";
                    break;

                    case "girl":
                    def.finalGender = "Girl";
                    break;

                    case "woman":
                    def.finalGender = "Girl";
                    break;

                    // default:
                    // Console.WriteLine("Unrecognizeable gender. Please Reinput: ");
                    // def.gender = Console.ReadLine();

            }
            if(!string.IsNullOrEmpty(def.gender)){

                while (string.IsNullOrEmpty(def.finalGender)) {
                    Console.WriteLine();
                    Console.WriteLine("Gender not recognized. Please reinput: ");
                    def.gender = Console.ReadLine();
                        switch (def.gender) {
                        case "Boy":
                        def.finalGender = "Boy";
                        break;

                        case "man":
                        def.finalGender = "Boy";
                        break;

                        case "Girl":
                        def.finalGender = "Girl";
                        break;

                        case "woman":
                        def.finalGender = "Girl";
                        break;

                        // default:
                        // Console.WriteLine("Unrecognizeable gender. Please Reinput: ");
                        // def.gender = Console.ReadLine();

                        
                    }
                }
            }
        }
    }
}