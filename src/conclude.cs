using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace datingpredic_updated
{
    public class predictions
    {
        Person Boy = new Person();
        Person Girl = new Person();
        int determine = 0;

        int Adult = 20;
        int youngAdult = 17;
        int Teen = 13;
        public void ageCall() {
            // ok age range
            if (Boy.age >= Teen || Boy.age < youngAdult && Girl.age >= Teen || Girl.age < youngAdult) 
            {
                determine = 1;
            }

            if (Boy.age >= youngAdult || Boy.age <= Adult && Girl.age >= youngAdult || Girl.age <= Adult) 
            {
                determine = 1;
            }

            // bad age range
            if (Boy.age < Teen ||Boy.age >= Adult && Girl.age < Teen || Girl.age >= Adult) 
            {
                determine = 2;
            }
        }

        public void personalityCheck() {
                
            switch(determine) 
            {
                case 2:
                    Console.WriteLine("PEDOFILIA");
                    break;
                
                case 1:
                    Console.WriteLine("Positive");
                    break;
            }
            
            
            
            if (Boy.personality == (1 | 2 | 3) && Girl.personality == (4 | 5 | 3)) {

            }
        }
    }
}
