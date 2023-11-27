using System;


namespace Power_Bill_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userOption, choice = "";
            double tarrifs = 0;
            int i;
            double consumption;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\t****************************************");
            Console.WriteLine("\t  Welcome to the Power Bill Calculator");
            Console.WriteLine("\t****************************************");
            
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
            do
            {
                //prompting user to choose usage type
                Console.WriteLine("\t Please choose the type of service");
                Console.WriteLine("");
                Console.WriteLine("i.e \t Residential\n \t Commercial\n  \t Industrial ");
                Console.WriteLine();
                Console.Write("Service: ");

                userOption = Console.ReadLine();
                userOption = userOption.ToLower();

                //error handling if no correct usage type is fed in
                while (userOption != "residential" && userOption != "commercial" && userOption != "industrial")
                {
                    for (i = 2; i > 0; i--)   //prompting user to input usage type for a limited number of times
                    {
                        Console.Beep();
                        Console.WriteLine("Please choose between residential, commercial and industrial");
                        Console.WriteLine("You have " + i + " chances left!");
                        Console.WriteLine();
                        Console.Write("Service: ");
                        userOption = Console.ReadLine();
                        userOption = userOption.ToLower();
                        if (userOption == "residential" || userOption == "commercial" || userOption == "industrial")
                        {                               //if conditions are satisfied
                            break;
                        }
                    }
                    break;
                }
                //output when usage type conditions are satisfied
                if (userOption == "residential" || userOption == "commercial" || userOption == "industrial")
                {
                    Console.Clear();
                    Console.WriteLine(" \t---------------------------------");
                    Console.WriteLine(" \t Welcome to " + userOption + " services");
                    Console.WriteLine(" \t---------------------------------");

                    double allServices = Services(userOption, tarrifs);   //calling the tarrif rates' function

                    Console.WriteLine("The current tarrifs are: ");
                    Console.WriteLine($"\t \t \t{allServices} Ksh/Kwh");
                    Console.WriteLine();
                    //prompting user for consumption amount for a limited number of trials
                    while (true)
                    {
                        for (i = 3; i > 0; i--)
                        {
                            Console.Write("Enter your power consumption for this month: ");
                            try
                            {
                                consumption = double.Parse(Console.ReadLine());//convert value entered by user into double 
                                                                               // store it in consumption
                                Console.WriteLine();
                                double billAmount = TotalAmount(consumption, userOption); //calling the total bill function into bill amount
                                Console.WriteLine($"The total bill amount is: Ksh {billAmount}");
                                Console.WriteLine();
                                Console.WriteLine("Thank you for placing your trust in us!");
                                break;
                            }
                            catch (FormatException)  //handling format exception (if amount is not a number)
                            {
                                Console.Beep();
                                Console.WriteLine("Invalid input! Input must be a number!");
                                Console.WriteLine();
                            }
                        }
                        break;
                    }
                }
                else  //output when usage type conditions are not satisfied       
                {
                    Console.WriteLine("You have exceeded the maximum number of trials");
                    Console.WriteLine();
                    Console.WriteLine("Please try Again next time!");
                }
                Console.WriteLine();
                Console.Write("Do you wish to continue (Yes/No): ");
                choice = Console.ReadLine();
                choice = choice.ToLower();

                if (choice == "yes")
                {
                    Console.Clear();
                }
            } while (choice == "yes");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        //function calculating the total bill
        static double TotalAmount(double consumption, string userOption)
        {
            const double residential = 12.50; //tarriffs in KES per KWH
            const double commercial = 15.75;
            const double industrial = 18.90;

            while (consumption < 0) //handling argument exception( if amount is a negative number)
            {
                Console.Beep();
                Console.Write("Power Consumption cannot be less than 0: ");
                consumption = double.Parse(Console.ReadLine());//convert value entered by user into double 
                                                               // store it in consumption
            }
            if (userOption == "residential")
            {
                return (residential * consumption);
            }
            else if (userOption == "commercial")
            {
                return (commercial * consumption);
            }
            else
            {
                return (industrial * consumption);
            }
        }

        //function returning tarriff rates accordingly
        static double Services(string userOption, double tarrifs)
        {
            if (userOption == "residential")
            {
                tarrifs = 12.50;
                return tarrifs;
            }
            else if (userOption == "commercial")
            {
                tarrifs = 15.75;
                return tarrifs;
            }
            else
            {
                tarrifs = 18.90;
                return tarrifs;
            }
        }
    }
}




