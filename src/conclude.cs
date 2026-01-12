using System;
namespace Dating_Prediction 
{
    public static class callExistingVars
    { //!  ^^^^^^ I think its just this...
        public static bool determine; //false
    }
    public static class conclusion 
    {
        
        //* I got it!!!! nice
        public static void agePredicts() 
        {
            
            //* Good Predictions

            //* 13 - 16 range
            if (Enumerable.Range(13, 3).Contains(def.Male.age) && Enumerable.Range(13, 3).Contains(def.Female.age)) 
            {
                callExistingVars.determine = true;
            }

            //* 17 - 19 range
            else if (Enumerable.Range(17, 2).Contains(def.Male.age) && Enumerable.Range(17, 2).Contains(def.Female.age)) 
            {
                callExistingVars.determine = true;
            }
            
            //* 20+ range
            else if (def.Male.age >= 20 && def.Female.age >= 20) 
            {
                callExistingVars.determine = true;
            }

            //! Bad Predictions

            // //! Under 15 with 20+ DANGER ZONE
            // else if (Enumerable.Range(0, 16).Contains(def.Male.age) && (def.Female.age >= 20) || Enumerable.Range(0,16).Contains(def.Female.age) && def.Male.age >= 20) 
            // {
            //     callExistingVars.determine = false;
            // }
            
            // //! Big age gap between a primary schooler and a middle/highschooler
            // else if (Enumerable.Range(1, 12).Contains(def.Male.age) && Enumerable.Range(15,3).Contains(def.Female.age) || Enumerable.Range(1, 12).Contains(def.Female.age) && Enumerable.Range(15,3).Contains(def.Male.age)) 
            // {
            //     callExistingVars.determine = false;
            // }

            //? This will print out the value from the 'determine' variable.
            //! does this override the variable?
            Console.WriteLine(callExistingVars.determine);
        
        }

        public static void personalityPredicts() 
        {
            //* Predictions on this function will be evaluated by probability of two people ending up together
            //* This func will also be called IF the agepredicts func return true!

            int oops = 0;
            advice.randomlyPickoutAnAdvice(oops);

            if (def.finalGender == "Boy") 
            {
                switch(def.Male.personality) 
                {
                    case 1:
                    if (def.Female.personality == 1 || def.Female.personality == 3 || def.Female.personality == 4) 
                    {
                        Console.WriteLine("You two might be compatible! If you want some advice: " + oops);
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

            public static void randomlyPickoutAnAdvice(int output) 
            {
                Random r = new Random();
                output = r.Next(0, adviceLol.Length);
                Console.WriteLine(output);
            }
        }
    }
}