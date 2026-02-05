namespace DatingPrediction.Core;
using System;

public class PersonalityCalculation
{
    private readonly IInputHandler _inputHandler;
    private readonly PersonObj _person;

    public PersonalityCalculation(IInputHandler inputHandler, PersonObj person)
    {
        _inputHandler = inputHandler;
        _person = person;
    }
    
    float getScore(int answer)
    {
        return (answer - 1) * 25;
    }
    
    float getReverseScore(int answer)
    {
        return (5 - answer) * 25;
    }

    public bool[] isDirect = new bool[] { true, false, true };

    public string[] OpenQuestions = new String[]
    {
        "I have a vibrant imagination",
        "I have difficulty understanding abstract ideas",
        "I am curious about many different things"
    };

    public string[] ConsciQuestions = new string[]
    {
        "I am always prepared and organized",
        "I often forget to put things back in their place",
        "I make sure that my work is finished on time"
    };

    public string[] ExtraverQuestions = new string[]
    {
        "I am the life of the party.",
        "I don't like to draw attention to myself.",
        "I feel comfortable around people."
    };

    public string[] AgreeableQuestions = new string[]
    {
        "I am interested in people's feelings.",
        "I am not really interested in others.",
        "I have a good word for everyone."
    };

    public string[] NeuroQuestions = new string[]
    {
        "I get stressed out easily.",
        "I am relaxed most of the time",
        "I have frequent mood swings"
    };

    void collectUserPersonalityScore()
    {
        // Collect personality scores for User
        _person.User.OpenScore = getPersonalityScore("Openness", OpenQuestions, isDirect);
        _person.User.ConsciScore = getPersonalityScore("Conscientiousness", ConsciQuestions, isDirect);
        _person.User.ExtraverScore = getPersonalityScore("Extraversion", ExtraverQuestions, isDirect);
        _person.User.AgreeScore = getPersonalityScore("Agreeableness", AgreeableQuestions, isDirect);
        _person.User.NeuroScore = getPersonalityScore("Neuroticism", NeuroQuestions, isDirect);
    }

    void collectCrushPersonalityScore()
    {
        // Collect personality scores for Crush
        _person.Crush.OpenScore = getPersonalityScore("Openness", OpenQuestions, isDirect);
        _person.Crush.ConsciScore = getPersonalityScore("Conscientiousness", ConsciQuestions, isDirect);
        _person.Crush.ExtraverScore = getPersonalityScore("Extraversion", ExtraverQuestions, isDirect);
        _person.Crush.AgreeScore = getPersonalityScore("Agreeableness", AgreeableQuestions, isDirect);
        _person.Crush.NeuroScore = getPersonalityScore("Neuroticism", NeuroQuestions, isDirect);
    }
    
    public double getPersonalityScore(string traitName, string[] traitQuestionArray, bool[] isDirect)
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

    double getFinalOutcome()
    {
        double Score = 100.0;
        double ageGapScore = 0.0;
        ageGapScore = calculateAgeGap(Score);
        
        double openDelta = Math.Abs(_person.User.OpenScore - _person.Crush.OpenScore);
        double consciDelta = Math.Abs(_person.User.ConsciScore - _person.Crush.ConsciScore);
        double extraDelta = Math.Abs(_person.User.ExtraverScore - _person.Crush.ExtraverScore);

        ageGapScore -= (openDelta * 0.20);
        ageGapScore -= (consciDelta * 0.15);
        ageGapScore -= (extraDelta * 0.10);

        if (_person.User.NeuroScore > 70 && _person.Crush.NeuroScore > 70)
        {
            ageGapScore -= 20;
        }

        if (_person.User.AgreeScore > 80 && _person.Crush.AgreeScore > 80)
        {
            ageGapScore += 10;
        }
        
        return Math.Clamp(ageGapScore, 0, 100);
    }

    double calculateAgeGap(double score)
    {
        int ageGap = Math.Abs(_person.User.age - _person.Crush.age);
        double agePenalty = 0.0;
        
        if (ageGap > 12)
        {
            agePenalty = ageGap * 5;
        } else if (ageGap > 7 )
        {
            agePenalty = ageGap * 3;
        } else if (ageGap > 3)
        {
            agePenalty = ageGap * 1;
        }

        if (Math.Min(_person.User.age, _person.Crush.age) < 25 && ageGap > 3)
        {
            agePenalty *= 1.5;
        }
        score -= agePenalty;
        return score;
    }

    void displayResult(double finalScore)
    {
        _inputHandler.displayString("=================================");
        _inputHandler.displayString("Final Result: " + finalScore + "%");
        _inputHandler.displayString("=================================");

        if (finalScore >= 80)
        {
            _inputHandler.displayString("VERDICT: You both are compatible with eachother! " +
                                        "May your relationship prosper.");
        }
        else if (finalScore >= 60)
        {
            _inputHandler.displayString("VERDICT: There will be hiccups on the way and if you go" +
                                        " overcome, overcome it together");
        }
        else if (finalScore >= 40)
        {
            _inputHandler.displayString("VERDICT: You don't have the brightest future as shown with the" +
                                        " percentage.");
        } 
        else if (finalScore >= 20)
        {
            _inputHandler.displayString("VERDICT: wrap it up.");
        }
        else
        {
            _inputHandler.displayString("SCORING FAILED.");
        }
        
    }
}