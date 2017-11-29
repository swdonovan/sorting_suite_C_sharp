using System;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {9,2,6,2,10,-1,35,-66,-16};
            int plus_one;
            for (int a = 0; a <= numbers.Length - 1; a++)
            {
                for (int f = a+1; f <= numbers.Length - 1; f++)
                {
                    if (numbers[a] > numbers[f])
                    {
                        plus_one = numbers[a];
                        numbers[a] = numbers[f];
                        numbers[f] = plus_one;
                    }
                }                
            }
            for (int write = 0; write < numbers.Length; write++)
            {
                Console.WriteLine(numbers[write]);
            }
        }
    }
}
