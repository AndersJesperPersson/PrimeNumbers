namespace DatalogiLektion1
{
    using System.Collections.Generic;

    public static class PrimeCalculator
    {
        private static List<double> PrimeList = new List<double>();
        private static double Number = default;

        /// <summary>
        /// Checks if the number is prime. Requires a number that are bigger then 1 and can´t be a decimal.
        /// </summary>
        /// <param name="x">The number you want to check.</param>
        /// <returns>true if it´s a prime. Otherwise false.</returns>
        public static bool IsPrime(double x)  // Using double instead of int if user wants to add a number higher then 2147483647.
        {
            if (x > 1 && x % 1 == 0)

            {
                for (int i = 2; i < x - 1; i++)   // if a number can be divided with something more then it´s self and 1, then it´s not a prime.
                    if (x % i == 0) return false;

                return true;
            }
            else return false;
        }

        /// <summary>
        /// Adds the number to the List, if it dosen´t already exists and the list have less then 1000 elements.
        /// According to https://developer.salesforce.com/forums/?id=906F0000000MMUfIAO a list can´t hold more items.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>true if added, false if not.</returns>
        public static bool AddPrime(double x)
        {
            if (PrimeList.Contains(x))
            {
                return false;
            }
            else
            {
                PrimeList.Add(x);
                return true;
            }
        }

        /// <summary>
        /// Finds the next prime by sorting the list, pick the highest value in the list and then increase by one and check if its a prime.
        /// If not, increase the number with 1 again and do the check.
        /// </summary>
        /// <returns>the number of next prime.</returns>
        public static double NextPrime()
        {
            PrimeList.Sort();

            if (PrimeList.Count != 0) Number = PrimeList[PrimeList.Count - 1] + 1;

            while (!IsPrime(Number))
            {
                Number++;
            }

            return Number;
        }

        public static List<double> GetPrimes() => PrimeList;

        public static void SortPrimes() => PrimeList.Sort();
    }
}