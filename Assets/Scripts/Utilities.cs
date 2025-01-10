using System.Linq;
namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
        public static string RepeatString(this string str, int numbersOfRepeats)
        {
            string newStr = "";

            for (int i = 0; i < numbersOfRepeats; i++)
            {
                newStr += str;
            }
            return newStr;
        }
    }
}