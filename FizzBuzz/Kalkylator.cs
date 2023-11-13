using System.Diagnostics;

namespace FizzBuzz
{
    public class Kalkylator
    {
        public static void KörOchSkrivUtFizzBuzz()
        {
            for (int i = 1; i <= 15 ; i++)
            {
                string resultat = FizzBuzzKalkyl(i);
                Console.WriteLine(resultat);
            }
        }

        public static void LogMessage(string serviceName, string message)
        {
            Console.WriteLine($"Service {serviceName}: {message}");

        }
        public static string FizzBuzzKalkyl(int nummer)
        {
            if (nummer % 3== 0 && nummer % 5 == 0) return "FizzBuzz";
            if (nummer % 3 == 0) return "Fizz";
            if (nummer % 5 == 0) return "Buzz";
            
            
            
            return nummer.ToString();
            
        }
      
    }
}
