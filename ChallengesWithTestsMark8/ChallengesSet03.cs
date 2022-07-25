using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }

            if (vals.Length == 0)
            {
                return false;
            }

            for(int i = 0; i < vals.Length; i++)
            {
                if(vals[i] == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            var nums = numbers.ToList();

            int sum = 0;

            if (numbers.Count() == 0)
            {
                return false;
            }

            foreach(int num in nums)
            {
                if(num % 2 != 0)
                {
                    sum += num;
                }
            }

            if(sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if(password.Length == 0 || password == null)
            {
                return false;
            }

            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;

            foreach(char c in password)
            {
                if(Char.IsUpper(c))
                {
                    containsUpper = true;
                }
                else if (Char.IsLower(c))
                {
                    containsLower = true;
                }
                else if (Char.IsDigit(c))
                {
                    containsNumber = true;
                }
            }

            if(containsUpper && containsLower && containsNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            if (val.Length == 0 || val == null)
            {
                return ' ';
            }

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (val.Length == 0 || val == null)
            {
                return ' ';
            }

            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if(nums.Length == 0 || nums == null)
            {
                return 0;
            }

            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] ints = new int[50];
            int counter = 0;

            for(int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    ints[counter] = i;
                    counter++;
                }
            }

            return ints;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
