namespace DatingPrediction.Core;

public class infoGatherer
{
    string crushGender;
    private string maleName;
    private string femaleName;
    private int maleAge;
    private int femaleAge;
    private readonly IInputHandler _handler;

    public infoGatherer(IInputHandler inputHandler)
    {
        _handler = inputHandler;
    }
    

    public void getValues(string gender)
    {
        if (gender == "Male")
        {
            crushGender = "Female";
            getName(gender, _handler);
            getAge(gender, _handler);
        }
        else if (gender == "Female")
        {
            crushGender = "Male";
            getName(gender, _handler);
            getAge(gender, _handler);
        }
    }

    void getName(string gender, IInputHandler ih)
    {
        if (gender == "Male")
        {
            Console.WriteLine("Please input your name!");
            maleName = ih.getInput();
            while (String.IsNullOrEmpty(maleName))
            {
                Console.WriteLine("Please reinput your name!");
                maleName = ih.getInput();
            }

            Console.WriteLine("Please input your crush's name!");
            femaleName = ih.getInput();
            while (String.IsNullOrEmpty(femaleName))
            {
                Console.WriteLine("Please reinput your name!");
                femaleName = ih.getInput();
            }
        }
        else if (gender == "Female")
        {
            Console.WriteLine("Please input your name!");
            femaleName = ih.getInput();
            while (String.IsNullOrEmpty(femaleName))
            {
                Console.WriteLine("Please reinput your name!");
                femaleName = ih.getInput();
            }

            Console.WriteLine("Please input your crush's name!");
            maleName = ih.getInput();
            while (String.IsNullOrEmpty(maleName))
            {
                Console.WriteLine("Please reinput your name!");
                maleName = ih.getInput();
            }
        }
    }

    void getAge(string gender, IInputHandler ih)
    {
        if (gender == "MALE")
        {
            ih.displayString("Please input your age!");
            maleAge = ih.getNumericalInput();
            while (maleAge < 1)
            {
                ih.displayString("Please reinput your age!");
                maleAge = ih.getNumericalInput();
            }
            
            ih.displayString("Please input your crush's age!");
            femaleAge = ih.getNumericalInput();
            while (femaleAge < 1)
            {
                ih.displayString("Please reinput your age!");
                femaleAge = ih.getNumericalInput();
            }
        }
        else
        {
            ih.displayString("Please input your age!");
            femaleAge = ih.getNumericalInput();
            while (femaleAge < 1)
            {
                ih.displayString("Please reinput your age!");
                femaleAge = ih.getNumericalInput();
            }
            
            ih.displayString("Please input your crush's age!");
            maleAge = ih.getNumericalInput();
            while (maleAge < 1)
            {
                ih.displayString("Please reinput your age!");
                maleAge = ih.getNumericalInput();
            }
        }
        
    }
}