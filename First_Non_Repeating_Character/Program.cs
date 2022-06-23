using System;
using System.Collections.Generic;
using System.Linq;

namespace First_Non_Repeating_Character
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingCharacter("abcdaefg"));
            Console.WriteLine(FirstNonRepeatingCharacter("faadabcbbebdf"));

            Console.WriteLine(FirstNonRepeatingCharacter_Approach2("abcdaefg"));
        }

        //O(nxn) time, O(1) space - n is the length of string
        public static int FirstNonRepeatingCharacter(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    return i;
                }
            }
            return -1;
        }


        //O(n) time, O(1) space
        //O(n) + O(n)

        public static int FirstNonRepeatingCharacter_Approach2(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    dict[str[i]] = dict[str[i]]  + 1;
                }
                else
                {
                    dict[str[i]] = 1;
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (dict[str[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
