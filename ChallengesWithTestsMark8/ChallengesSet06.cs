using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containWords = false;
            if( string.Equals(words, null) || words.Contains(null) )
            {
                return false;
            }
            if(ignoreCase == true) 
            { 
                word = word.ToLower();
                List<string> list = words.Select(x => x.ToLower()).ToList();
                containWords = list.Contains(word);

            }
            if ( ignoreCase == false)
            {
                containWords = words.Contains(word);
            }
            return containWords;
        }

        public bool IsPrimeNumber(int num)
        {
            bool isPrimeNumber = false;
           if(num >= 0)
            {
             if( num % 2 !=0 && num % 3 != 0 )
                {
                    isPrimeNumber = true;
                }   
            }
           if( num ==2 || num == 3)
            {
                isPrimeNumber = true;
            }
           if( num ==1)
            {
                isPrimeNumber = false;
            }
           return isPrimeNumber;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;

            for (int i = 0; i < str.Length; i++)
            {
                bool uindex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                        break; // No need to continue checking if the character is found multiple times
                    }
                }

                if (uindex)
                {
                    index = i; // Update the index only if the character is unique
                }
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (int j = i + 1; j < numbers.Length; j++) // Start from the next index to count consecutive occurrences
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCount++; // Increment the count for consecutive occurrences of the same number
                    }
                    else
                    {
                        break; // Exit the loop when a different number is encountered
                    }
                }
                if (currentCount > count)
                {
                    count = currentCount; // Update the maximum count if the current count is greater
                }
            }
            return count;
        }
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();   
            if (elements== null || n <= 0 || n> elements.Count)
            {
                return result.ToArray();
            }
            for(int i =n -1; i< elements.Count; i+=n)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }
    }
}
