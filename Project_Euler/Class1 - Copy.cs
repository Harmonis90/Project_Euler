using System;
using System.Collections.Generic;


public class PrimeFactor
{
    /*The prime factors of 13195 are 5, 7, 13 and 29.
        
        What is the largest prime factor of the number 600851475143 ?*/
    public static void ProblemThree(long n)
    {
        List<long> primeFactors = new List<long>();

        for(int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            while(n % i == 0)
            {
                primeFactors.Add(i);
                n /= i;
            }
           
        }
        primeFactors.Add(n);
      
        if (n > 2)
        {
            Console.WriteLine("The Answer is {0}", primeFactors[primeFactors.Count - 1]);
        }
       
    }
    public static bool IsPrime(int n)
    {
        
        if (n == 0) { return false; }
        if (n == 1) { return false; }
        if (n == 2) { return true; }
        if (n % 2 == 0) { return false; }
        for(int i = 3; i < n / 2; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
