using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

            var nums = numbers.ToList();

            if(numbers.Count() == 0)
            {
                return 0;
            }

            double smallest = nums[0];
            double largest = nums[0];

            foreach(double num in numbers)
            {
                if(num < smallest)
                {
                    smallest = num;
                }
                if(num > largest)
                {
                    largest = num;
                }
            }
            return smallest + largest;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1 == null || str2 == null)
            {
                return 0;
            }

            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else if (str1.Length == str2.Length)
            {
                return str1.Length;
            }

            return 0;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return sum;
            }

            if(numbers.Length == 0)
            {
                return sum;
            }

            
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return sum;
            }

            if (numbers.Length == 0)
            {
                return sum;
            }


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            bool isItOdd = false;

            if (numbers == null)
            {
                return isItOdd;
            }

            if (numbers.Count == 0)
            {
                return isItOdd;
            }

                foreach (int i in numbers)
                {
                    sum += i;
                }

                if(sum % 2 != 0)
                {
                    isItOdd = true;
                }

            return isItOdd;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number <= 0)
            {
                return 0;
            }

            if(number % 2 != 0)
            {
                number--;
            }

            return number / 2;
        }
    }
}
