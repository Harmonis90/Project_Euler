using System;

namespace Project_Euler
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            PrimeFactor.ProblemThree(600851475143);
            
            
        }
        /*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

        Find the sum of all the multiples of 3 or 5 below 1000.*/
        static int ProblemOne(int maxRange)
        {
            int result = 0;
            for (int i = 0; i < maxRange; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
            return result;
        }
        /*By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
     * find the sum of the even-valued terms.*/
        static int ProblemTwo()
        {
            int result = 0;
            int evensResult = 0;
            int counter = 0;
            int stop = 4000000; 
            while (true)
            {
                if(result < stop)
                {
                    result = Fibonacci(counter);
                    if(result % 2 == 0)
                    {
                        evensResult += result;
                    }
                    counter++;
                }
                else
                {
                    counter--;
                    break;
                }
            }
            Console.WriteLine(evensResult);
            return counter;
        }
        static int Fibonacci(int num)
        {
            int firstNum = 0;
            int secondNum = 1;
            int result = 0;
            if(num == 0)
            {
                return 0;
            }
            else if(num == 1)
            {
                return 1;
            }
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    result = firstNum + secondNum;
                    firstNum = secondNum;
                    secondNum = result;
                    
                }
                Console.WriteLine(result);
                return result;
            }
        }
        
    }


}
