using System;

namespace FizzBuzz.Core
{
    public class FizzBuzzProvider
    {
        public string GetFizzBuzzSingle(int num)
        {
            if (num % 3 == 0 && num % 5 == 0) return "FizzBuzz";
            if (num % 3 == 0) return "Fizz";
            if (num % 5 == 0) return "Buzz";
            return num.ToString();
        }

        public string[] GetFizzBuzzMulti(int count)
        {
            if (count < 0 || count > 1000000) throw new ArgumentOutOfRangeException("This operation is not available in the free service");
            var result = new string[count];
            for(var i =0; i < count; i++)
            {
                result[i] = GetFizzBuzzSingle(i + 1);
            }
            return result;
        }
    }
}
