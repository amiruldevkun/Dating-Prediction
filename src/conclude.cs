using System;
namespace Dating_Prediction 
{
    public class callExistingVars
    {
        public static bool determine = false;
    }
    public static class conclusion 
    {
        
        //* I got it!!!! nice
        public static void agePredicts() 
        {
            
            //* Good Predictions

            //* 13 - 16 range
            if (Enumerable.Range(13, 4).Contains(def.Boy.age) && Enumerable.Range(13, 4).Contains(def.Girl.age)) 
            {
                callExistingVars.determine = true;
            }

            //* 17 - 19 range
            else if (Enumerable.Range(17, 2).Contains(def.Boy.age) && Enumerable.Range(17, 2).Contains(def.Girl.age)) 
            {
                callExistingVars.determine = true;
            }
            
            //* 20+ range
            else if (def.Boy.age >= 20 && def.Girl.age >= 20) 
            {
                callExistingVars.determine = true;
            }

            //! Bad Predictions

            //! Under 16 with 20+ DANGER ZONE
            else if (Enumerable.Range(1, 16).Contains(def.Boy.age) && (def.Girl.age >= 20) || Enumerable.Range(1,17).Contains(def.Girl.age) && def.Boy.age >= 20) 
            {
                callExistingVars.determine = false;
            }
            
            //! Big age gap between a primary schooler and a middle/highschooler
            else if (Enumerable.Range(1, 12).Contains(def.Boy.age) && Enumerable.Range(15,3).Contains(def.Girl.age)) 
            {
                callExistingVars.determine = false;
            }

            //? This will print out the value from the 'determine' variable.
            Console.WriteLine(callExistingVars.determine);
        
        }

        public static void personalityPredicts() 
        {
            //* Predictions on this func will be evaluated by probability of two people ending up together
            //* This func will also be called IF the agepredicts func return true!

            if (def.finalGender == "Boy") 
            {
                switch(def.Boy.personality) 
                {
                    case 1:
                    if (def.Girl.personality == 1 || def.Girl.personality == 3 || def.Girl.personality == 4) 
                    {
                        Console.WriteLine("You two might be compatible! If you want some advice, " + Console.WriteLine(advice.randomlyPickoutAnAdvice()));
                    } 
                    break;
                }
            }
        }

        public static  class advice 
        {
            static string[] adviceLol;
            static advice() 
            {
                adviceLol = new string[10] {"nah bro idk", "", "", "", "", "", "", "", "", ""};
            }

            public static void randomlyPickoutAnAdvice() 
            {
                Random r = new Random();
                int pickout = r.Next(0, adviceLol.Length);
                Console.WriteLine(pickout);
            }
        }
    }
}