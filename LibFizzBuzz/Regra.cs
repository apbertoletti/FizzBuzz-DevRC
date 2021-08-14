using System;

namespace LibFizzBuzz
{
    public class Regra
    {
        public static string ResolveFizzBuzz(int num)
        {
            if (num <= 0 || num > 100)
                return "None";

            if (num % 5 == 0 && num % 3 == 0)
                return "FizzBuzz";

            if (num % 3 == 0)
                return "Fizz";

            if (num % 5 == 0)
                return "Buzz";

            return num.ToString();
        }
    }
}
