namespace Dating_Prediction;

class inputHandler : IInputHandler
{
    string crushGender;
    private string maleName;
    private string femaleName;
    private string maleAge;
    private string femaleAge;

    public string getInput()
    {
        return Console.ReadLine();
    }

    public void check(string gender)
    {
        if (gender == "Male")
        {
            crushGender = "Female";
            KeepName("Male");
            
        }
        else if (gender == "Female")
        {
            crushGender = "Male";
            KeepName("Female");
            
        }
        

    }
    
    
    void KeepName(string gender)
    {
        if (gender == "Male")
        {
            Console.WriteLine("Please input your name!");
            maleName = getInput();
            while (String.IsNullOrEmpty(maleName))
            {
                Console.WriteLine("Please reinput your name!"); 
                maleName = getInput();
            }
            
            Console.WriteLine("Please input your crush's name!");
            femaleName = getInput();
            while (String.IsNullOrEmpty(femaleName))
            {
                Console.WriteLine("Please reinput your name!");
                femaleName = getInput();
            }
        }
        else if (gender == "Female")
        {
            Console.WriteLine("Please input your name!");
            femaleName = getInput();
            while (String.IsNullOrEmpty(femaleName))
            {
                Console.WriteLine("Please reinput your name!");
                femaleName = getInput();
            }
            
            Console.WriteLine("Please input your crush's name!");
            maleName = getInput();
            while (String.IsNullOrEmpty(maleName))
            {
                Console.WriteLine("Please reinput your name!");
                maleName = getInput();
            }
        }
    }
}

public interface IInputHandler
{
    string getInput();
}