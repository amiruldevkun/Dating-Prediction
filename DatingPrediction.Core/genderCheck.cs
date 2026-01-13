namespace DatingPrediction.Core;

public class genderCheck
{
    string gender;
    private string UpperGender;
    private readonly IInputHandler _inputHandler;
    
    public enum Gender {Male, Female}

    public string input()
    {
        Console.WriteLine("Male | Female");
        Console. Write("Enter your gender: ");
        UpperGender = _inputHandler.getInput().ToUpper();
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