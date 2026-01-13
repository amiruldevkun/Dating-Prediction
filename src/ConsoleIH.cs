namespace Dating_Prediction;

using DatingPrediction.Core;

class ConsoleIH : IInputHandler
{
    public string getInput()
    {
        return Console.ReadLine();
    }

    public int getNumericalInput()
    {
       return Int32.Parse(getInput());
    }

    public char getKeyboardPress()
    {
        return Console.ReadKey().KeyChar;
    }

    public void displayQuestions(string array, string randoText)
    {
        Console.WriteLine(array,  randoText);
    }

    public void displayString(string input)
    {
        Console.WriteLine(input);
    }
}