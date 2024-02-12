using System;
using Amazon;

namespace acessmodifiers
{
    public class Customer
    {
        public int Id {get; set;}
        public int Age {get; set;}

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating ==0)
            System.Console.WriteLine("Promote to level 1");

            else System.Console.WriteLine("Not Promoted");

        }
        protected int CalculateRating()
        {
            return 0;
        }
    }

    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating();
        }
    }


    public class Program
        {
            static void Main(string[] args)
            {
                var customer = new Customer();

                var rating  = customer;

                var custAssem = new CustomerAssembly();

               // Amazon.RateCalculator rateCalculator = new RateCalculator();


            }
        }
}