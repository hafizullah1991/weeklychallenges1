using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (!vals[i])
                {
                    return true; // Found false
                }
            }
            return false; // Did not find false 
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if( numbers== null  )
            {
                return false;
            }
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            return (sum & 1) == 1;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];

                if (char.IsUpper(c))
                    hasUpper = true;
                else if (char.IsLower(c))
                    hasLower = true;
                else if (char.IsDigit(c))
                    hasNumber = true;

                if (hasUpper && hasLower && hasNumber)
                    return true;
            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char firstLetter = val[0];
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            char lastLetter = val[val.Length - 1];
            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0; 
            decimal result = dividend / divisor;
            return result;
        }

        public int LastMinusFirst(int[] nums)
        {
            int result = nums[nums.Length - 1] - nums[0];
            return result;
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < 100; i ++)
                if(i % 2 !=0)
            {
                odds.Add(i);
            }

            int[] result =  odds.ToArray();
            return result;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i=0; i < words.Length; i ++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}