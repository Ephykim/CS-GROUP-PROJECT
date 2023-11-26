using System;

namespace PAYE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basicSalary = 0,
                allowances = 0,
                commissions = 0,
                deductions = 0,
                totalTaxableIncome = 0,
                grossIncome=0;
            string choice = "";

            //displaying welcome message
            Console.WriteLine("\t***************************************");
            Console.WriteLine("\tWELCOME TO THE PAYE CONSOLE APPLICATION");
            Console.WriteLine("\t***************************************");
            Console.WriteLine("");
            Console.WriteLine("The current Tax Rates are as follows:");
            Console.WriteLine();
            Console.WriteLine("Monthly Income \t\t\t\t Tax Rates");
            Console.WriteLine("-------------- \t\t\t\t ---------");
            Console.WriteLine("Up to 24,000 \t\t\t\t 10%");
            Console.WriteLine("24,001 - 40,000 \t\t\t 15%");
            Console.WriteLine("40,001 - 60,000 \t\t\t 20%");
            Console.WriteLine("60,001 - 100,000 \t\t\t 25%");
            Console.WriteLine("100,001 - 150,000 \t\t\t 30%");
            Console.WriteLine("150,001 - 250,000 \t\t\t 35%");
            Console.WriteLine("Over 250,000 \t\t\t\t 40%");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
            Console.Clear();

            do
            {
                //invocking taxable income method
                double incomeToBeTaxed = TaxableIncome(basicSalary, allowances, commissions, deductions,grossIncome, totalTaxableIncome);
                Console.WriteLine($"Your total taxable income is: Ksh {incomeToBeTaxed}");
                Console.WriteLine();

                //invocking tax calculation method
                 double netTax = Tax(incomeToBeTaxed);
                 Console.Write($"Your total net tax for this month is:Ksh {netTax}");
                 Console.WriteLine();
                Console.WriteLine("We hope you enjoyed our service!");
                Console.WriteLine();
                Console.Write("Do you wish to continue?(Yes/No): ");
                choice = Console.ReadLine();
                choice = choice.ToLower();
                if (choice == "yes")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please press any key to exit..");
                }
            }
            while (choice == "yes");
            Console.ReadKey();
        }
        //method for calculating taxable income
        static double TaxableIncome(double basicSalary, double allowances, double commissions, double deductions, double grossIncome, double totalTaxableIncome)
        {
            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        Console.WriteLine("Please input your:");
                        Console.Write("\t Basic Salary:Ksh ");
                        basicSalary = double.Parse(Console.ReadLine());
                        while (basicSalary < 0)
                        {
                            Console.WriteLine("Basic salary cannot be less than 0!");
                            Console.Write("\t Basic Salary:Ksh ");
                            basicSalary = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine();
                        Console.Write("\t Total monthly allowances (Input 0 if there are no allowances):Ksh ");
                        allowances = double.Parse(Console.ReadLine());
                        while (allowances < 0)
                        {
                            Console.WriteLine("Allowance cannot be less than 0!");
                            Console.Write("\t Total monthly allowances (Input 0 if there are no allowances):Ksh ");
                            allowances = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine();
                        Console.Write("\t Total monthly commissions (Input 0 if there are no commissions):Ksh ");
                        commissions = double.Parse(Console.ReadLine());
                        while (commissions < 0)
                        {
                            Console.WriteLine("Commission cannot be less than 0!");
                            Console.Write("\t Total monthly commissions (Input 0 if there are no commissions):Ksh ");
                            commissions = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine() ;
                        grossIncome = basicSalary + allowances + commissions;
                        Console.Write($"Your total gross income is :Ksh {grossIncome}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Input your Total monthly deductions (Input 0 if there are no deductions):Ksh ");
                        deductions = double.Parse(Console.ReadLine());
                        while (deductions < 0 || deductions > grossIncome)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Deductions cannot be less than 0 and or greater than your Gross Income!!");
                            Console.WriteLine();
                            Console.Write("Input your Total monthly deductions (Input 0 if there are no deductions):Ksh ");
                            deductions = double.Parse(Console.ReadLine());
                        }
                        
                        Console.WriteLine();
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("One of the inputs is invalid! Your input must be a number");
                        Console.WriteLine("Please correct it and try again.");
                        Console.WriteLine();
                    }
                }
                //Console.WriteLine("Please try again next time!");
                break;
            }
            totalTaxableIncome = grossIncome - deductions;
            return totalTaxableIncome;
        }
        //method for calculating tax
        static double Tax(double incomeToBeTaxed)
        {
            if (incomeToBeTaxed <= 24000)
            {
                return incomeToBeTaxed * 10 / 100;
            }
            else if (incomeToBeTaxed > 24000 && incomeToBeTaxed <= 40000)
            {
                return incomeToBeTaxed * 15 / 100;
            }
            else if (incomeToBeTaxed > 40000 && incomeToBeTaxed <= 60000)
            {
                return incomeToBeTaxed * 20 / 100;
            }
            else if (incomeToBeTaxed > 60000 && incomeToBeTaxed <= 100000)
            {
                return incomeToBeTaxed * 25 / 100;
            }
            else if (incomeToBeTaxed > 100000 && incomeToBeTaxed <= 150000)
            {
                return incomeToBeTaxed * 30 / 100;
            }
            else if (incomeToBeTaxed > 150000 && incomeToBeTaxed <= 250000)
            {
                return incomeToBeTaxed * 35 / 100;
            }
            else
            {
                return incomeToBeTaxed * 40 / 100;
            }
        }
    }
}
