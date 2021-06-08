using System;

namespace Uniqueness
{
    class Program
    {
        static void CompareResultAndMax(ref int sum, ref int result)
        {
            if (sum > result)
            {
                result = sum;
            }
        }

        static void Uniqueness(char[] symbols, char mass, ref int sum, ref bool uniqueness)
        {
            for (int index = 0; index < symbols.Length; index++)
            {
                if (mass == symbols[index])
                {
                    sum = 0;
                    uniqueness = false;
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            //The first block of code that is responsible for the absence of duplicate characters
            string entry = args[0];
            char[] symbols = new char[entry.Length + 1];
            char[] mass = entry.ToCharArray();
            int result = 1;
            int sum = 1;

            for (int index1 = 1; index1 < entry.Length; index1++)
            {
                if (mass[index1] != mass[index1 - 1])
                {
                    sum++;
                }
                else
                {
                    if (sum > result)
                    {
                        result = sum;
                        sum = 1;
                    }
                }
            };

            CompareResultAndMax(ref sum, ref result);
            Console.WriteLine($"answer in the first block of code  {result}");

            //The second block of code, which is responsible for the complete uniqueness of the row
            sum = 0;
            result = 1;
            bool uniqueness = true;
            int index = 0;

            for (int index1 = 0; index1 < mass.Length; index1++)
            {

                Uniqueness(symbols, mass[index1], ref sum, ref uniqueness);

                if (uniqueness)
                {
                    symbols[index] = mass[index1];
                    index++;
                    sum++;
                }

                CompareResultAndMax(ref sum, ref result);
                uniqueness = true;
            }

            CompareResultAndMax(ref sum, ref result);
            Console.WriteLine($"answer in the second block of code  {result}");
            Console.ReadKey();
        }
    }
}