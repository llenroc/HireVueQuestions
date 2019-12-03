using System;
using System.Collections.Generic;

namespace NeedleHaystack
{
    public static class Program
    {
        static void Main()
        {
            int haystackCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> haystack = new List<string>();

            for (int i = 0; i < haystackCount; i++)
            {
                string haystackItem = Console.ReadLine();
                haystack.Add(haystackItem);
            }

            int needleCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> needle = new List<string>();

            for (int i = 0; i < needleCount; i++)
            {
                string needleItem = Console.ReadLine();
                needle.Add(needleItem);
            }

            int res = findSequence(haystack, needle);

            Console.WriteLine(res);
        }

        public static int findSequence(List<string> haystack, List<string> needle)
        {
            int index = -1;
            int foundItemCount = 0;

            if(haystack.Count > 0 && needle.Count > 0)
            {
                int currentIndex = 0, lastIndex = 0;
                for(int i = 0; i < needle.Count; i++)
                {
                    lastIndex = currentIndex;
                    currentIndex = haystack.FindIndex(currentIndex, a => a.Contains(needle[i]));

                    if(i == 0) { index = currentIndex; };

                    if(currentIndex != -1 && ((currentIndex - lastIndex == 1) || i == 0))
                    {
                        foundItemCount++;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

            if (foundItemCount == needle.Count) { return index; } else { return -1; }
        }

    }
}
