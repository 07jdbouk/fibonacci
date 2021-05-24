using System;

namespace recurseFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Recursive --------------");
            RecursiveFibonacci sequence = new RecursiveFibonacci(3);

            Console.WriteLine("-------------- Iterative --------------");
            IterativeFibonacci sequence1 = new IterativeFibonacci(4);
        }
    }

    class RecursiveFibonacci
    {
        // Fibonacci is previous two numbers added together
        int num, prevNum;

        public RecursiveFibonacci(int num1)
        {
            // prevNum = starting number, num = prevNum + prevNum
            prevNum = num1;
            Console.WriteLine(prevNum + "     <-- starting number");

            num = num1 * 2;
            Console.WriteLine(num + "     <-- starting number + starting number");

            nextNum(num);
        }

        public int nextNum(int number)
        {
            // Add two previous numbers together to create next number
            int next = num + prevNum;
            prevNum = num;
            num = next;

            // Outputs next number
            Console.WriteLine(next);

            // If next number exceeds 100, stop
            if (next <= 100)
                return nextNum(num);

            else
                return -1; 
        }
    }

    class IterativeFibonacci
    {
        public IterativeFibonacci(int num)
        {
            // num1 = starting number, num2 = num1 + num1
            int num1 = num;
            Console.WriteLine(num1 + "     <-- starting number");

            int num2 = num * 2;
            Console.WriteLine(num2 + "     <-- starting number + starting number");

            while (true)
            {
                // total = previous two numbers added together
                int total = num1 + num2;
                Console.WriteLine(total);

                // update previous numbers
                num1 = num2;
                num2 = total;

                // if num1 exceeds 100, stop
                if (num1 > 100)
                {
                    break;
                }
            }
        }
    }
}
