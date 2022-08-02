using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null)
            {
                return false;
            }

            foreach(string word2 in words)
            {
                try
                {
                    if (ignoreCase)
                    {
                        if (word2.Equals(word, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (word2.Equals(word))
                        {
                            return true;
                        }
                    }
                }
                catch(NullReferenceException)
                {
                    continue;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if(num == 1 || num == 0 || num < 0)
            {
                return false;
            }

            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            bool isUniqueSoFar = true;
            int index = -1;

            for(int i = 0; i < str.Length; i++)
            {
                for(int o = 0; o < str.Length; o++)
                {
                    if(i == o)
                    {

                    }
                    else
                    {
                        if(str[i] == str[o])
                        {
                            isUniqueSoFar = false;
                        }
                    }
                }

                if(isUniqueSoFar)
                {
                    index = i;
                }
                isUniqueSoFar = true;
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int consecutiveCount = 0;
            int maxCount = 0;
            for(var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] == numbers[i])
                {
                    consecutiveCount++;
                }
                else
                {
                    consecutiveCount = 0;
                }

                if (consecutiveCount >= maxCount)
                {
                    maxCount = consecutiveCount + 1;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> everyNth = new List<double>();
            int counter = 0;

            if(elements == null)
            {
                return everyNth.ToArray();
            }

            foreach(double element in elements)
            {
                counter++;
                if(counter == n)
                {
                    everyNth.Add(element);
                    counter = 0;
                }
            }

            return everyNth.ToArray();
        }
    }
}
