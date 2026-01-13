namespace DatingPrediction.Core;

public interface IInputHandler
{
        string getInput();
        int getNumericalInput();
        char getKeyboardPress();
        void displayQuestions(string input, string randoText);
}