using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculater();
        }

        public static  void Calculater()
        {
            bool c = true;
            while (c)
            {
                

                Console.WriteLine("enter number 1 :");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("+ , - , / , * ");

                string oper = Console.ReadLine();

                Console.WriteLine("enter number 2 :");
                int number2 = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (oper)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero");
                        }
                        break;
                    default:
                        Console.WriteLine($"{oper} not ");
                        
                        break;
                }
                
                Console.WriteLine(result);
                Console.WriteLine("*******");



            }
                

            
        }

    }
}
