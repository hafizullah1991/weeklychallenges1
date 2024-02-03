using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0; 
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

    

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null ||  numbers.Count() == 0)
            {
                return 0;
            }
            
            double num = numbers.Min();
            double num2 =   numbers.Max();
            return num2 + num;
        }
           

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            return Math.Min( length1 , length2);
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length ==0)
            {
                return 0;
            }

            return numbers.Where(n => n % 2 == 0).Sum();


        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null || numbers.Count()==0)
            {
                return false;
            }
            int sum = numbers.Sum();
            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }

            return (number % 2 == 0) ? number / 2 : (number - 1) / 2;
        }
    }
}
