namespace DatalogiLektion1
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public static class Prime
    {

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
    }
}
