using System;

namespace FizzBuzz
{
    public class Kalkylator
    {
        public static void SkrivUtFizzBuzz(int nummer)
        {
            Console.Write(FizzBuzzKalkyl(nummer));
        }


        public static string FizzBuzzKalkyl(int nummer)
        {
            if (nummer < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(nummer), "nummer kan ej va negativt");
            }

            bool divisibleBy3 = nummer % 3 == 0;
            bool divisibleBy5 = nummer % 5 == 0;

            switch (nummer)
            {
                case int n when (divisibleBy3 && divisibleBy5):
                    return "FizzBuzz";
                case int n when (divisibleBy3):
                    return "Fizz";
                case int n when (divisibleBy5):
                    return "Buzz";
                default:
                    return nummer.ToString();
            }
        }

        public static void HanteraOchSkrivUtAnvändarInput()
        {
            string input = LäsInput();
            if (ÄrExitKommando(input))
                return;

            int nummer = ParsaInputTillNummer(input);
            SkrivUtFizzBuzz(nummer);
        }

        private static string LäsInput()
        {
            Console.Write("Ange ett nummer (eller 'exit' för att avsluta): ");
            return Console.ReadLine()!;
        }

        private static bool ÄrExitKommando(string input)
        {
            return input.ToLower() == "exit";
        }

        private static int ParsaInputTillNummer(string input)
        {
            if (int.TryParse(input, out int nummer))
            {
                return nummer;
            }
            else
            {
                throw new ArgumentException($"{input} är inte ett nummer.");
            }
        }

    }
}
