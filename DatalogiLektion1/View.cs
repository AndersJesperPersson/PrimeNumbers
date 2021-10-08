namespace DatalogiLektion1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class View
    {

       private bool KeepGoing = true;
       private  double Number = 0;
        public void Start()
        {
            

            Console.WriteLine("********************");
            Console.WriteLine("*******Welcome******");
            Console.WriteLine("********************");

            while (KeepGoing)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Prime Calculator");
                Console.WriteLine("2. Display added prime numbers");
                Console.WriteLine("3. Add next prime");
                Console.WriteLine("4. Quit");
                int.TryParse(Console.ReadLine(), out int menuchoice);


                switch (menuchoice)
                {
                    case 1:
                        if (Input()) Prime.AddPrime(Number);
                        break;

                    case 2:
                        Prime.SortPrimes();
                        DisplayPrimes();
                        break;

                    case 3:
                        Prime.SortPrimes();
                        var nextPrime = Prime.NextPrime();
                        Prime.AddPrime(nextPrime);
                        break;

                    case 4:
                        KeepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Please type in a correct value. Choose between 1-4");
                       break;
                }
            }

        }

        private void DisplayPrimes() => Prime.GetPrimes().ForEach(prime=>Console.WriteLine(prime));
        

        private bool Input()
        {

            while (KeepGoing)
            {

                Console.WriteLine("Please enter a number");
                try
                {
                    Number= double.Parse(Console.ReadLine());
                    if (Prime.IsPrime(Number))
                    {
                        Console.WriteLine($"{Number} is a prime number");
                        return true;
                    }
                    else Console.WriteLine("It´s not a prime"); 
                           
                }
                catch (Exception e)
                {
                    Console.Write("”wrong type of input, requires a number, please try again.");
                }
            }

            return false;
            

        }
    }
}
