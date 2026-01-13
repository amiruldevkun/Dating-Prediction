namespace DatingPrediction.Core;
using System;

public class PersonalityCalculation
{
    private readonly IInputHandler _inputHandler;
    float getScore(int answer)
    {
        return (answer - 1) * 25;
    }
    
    float getReverseScore(int answer)
    {
        return (5 - answer) * 25;
    }

    void getPersonalityScore(int answer)
    {
        var questions = new (string TextReader, bool isDirect)[]
        {
            // Openness Questions
            ("I have a vibrant imagination", true),
            ("I have difficulty understanding abstract ideas", false),
            ("I am curious about many different things", true),
            
            // Conscientiousness Questions
            ("I am always prepared and organzied", true),
            ("I often forget to put things back in their place", false),
            ("I make sure that my work is finished on time", true),
            
            // Extraversion Questions
            ("I am the life of the party", true),
            ("I don't like to draw attention to myself", false),
            ("I feel comfortable around people", true),
            
            // Agreeableness Questions
            ("I am interested in people's feelings", true),
            ("I am not really interested in others", false),
            ("I have a good word for everyone", true),
            
            // Neuroticism Questions
            ("I get stressed out easily", true),
            ("I am relaxed most of the time", false),
            ("I have frequent mood swings", true)
            
        };

        float totalOpennessScore = 0;
        
        _inputHandler.displayQuestions("Answer the following questions", ": ");

        for (int i = 0; i < 3; i++)
        {
            _inputHandler.displayQuestions(questions[i].TextReader, " (1-5):");
        }
    }
}