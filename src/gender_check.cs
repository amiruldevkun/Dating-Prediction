using System;

namespace Dating_Prediction {
    public class gender_check
    {
        string gender;
        string UpperGender;
        
        public enum Gender {Male, Female}
        
        public string input()
        {
            Console.WriteLine("Male | Female");
            Console.Write("Enter your gender : ");
            UpperGender = Console.ReadLine();
            UpperGender = UpperGender.ToUpper();
            Console.WriteLine();
            
            while (string.IsNullOrEmpty(UpperGender)) {
                Console.WriteLine("Male | Female");
                Console.WriteLine("Gender cant be empty. Please re-enter your gender");
                UpperGender = Console.ReadLine();
                UpperGender = UpperGender.ToUpper();
            }
            
            check();
            
            return gender;

        }

        string check()
        {
            
            if (UpperGender == "MALE")
            {
                gender = "Male";
            } else if (UpperGender == "FEMALE")
            {
                gender = "Female";
            }
            else
            {
                Console.WriteLine("Invalid please reinput gender:");
            }

            return gender;

        }
    }
}