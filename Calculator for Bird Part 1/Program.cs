using System;

namespace Calculator_for_Bird_Part_1
{
    class Program
    {
        static void OperatorSwitch(string opo, int realNum1, int realNum2)
        {
            switch (opo)
            {
                case "+":
                    Console.WriteLine(realNum1 + realNum2);
                    Success();
                    break;

                case "-":
                    Console.WriteLine(realNum1 - realNum2);
                    Success();
                    break;

                case "/":
                    Console.WriteLine(realNum1 / realNum2);
                    Success();
                    break;

                case "*":
                    Console.WriteLine(realNum1 * realNum2);
                    Success();
                    break;

                case "^":
                    Console.WriteLine(realNum1 ^ realNum2);
                    Success();
                    break;

                case "%":
                    Console.WriteLine(realNum1 % realNum2);
                    Success();
                    break;

                default:
                    Console.WriteLine("Operator is not a valid operator");
                    break;
            }
            static void Success()
            {
                Console.WriteLine("Mathematics!");
                Console.WriteLine("With this we can improve the pipeline!");
            }
        }
        static void Main(string[] args)
        {
            try 
            { 
                Console.WriteLine("You stumbled across a calculator in a cave. A message is on the top. ");
                Console.WriteLine("Read? \nPress the action button to continue.");
                Console.ReadLine();
                
                Console.WriteLine("\"Chris, enter the numbers\"");
                
                Console.Write("Gimme the number, bird: ");
                string num1 = Console.ReadLine();
                int realNum1 = Convert.ToInt32(num1);          

                Console.Write("Gimme an operator, tweeter: ");
                string opo = Console.ReadLine();

                Console.Write("Gimme the 2nd number, birdie: ");
                string num2 = Console.ReadLine();
                int realNum2 = Convert.ToInt32(num2);

                OperatorSwitch(opo, realNum1, realNum2);                                
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
