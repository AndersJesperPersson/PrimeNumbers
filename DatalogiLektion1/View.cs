namespace DatalogiLektion1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class View
    {

        private bool KeepGoing = true;
        private double Number = 0;

        // Runs when starting the program. It´s called from Main - program. 
        public void Start()
        {
            Welcome();
            Menu();

        }

        // I reckon the code talk for itself. Basicly just a view-class with some light logic,
        // a few if-statements to run success/error messages.
        // Using the class PrimeCalculator to run the logic that the program is built upon. 
        private void Menu()
        {
            
            while (KeepGoing)
            {
                Console.WriteLine("\n");
                Console.WriteLine("      Menu");
                Console.WriteLine("1. Prime Check");
                Console.WriteLine("2. Display added prime numbers");
                Console.WriteLine("3. Add next prime");
                Console.WriteLine("4. Quit");

                MenuOptions();
            }
        }


        private void MenuOptions()
        {
            int.TryParse(Console.ReadLine(), out int menuChoice);

            switch (menuChoice)
            {
                case 1:
                    PrimeCheck();
                    break;

                case 2:
                    DisplayPrimes();
                    break;

                case 3:
                    AddNextPrime();
                    break;

                case 4:
                    KeepGoing = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please type in a correct value. Choose between 1-4");
                    break;
            }

           
        }

        private static void Welcome()
        {
            Console.WriteLine("********************");
            Console.WriteLine("*******Welcome******");
            Console.WriteLine("********************");
        }

        private void PrimeCheck()
        {
            Console.Clear();
            if (Input())
            {
                if (PrimeCalculator.AddPrime(Number)) SuccessMessage(Number);

                else ErrorMessage(Number);
            }
        }

        private void AddNextPrime()
        {
            Console.Clear();
            var nextPrime = PrimeCalculator.NextPrime();
            if (PrimeCalculator.AddPrime(nextPrime)) SuccessMessage(nextPrime);
        }

        private void DisplayPrimes()
        {
            Console.Clear();
            PrimeCalculator.SortPrimes();
            Console.WriteLine("Added Primes:");
            PrimeCalculator.GetPrimes().ForEach(prime => Console.WriteLine("* " + prime));
        }


        // using a try/catch to prevent a system crash if receiving wrong input. 
        private bool Input()
        {
            Console.Clear();

            while (KeepGoing)
            {

                Console.WriteLine("Please enter a number");
                try
                {
                    Number = double.Parse(Console.ReadLine());
                    if (PrimeCalculator.IsPrime(Number))
                    {
                        Console.WriteLine($"{Number} is a prime number");
                        return true;
                    }
                    else Console.WriteLine("It´s not a prime");

                }
                catch
                {
                    Console.Write("”wrong type of input, requires a number, please try again.");
                }
            }

            return false;


        }

        private void SuccessMessage(double nr) => Console.WriteLine($"You have added {nr} to the list");

        private void ErrorMessage(double nr) => Console.WriteLine($"{nr} already exist in the list");

    }
}
