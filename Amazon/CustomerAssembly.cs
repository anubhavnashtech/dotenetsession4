using System;


namespace Amazon
{

    internal class RateCalculator
    {
        public int Calculate (CustomerAssembly customerAssembly)
        {

            return 0; 

        }
    }

    public class CustomerAssembly
    {
        public int Id {get; set;}
        public int Age {get; set;}

        public void Promote()
        {

            var calc = new RateCalculator();

            var rating = calc.Calculate(this);

            System.Console.WriteLine("Customer is promoted");

        }

        public int CalculateRating()
        {
            return 0;
        }
    }
}