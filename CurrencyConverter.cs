using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######The East Africa Currency converter######");
            double a = 24.84; //Kenyan shilling to Ugandan shilling
            double b = 0.40;  //Ugandan shilling to Kenyan shilling
            double c = 16.47; //Kenyan shilling to Tanzanian Shilling
            double d = 0.061; //Tanzanian shilling to Kenyan shilling
            double e = 1.51;  //Tanzanian shilling to Ugandan shilling
            double f = 0.66;  //Ugandan shilling to Tanzanian shilling
            Console.WriteLine("The current East African exchange rates are as follows:");
            Console.WriteLine();
            Console.WriteLine("1 Kenyan shilling=24.84 Ugandan shilling");
            Console.WriteLine("1 Kenyan shilling=16.47 Tanzanian shilling");
            Console.WriteLine("1 Ugandan shilling=0.40 Kenyan shilling");
            Console.WriteLine("1 Ugandan shilling=0.66 Tanzanian shilling");
            Console.WriteLine("1 Tanzanian shilling=0.061 Kenyan shilling");
            Console.WriteLine("1 Tanzanian shilling=1.51 Ugandan shilling");
            Console.WriteLine();
            Console.WriteLine();
            string choice = "";
            try
            {
                do
                {
                    Console.WriteLine("Enter currency to be converted.");
                    Console.WriteLine("1:Kenyan shilling");
                    Console.WriteLine("2:Tanzanian shilling");
                    Console.WriteLine("3:Ugandan shilling");
                    double input1 = Convert.ToDouble(Console.ReadLine());
                    if (input1==1||input1==2||input1==3)
                    {
                        Console.Write("Enter ammount: ");
                        double ammount = Convert.ToDouble(Console.ReadLine());

                        switch (input1)
                        {
                            case 1:
                                Console.WriteLine("Select currency to be converted to");
                                Console.WriteLine("1:Tanzanian shilling");
                                Console.WriteLine("2:Ugandan shilling");
                                double input2 = Convert.ToDouble(Console.ReadLine());
                                if (input2==1)
                                {
                                    Console.WriteLine("Ksh"+ammount +"= Tsh"+(ammount*c));
                                }
                                else if(input2==2)
                                {
                                    Console.WriteLine("Ksh"+ammount +"= Ush"+(ammount*a));
                                }
                                else
                                {

                                    Console.WriteLine("Not a valid choice. Try again");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Select currency to be converted to");
                                Console.WriteLine("1:Kenyan shilling");
                                Console.WriteLine("2:Ugandan shilling");
                                double input3 = Convert.ToDouble(Console.ReadLine());
                                if (input3==1)
                                {
                                    Console.WriteLine("Tsh"+ammount +"= Ksh"+(ammount*d));
                                }
                                else if(input3==2)
                                {
                                    Console.WriteLine("Tsh"+ammount +"= Ush"+(ammount*e));
                                }
                                else
                                {
                                    Console.WriteLine("Not a valid choice. Try again");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Select currency to be converted to");
                                Console.WriteLine("1:Kenyan shilling");
                                Console.WriteLine("2:Tanzanian shilling");
                                double input4 = Convert.ToDouble(Console.ReadLine());
                                if (input4==1)
                                {
                                    Console.WriteLine("Ush"+ammount +"= Tsh"+(ammount*b));
                                }
                                else if(input4==2)
                                {
                                    Console.WriteLine("Ush"+ammount +"= Tsh"+(ammount*f));
                                }
                                else
                                {
                                    Console.WriteLine("Not a valid choice. Try again");
                                }
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a valid choice. Try again");
                    }
                        Console.WriteLine("Do you wish to continue? Yes/No");
                        choice= Console.ReadLine();
                        choice= choice.ToUpper();
                    } while (choice=="YES");
            }catch(FormatException)
            {
                Console.WriteLine("Enter digits only. Close termial and try again.");

            }
            Console.WriteLine("KWAHERI!");

            Console.ReadLine();
        }
    }
}
