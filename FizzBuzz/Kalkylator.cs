using System.Diagnostics;

namespace FizzBuzz
{
    public class Kalkylator
    {
        
        public static string FizzBuzzKalkyl(int nummer)
        {
           // if (nummer % 3 == 0) return "Fizz";
            if (nummer % 5 == 0) return "Buzz";
            return nummer.ToString(); 
            
        }
    }
}
