namespace DatalogiLektion1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class View
    {
        public void Start()
        {
                var keepGoing = true;
       
            Console.WriteLine("********************");
            Console.WriteLine("*******Welcome******");
            Console.WriteLine("********************");


            Console.WriteLine("Menu");
            Console.WriteLine("1. Prime Calculator");
            Console.WriteLine("2. Display added prime numbers");
            Console.WriteLine("2. Add next prime");


            while (keepGoing)
            {


                    Console.WriteLine("Please enter a number");
                try
                {
                    var number = double.Parse(Console.ReadLine());
                    if (Prime.IsPrime(number)) Console.WriteLine($"{number} is a prime number");
                    else Console.WriteLine("It´s not a prime");
                }
                catch (Exception e)
                {
                    Console.Write("”wrong type of input, requires a number, please try again.");
                }
            }
            


            
        }
}
