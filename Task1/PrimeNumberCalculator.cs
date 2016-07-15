using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class PrimeNumberCalculator
    {
        public void Run()
        {
            List<int> primeNumbers = new List<int>();
            int sum = 0;

            Console.WriteLine("Enter the length of the list :");
            int diapason = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGenerated list:");

            int i = 2;
            while (diapason > primeNumbers.Count())
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                    Console.Write(i + " ");
                }
                i++;
            }

            Console.WriteLine("\n\nThe integer part of the sum of all elements of this list divided by index of this element+1 :\n");
            sum = Calculation(primeNumbers);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        private bool IsPrime(int number)
        {
            for (int i = 2; i * i <= number; i++)
                if ((number % i) == 0) return false;
            return true;
        }

        private int Calculation(List<int> simpleNumbers)
        {
            double sum = 0;
            double index = 1;

            foreach (var item in simpleNumbers)
            {
                sum += (item / index);
                index++;
            }
            return (int)Math.Floor(sum);
        }
    }
}
