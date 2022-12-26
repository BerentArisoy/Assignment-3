using System;

namespace prime
{
    public class PrimeNumbers
    {

        public static void SieveOfEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                prime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed,
                // then it is a prime
                if (prime[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }
            // Print all prime numbers
            for (int i = 1; i <= n; i++)
            {
                if (prime[i] == true)
                    Console.Write(i + " ");
            }
        }
        public static void Main()
        {
            Console.Write("Insert an number = ");
            int n = int.Parse(Console.ReadLine());
            SieveOfEratosthenes(n);
        }
    }
}

