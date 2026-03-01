namespace DatingPrediction.Core;

public class PersonLogic
{
    public string name;
    public int age;
    public string gender;
    public double OpenScore;
    public double ConsciScore;
    public double ExtraverScore;
    public double AgreeScore;
    public double NeuroScore;

    public PersonLogic() {
        name = "";
        age = 0;
        gender = "";
        OpenScore = 0;
        ConsciScore = 0;
        ExtraverScore = 0;
        AgreeScore = 0;
        NeuroScore = 0;
    }
}

public class PersonObj
{
    public PersonLogic User = new PersonLogic();
    public PersonLogic Crush = new PersonLogic();
}