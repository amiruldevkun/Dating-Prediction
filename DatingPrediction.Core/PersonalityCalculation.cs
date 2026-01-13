namespace DatingPrediction.Core;
using System;

public class PersonalityCalculation
{
    private int usrInput;
    private readonly IInputHandler _inputHandler;
    PersonObj _person =  new PersonObj();
    float getScore(int answer)
    {
        return (answer - 1) * 25;
    }
    
    float getReverseScore(int answer)
    {
        return (5 - answer) * 25;
    }

    private bool[] isDirect = new bool[] { true, false, true };

    private string[] OpenQuestions = new String[]
    {
        "I have a vibrant imagination",
        "I have difficulty understanding abstract ideas",
        "I am curious about many different things"
    };

    private string[] ConsciQuestions = new string[]
    {
        "I am always prepared and organized",
        "I often forget to put things back in their place",
        "I make sure that my work is finished on time"
    };

    private string[] ExtraverQuestions = new string[]
    {
        "I am the life of the party.",
        "I don't like to draw attention to myself.",
        "I feel comfortable around people."
    };

    private string[] AgreeableQuestions = new string[]
    {
        "I am interested in people's feelings.",
        "I am not really interested in others.",
        "I have a good word for everyone."
    };

    private string[] NeuroQuestions = new string[]
    {
        "I get stressed out easily.",
        "I am relaxed most of the time",
        "I have frequent mood swings"
    };

    void collectPersonalityScore(string gender)
    {
        if (gender == "MALE")
        {
            // Collect personality scores for User
            _person.User.OpenScore = getPersonalityScore("Openness", OpenQuestions, isDirect);
            _person.User.ConsciScore = getPersonalityScore("Openness", ConsciQuestions, isDirect);
            _person.User.ExtraverScore = getPersonalityScore("Openness", ExtraverQuestions, isDirect);
            _person.User.AgreeScore = getPersonalityScore("Openness", AgreeableQuestions, isDirect);
            _person.User.NeuroScore = getPersonalityScore("Openness", NeuroQuestions, isDirect);
            
            // Collect personality scores for Crush
            _person.Crush.OpenScore = getPersonalityScore("Openness", OpenQuestions, isDirect);
            _person.Crush.ConsciScore = getPersonalityScore("Openness", ConsciQuestions, isDirect);
            _person.Crush.ExtraverScore = getPersonalityScore("Openness", ExtraverQuestions, isDirect);
            _person.Crush.AgreeScore = getPersonalityScore("Openness", AgreeableQuestions, isDirect);
            _person.Crush.NeuroScore = getPersonalityScore("Openness", NeuroQuestions, isDirect);
        }
        else
        {
            // Collect personality scores for User
            _person.User.OpenScore = getPersonalityScore("Openness", OpenQuestions, isDirect);
            _person.User.ConsciScore = getPersonalityScore("Openness", ConsciQuestions, isDirect);
            _person.User.ExtraverScore = getPersonalityScore("Openness", ExtraverQuestions, isDirect);
            _person.User.AgreeScore = getPersonalityScore("Openness", AgreeableQuestions, isDirect);
            _person.User.NeuroScore = getPersonalityScore("Openness", NeuroQuestions, isDirect);
            
            // Collect personality scores for Crush
            _person.Crush.OpenScore = getPersonalityScore("Openness", OpenQuestions, isDirect);
            _person.Crush.ConsciScore = getPersonalityScore("Openness", ConsciQuestions, isDirect);
            _person.Crush.ExtraverScore = getPersonalityScore("Openness", ExtraverQuestions, isDirect);
            _person.Crush.AgreeScore = getPersonalityScore("Openness", AgreeableQuestions, isDirect);
            _person.Crush.NeuroScore = getPersonalityScore("Openness", NeuroQuestions, isDirect);
        }
    }
    
    double getPersonalityScore(string traitName, string[] traitQuestionArray, bool[] isDirect)
    {
        _inputHandler.displayString("Displaying Questions for " + traitName);
        double totalScore = 0;

        for (int i = 0; i < traitQuestionArray.Length; i++)
        {
            _inputHandler.displayQuestions(traitQuestionArray[i], " ( 1 - 5 ):");
            int answer = _inputHandler.getNumericalInput();

            if (isDirect[i])
            {
                totalScore += getScore(answer);
            }
            else
            {
                totalScore += getReverseScore(answer);
            }
        }
        return totalScore / traitQuestionArray.Length;
    }
}