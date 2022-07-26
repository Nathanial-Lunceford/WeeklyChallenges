using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evens = 0;
            int odds = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens += numbers[i];
                }
                else
                {
                    odds += numbers[i];
                }
            }

            return evens - odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] newArray = new string[4];
            newArray[0] = str1;
            newArray[1] = str2;
            newArray[2] = str3;
            newArray[3] = str4;
            int shortFinder = newArray[0].Length;

            for (int j = 0; j < newArray.Length; j++)
            {
                if (newArray[j].Length < shortFinder)
                {
                    shortFinder = newArray[j].Length;
                }
            }

            return shortFinder;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] newArray = new int[4];
            newArray[0] = number1;
            newArray[1] = number2;
            newArray[2] = number3;
            newArray[3] = number4;
            int shortFinder = newArray[0];

            for (int j = 0; j < newArray.Length; j++)
            {
                if (newArray[j] < shortFinder)
                {
                    shortFinder = newArray[j];
                }
            }

            return shortFinder;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2
                && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out double result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int nonNullCount = 0;
            if (objs == null || objs.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCount++;
                }
                else
                {
                    nonNullCount++;
                }
            }

            if (nullCount > nonNullCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            List<int> listOfEvens = new List<int>();
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    listOfEvens.Add(numbers[i]);
                }
            }

            if (listOfEvens.Count == 0)
            {
                return 0;
            }
            else
            {
                foreach (int num in listOfEvens)
                {
                    sum = sum + num;
                }
            }

            if (sum == 0)
            {
                return 0;
            }
            else
            {
                double result = Convert.ToDouble(sum) / Convert.ToDouble(listOfEvens.Count);
                return result;
            }


        }

        public int Factorial(int number)
        {

            if (number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            List<int> numsAfterZero = new List<int>();
            int sum = 1;

            for (int i = 1; i <= number; i++)
            {
                numsAfterZero.Add(i);
            }

            foreach (int num in numsAfterZero)
            {
                sum = sum * num;
            }

            return sum;
        }
    }
}
