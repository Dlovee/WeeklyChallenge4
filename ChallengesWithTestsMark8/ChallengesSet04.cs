using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Sum(n => n % 2 == 0 ? n : -n);
        }


        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new[] { str1.Length, str2.Length, str3.Length, str4.Length }.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz != null) // Check to prevent null reference errors
            {
                biz.Name = "TrueCoders";
            }
        }


        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 > 0 && sideLength2 > 0 && sideLength3 > 0 &&
                   sideLength1 + sideLength2 > sideLength3 &&
                   sideLength1 + sideLength3 > sideLength2 &&
                   sideLength2 + sideLength3 > sideLength1;
        }


        public bool IsStringANumber(string input)
        {
            return !string.IsNullOrEmpty(input) && double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0) return false; // Handle empty/null array case

            int nullCount = objs.Count(o => o == null);
            return nullCount > objs.Length / 2;
        }
        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0; // Handle null or empty array

            var evens = numbers.Where(n => n % 2 == 0); // Select even numbers
            return evens.Any() ? evens.Average() : 0; // Calculate average or return 0 if no evens
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(nameof(number), "Factorial is undefined for negative numbers.");

            if (number == 0 || number == 1)
                return 1;

            return number * Factorial(number - 1);
        }
    }
}
