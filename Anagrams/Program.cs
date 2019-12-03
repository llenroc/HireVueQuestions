using System;
using System.Collections.Generic;

namespace Anagrams
{
    public static class Program
    {
        ///Complete the 'funWithAnagrams' method below.
        public static List<string> funWithAnagrams(List<string> s)
        {
            List<string> toRemove = new List<string>();

            // Write your code here
            for(int i = 0; i < s.Count; i++)
            {
                if(i == 0) { continue; } //skip first

                char[] currCharArray = s[i].ToCharArray(); //get current string
                Array.Sort(currCharArray); // sort array
                string currString = new string(currCharArray).ToLower(); //cast as string

                //iterate through previous string
                for (int j = 0; j < i; j++)
                {
                    char[] prevCharArray = s[j].ToCharArray(); //get prev string
                    Array.Sort(prevCharArray); // sort array
                    string prevString = new string(prevCharArray).ToLower(); //cast as string

                    //check if strings equal
                    if(currString.Equals(prevString))
                    {
                        s.RemoveAt(i--); //pop current string & fix index
                        break; //stop iteration
                    }
                }
            }

            s.Sort();
            return s;
        }

        private static List<string> funWithAnagrams_Original(List<string> s)
        {
            // Write your code here
            //begin loop of all strings, first object is never an annogram of something before it, start at pos 1
            for (int pos = 1; pos < s.Count; pos++)
            {
                char[] currentStr = s[pos].ToCharArray();
                Array.Sort(currentStr);
                //for each string in the list, compare for anagram against all strings before it
                for (int checkPos = 0; checkPos < pos; checkPos++)
                {
                    char[] checkStr = s[checkPos].ToCharArray();
                    Array.Sort(checkStr);

                    //if two sorted arrays of characters from the two strings are equal, then they are an anagram
                    if (String.Join("", currentStr) == String.Join("", checkStr))
                    {
                        //anagram found, remove from list, adjust top loop int so we do not skip any strings
                        s.RemoveAt(pos);
                        pos--;

                        //leave current loop
                        break;
                    }
                }
            }

            //sort and return list
            s.Sort();
            return s;
        }

        ///Do not change Main method
        static void Main()
        {

            int sCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> s = new List<string>();

            for (int i = 0; i < sCount; i++)
            {
                string sItem = Console.ReadLine();
                s.Add(sItem);
            }

            List<string> result = funWithAnagrams(s);

            Console.WriteLine(String.Join("\n", result));
        }
    }

}
