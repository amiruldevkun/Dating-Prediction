using System;
namespace Dating_Prediction 
{
    public class callExistingVars
    {
        public def d = new def();
        public static bool determine;
    }
    public class conclusion 
    {
        public void Predictions() 
        {
            // Good Predictions
            if (Enumerable.Range(13 ,17).Contains(def.Boy.age) && Enumerable.Range(13, 17).Contains(def.Girl.age)) 
            {
                callExistingVars.determine = true;
            }

            else if(Enumerable.Range(17, 19).Contains(def.Boy.age) && Enumerable.Range(17, 19).Contains(def.Girl.age)) 
            {
                callExistingVars.determine = true;
            } 

            // Bad Predictions
            else if (Enumerable.Range(13, 17).Contains(def.Boy.age) && (def.Girl.age >= 20) || Enumerable.Range(13,17).Contains(def.Girl.age) && def.Boy.age >= 20) 
            {
                callExistingVars.determine = false;
            }

            else 
            {
                Console.WriteLine("Failed");
            }
        }
    }
}