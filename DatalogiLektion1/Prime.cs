namespace DatalogiLektion1
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public static class Prime
    {

        static List<double> PrimeList = new List<double>();

        public static bool IsPrime(double x) 
        {
            if (x != null && x > 1)

            {
                for (int i = 2; i < x - 1; i++)
                    if (x % i == 0) return false;

                return true;
            }
            else return false;
        }

        public static bool  AddPrime (double x)
        {
            if (PrimeList.Contains(x))
            {
                return false;
            }
            else {
                PrimeList.Add(x);
                return true;
                    }
        }


        public static double NextPrime()
        {
            PrimeList.Sort();
            var number = PrimeList[PrimeList.Count - 1] + 1;

            while (!IsPrime(number))
            {
                number++;
            }

            return number;
        }

        public static List<double> GetPrimes() => PrimeList;

        public static void SortPrimes() => PrimeList.Sort();

        

    }
}
