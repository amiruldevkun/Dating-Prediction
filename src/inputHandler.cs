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
        return 0;
    }

    public char getKeyboardPress()
    {
        return Console.ReadKey().KeyChar;
    }

    public void displayQuestions(string array, string randoText)
    {
        Console.WriteLine(array, "");
    }
}