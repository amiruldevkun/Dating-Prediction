using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Dating_Prediction
{
    public class predictions
    {
        private const string V = "Negative";
        private const string I = "Positive";

        // Person Program.def.Boy = new Person();
        // Person Program.def.Girl = new Person();
        bool determine = false;
        int Adult = 20;
        string L = "";
        int minYoungAdult = 17;
        int minTeen = 13;
        int maxTeen = 16;
        int maxYoungAdult = 19;

        public void ageCall()
        {

            // testing purposes
            // if (Program.def.Boy.age == 0 && Program.def.Girl.age == 0)
            // {
            //     determine = 0;
            // }
            // ok age range
            Console.WriteLine("BOY VALUES:");
            Console.WriteLine(Program.def.Boy.name);
            Console.WriteLine(Program.def.Boy.age);
            Console.WriteLine(Program.def.Boy.personality);
            Console.WriteLine("GIRL VALUES:");
            Console.WriteLine(Program.def.Girl.name);
            Console.WriteLine(Program.def.Girl.age);
            Console.WriteLine(Program.def.Girl.personality);
            Console.WriteLine();
            Console.WriteLine();
            if (Enumerable.Range(minTeen, maxTeen).Contains(Program.def.Boy.age) && Enumerable.Range(minTeen, maxTeen).Contains(Program.def.Girl.age)) 
            {
                determine = true;
            }

            else if (Enumerable.Range(minYoungAdult, maxYoungAdult).Contains(Program.def.Boy.age) && Enumerable.Range(minYoungAdult, maxYoungAdult).Contains(Program.def.Girl.age)) 
            {
                determine = true;
            }

            //else if (Program.def.Boy.age >= maxYoungAdult && Program.def.Girl.age >= maxYoungAdult)
            //{
            //    determine = 1;
            //}

            // bad age range
            else if (Enumerable.Range(minTeen, minYoungAdult).Contains(Program.def.Boy.age) && Program.def.Girl.age >= Adult)
            {
                determine = false;
            }
            
            else if (Program.def.Boy.age >= Adult && Enumerable.Range(minTeen, minYoungAdult).Contains(Program.def.Girl.age)) 
            {
                determine = false;
            }
            
            switch(determine) 
            {
                case true:
                    L = I;
                    break;
                case false:
                    L = V;
                    break;
            }
            //!: Code in question
            Console.WriteLine(L);
            
            personalityCheck();
            
        }
        private void personalityCheck() 
        {
            if(L == I) 
            {
                Console.WriteLine("code: 0");
            }
            else if (L == V) 
            {
                Console.WriteLine("code: 1");
            }
        }
    }
}
