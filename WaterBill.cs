using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string usageType;
            double volumeUsed = 0;
            double amount = 0;


            Console.WriteLine("*****************");
            Console.WriteLine("     WELCOME     ");
            Console.WriteLine("*****************");


            do
            {
                //Getting the usage Type
                Console.WriteLine("Kindly choose your usage type ?\n 1) Residential\n 2) Commercial\n 3) Industrial");

                usageType = Console.ReadLine();

                //Handle case senstivity
                usageType = usageType.ToLower();

            } while (usageType != "residential" && usageType != "commercial" && usageType != "industrial" && usageType != "1" && usageType != "2" && usageType != "3");

            // Getting the volume used 
            try
            {
                Console.WriteLine("Enter the volume used in cubic meters ?");

                volumeUsed = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Kindly Enter a numeric volume ?");
                volumeUsed = Convert.ToDouble(Console.ReadLine());
            }

            switch (usageType)
            {
                case "residential":
                case "1":
                    amount = volumeUsed * 25.00;
                    Console.Write("Your water bill is : ");
                    Console.WriteLine($"{volumeUsed} * 25.00 = ksh {amount}");
                    break;
                case "commercial":
                case "2":
                    amount = volumeUsed * 30.50;
                    Console.Write("Your water bill is :");
                    Console.WriteLine($"{volumeUsed} * 30.50 = ksh {amount}");
                    break;
                case "industrial":
                case "3":
                    amount = volumeUsed * 35.75;
                    Console.Write("Your water bill is :");
                    Console.WriteLine($"{volumeUsed} * 35.75 =  ksh {amount}.");
                    break;
            }
            Console.WriteLine("....Thank you for your time....");
        }
    }
}