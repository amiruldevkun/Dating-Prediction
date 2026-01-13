namespace DatingPrediction.Core;

public class infoGatherer
{
    string crushGender;
    private string maleName;
    private string femaleName;
    private string maleAge;
    private string femaleAge;
    private readonly IInputHandler _handler;
    

    public void check(string gender)
    {
        if (gender == "Male")
        {
            crushGender = "Female";
            getName("Male", _handler);

        }
        else if (gender == "Female")
        {
            crushGender = "Male";
            getName("Female", _handler);

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

    void getAge(IInputHandler ih)
    {
        
        
    }
}