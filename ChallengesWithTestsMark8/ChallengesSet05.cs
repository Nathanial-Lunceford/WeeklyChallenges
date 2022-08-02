using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            bool foundNumber = false;
            int finder = startNumber + 1;

            while(!foundNumber)
            {
                if(finder % n == 0)
                {
                    foundNumber = true;
                }
                else
                {
                    finder++;
                }
            }
            return finder;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {
                if(businesses[i].TotalRevenue == 0d)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            if(numbers.Length == 0)
            {
                return false;
            }

            int[] test = new int[numbers.Length];

            for(int i = 0; i < test.Length; i++)
            {
                test[i] = numbers[i];
            }

            Array.Sort(test);

            return Enumerable.SequenceEqual(test, numbers);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Length == 0)
            {
                return 0;
            }

            bool hasFoundEven = false;
            int sum = 0;

            for(var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum = sum + numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string str = "";
            string trimmed = "";

            for(int i = 0; i < words.Length; i++)
            {
                trimmed = String.Concat(words[i].Where(c => !Char.IsWhiteSpace(c)));

                if(trimmed.Length > 0)
                {
                    if (i == 0)
                    {
                        str = trimmed;
                    }
                    else
                    {
                        str = str + " " + trimmed;
                    }

                    if (i == words.Length - 1 && trimmed.Length > 0)
                    {
                        str = str + ".";
                    }
                }
                
                
            }
            return str;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            
            List<double> everyFourth = new List<double>();
            int counter = 0;

            if (elements == null)
            {
                return everyFourth.ToArray();
            }

            foreach (double element in elements)
            {
                counter++;
                if(counter == 4)
                {
                    everyFourth.Add(element);
                    counter = 0;
                }
                
            }
            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool canTheySum = false;

            for(int i = 0; i < nums.Length; i++)
            {
                for(int o = 0; o < nums.Length; o++)
                {
                    if(i == o)
                    {

                    }
                    else
                    {
                        if (nums[i] + nums[o] == targetNumber)
                        {
                            canTheySum = true;
                        }
                    }
                }
            }

            return canTheySum;
        }
    }
}
