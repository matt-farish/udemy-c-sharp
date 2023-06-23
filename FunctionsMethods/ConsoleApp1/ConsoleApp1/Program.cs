using System;

namespace FunctionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            WriteSomething();
                        WriteSomethingSpecific("Hello there");
                        Console.WriteLine(Add(5, 2));
                        Console.WriteLine(Multiply(5, 2));*/

            /*            string name1 = "Ben";
                        string name2 = "Matt";
                        string name3 = "Sophie";

                        WriteGreeting(name1);
                        WriteGreeting(name2);
                        WriteGreeting(name3);*/

            /*Console.WriteLine(Calculate());*/
            /*            Console.WriteLine("Please enter a number:");
                        string userInput = Console.ReadLine();

                        try
                        {
                            int userInputAsInt = int.Parse(userInput);
                        }
                        catch (FormatException)
                        {

                            Console.WriteLine("Format exception, please enter the correct type next time.");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
                        }
                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("ArgumentNullException, the value was empty(null)");
                        }
                        finally
                        {
                            Console.WriteLine("This is called anyways!");
                        }*/

            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            // pre increment
            Console.WriteLine("num is {0}", ++num);

            Console.Read();
        }

        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method.");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void WriteGreeting(string name)
        {
            Console.WriteLine("Hi " + name + ", my friend!");
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number:");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number:");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            return result;
        }
    }
}