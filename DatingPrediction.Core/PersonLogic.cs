namespace DatingPrediction.Core;

public class PersonLogic
{
    public string name;
    public int age;
    public int personality;
    public string str_personality;
    public string gender;

    public PersonLogic() {
        name = "";
        age = 0;
        personality = 0;
        gender = "";
        str_personality = "";
        
    }
}

public class PersonObj
{
    public PersonLogic User = new PersonLogic();
    public PersonLogic Crush = new PersonLogic();
}