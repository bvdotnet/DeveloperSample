using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * GetFactorial(n - 1);
            }
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items.Length == 0)
            {
                return "";
            }
            else if (items.Length == 1)
            {
                return items[0];
            }
            else
            {
                string result = items[0];
                for (int i = 1; i < items.Length - 1; i++)
                {
                    result += ", " + items[i];
                }
                return result + " and " + items[items.Length - 1];
            }
        }
    }

}