namespace DatingPrediction.Core;

public class genderCheck
{
    string gender;
    private string UpperGender;
    private readonly IInputHandler _inputHandler;
    private PersonObj _person;
    
    public enum Gender {Male, Female}

    public genderCheck(IInputHandler inputHandler, PersonObj person)
    {
        _inputHandler = inputHandler;
        _person = person;
    }

    public void input()
    {
        _inputHandler.displayString("Male | Female");
        _inputHandler.displayString("Enter your gender: ");
        UpperGender = _inputHandler.getInput().ToUpper();
        _inputHandler.displayString("");
        
        while (string.IsNullOrEmpty(UpperGender)) {
            _inputHandler.displayString("Male | Female");
            _inputHandler.displayString("Gender cant be empty. Please re-enter your gender");
            UpperGender = _inputHandler.getInput();
            UpperGender = UpperGender.ToUpper();
        }

        check();
    }
    
    void check()
    {
            
        if (UpperGender == "MALE")
        {
            _person.User.gender = "Male";
            _person.Crush.gender = "Female";
        } else if (UpperGender == "FEMALE")
        {
            _person.User.gender = "Female";
            _person.Crush.gender = "Male";
        }
        else
        {
            _inputHandler.displayString("Invalid please reinput gender:");
        }
    }
}