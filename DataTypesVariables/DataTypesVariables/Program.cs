namespace DataTypesVariables
{
    // Class names like ClientActivity
    class Program
    {

        // Method name like CalculateValue
        // Method arguments like firstNumber
        static void Main(string[] args)
        {
            // Local variables like itemCount

            // Use userControl instead of usrCtr

            // Don't use numbers at the start of variable names

            // Avoid:
            // String
            // Int32
            // Boolean

            /*            // Int, Double, Float
                        int num1;

                        num1 = 13;

                        int num2 = 23;
                        int sum = num1 + num2;

                        Console.WriteLine("num is " + num1);
                        Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

                        double d1 = 3.1415;
                        double d2 = 5.1;
                        double dDiv = d1 / d2;
                        Console.WriteLine("d1/d2 is " + dDiv);

                        float f1 = 3.1415f;
                        float f2 = 5.1f;
                        float fDiv = f1 / f2;

                        Console.WriteLine("f1/f2 is " + fDiv);*/

            /*            string myname = "matt";

                        string message = "My name is " + myname;

                        string capsMessage = message.ToUpper();
                        string lowerMessage = message.ToLower();   

                        Console.WriteLine(capsMessage);
                        Console.WriteLine(lowerMessage);
                        Console.Read();

                        Console.Read();*/
            /*
                        // Implicit conversion
                        int num = 12390532;
                        long bigNum = num;

                        float myFloat = 13.37f;
                        double myNewDouble = myFloat;


                        // Explicit conversion
                        // cast double to int
                        double myDouble = 13.37;
                        int myInt;

                        myInt = (int)myDouble;

                        // Type conversion
                        string myString = myDouble.ToString();
                        string myFloatString = myFloat.ToString();

                        bool sunIsShining = true;

                        string myBoolString = sunIsShining.ToString();*/
            /*
                        string myString = "15";
                        string mySecondString "13";

                        int num1 = Int32.Parse(myString);
                        int num2 = Int32.Parse(mySecondString);
                        int resultInt = num1 + num2;

                        Console.WriteLine(myBoolString);
                        Console.Read();*/
            /*
                        string stringForFloat = "0.85"; // datatype should be float
                        string stringForInt = "12345"; // datatype should be int

                        int num1 = Int32.Parse(stringForInt);
                        float num2 = float.Parse(stringForFloat);

                        Console.WriteLine(num1);
                        Console.WriteLine(num2);*/

            /*
                        int age = 23;
                        string name = "Matthew";

                        Console.WriteLine("Hello my name is {0}, I am {1} years old.", name, age);*/

            /*            string s1 = "This is a \"string\" with a backslash \\/ and a colon : ";
                        Console.WriteLine(s1);*/

            /*            string s1;
                        Console.WriteLine("Please enter your name and press enter.");
                        s1 = Console.ReadLine();
                        string s1Clean = s1.Trim();
                        string s1Substring = s1.Substring(2);


                        Console.WriteLine("In uppercase: " + s1.ToUpper());
                        Console.WriteLine("In lowercase: " + s1.ToLower());
                        Console.WriteLine(s1Clean);
                        Console.WriteLine(s1Substring);*/


            // Challenge String and its methods 2
            /*            Console.WriteLine("Enter a string here:");
                        string s1 = Console.ReadLine();

                        Console.WriteLine("Enter a character to search for:");
                        string searchChar = Console.ReadLine();

                        int firstOccurrence = s1.IndexOf(searchChar, 0);

                        Console.WriteLine("The first occurrence of {0}, in the word \"{1}\", is at {2}", searchChar, s1, firstOccurrence);

                        Console.WriteLine("Enter your first name");
                        string fName = Console.ReadLine();
                        Console.WriteLine("Enter your last name");
                        string lName = Console.ReadLine();

                        Console.WriteLine("Your full name is " + fName + " " + lName);*/

        

            Console.Read();
        }
    }
}