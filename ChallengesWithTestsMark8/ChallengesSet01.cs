using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2) //Run a normal if scope asking if the variables are equal.
            {
                return true;
            }
            else
            {
                return false;
            }
            //To simplify: return num1 == num2; This is because it also returns a value.
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var answer = minuend - subtrahend;
            return answer;
            //return minuend - subtrahend; This is a simplified answer.
        }

        public int Add(int number1, int number2)
        {
            var answer = number1 + number2;
            return answer;
            //return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2) 
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
            //return number1 < number2 ? number1 : number2; This would be the ternary option. 
        }

        public long Multiply(long factor1, long factor2) //This is straight forward. We get two nums and mult.
        {
            return factor1 * factor2; //We just simply mult the nums.
        }

        public string GetGreeting(string nameOfPerson) //If this string is empty, then return "Hello".
        {
            // if (nameOfPerson == "")
            // {
            //     return "Hello!";
            // }
            // else
            // {
            //     return $"Hello, {nameOfPerson}!";
            // }
            return string.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!"; //If IsNullOrEmpty comes backs as true, it'll return "Hello!" else it'll return the interpolated statement.
        }

        // public string GetHey() //This method is a fact meaning it doesn't take any parameters. A theory is a method that does take parameters. 
        // {
        //     return "HEY!"; //On the test tab, I'm going to put the string inside "actual" and then "assert" that that actual value is equal to "HEY!"
        // } 
            public string GetHey() => "HEY!"; //I could also get fancy and use Lambda instead.
    }
}
