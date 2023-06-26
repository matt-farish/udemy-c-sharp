namespace MakingDecision
{
    class Program
    {

        static void Main(string[] args)
        {
            /*            Console.WriteLine("Enter the temperature:");
                        string temperature = Console.ReadLine();
                        int numTemp;

                        if (int.TryParse(temperature, out int number))
                        {
                            numTemp = number;
                        }
                        else
                        {
                            numTemp = 0;
                            Console.WriteLine("Value entered was not a number, 0 set as temperature:");
                        }

                        if (numTemp < 10)
                        {
                            Console.WriteLine("Take a coat.");
                        }

                        else if (numTemp == 10)
                        {
                            Console.WriteLine("Wear a jumper.");
                        }

                        else if (numTemp <= 25)
                        {
                            Console.WriteLine("Wear a t-shirt.");
                        }

                        else
                        {
                            Console.WriteLine("Wear shorts.");
                        }*/
            /*            Console.WriteLine("Enter your username:");
                        bool isAdmin = false;
                        bool isRegistered = true;
                        string userName = "";
                        userName = Console.ReadLine();

                        if (isRegistered && userName != "" && userName.Equals("admin"))
                        {
                            Console.WriteLine("Hi there, registered user");

                            Console.WriteLine("Hi there, " + userName);

                            Console.WriteLine("Hi there Admin!");
                        }

                        if (isAdmin ||  isRegistered)
                        {
                            Console.WriteLine("You are logged in.");
                        }*/

            /*// If statements challenge
            string passwordVerify;

            Console.WriteLine("Welcome to the user Registration system!");
            Console.WriteLine("Please enter your username for registration:");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter your password for registration:");
            string password = Console.ReadLine();

            Console.WriteLine("Thankyou! Now, to verify, enter your username and password again.");
            Console.WriteLine("Enter your username:");
            string usernameVerify = Console.ReadLine();
            

            if (userName == usernameVerify)
            {
                Console.WriteLine("Enter your password:");
                passwordVerify = Console.ReadLine();
                if (passwordVerify == password)
                {
                    Console.WriteLine("User successfully registered and logged in!");
                } else
                {
                    Console.WriteLine("Passwords entered do not match!");
                }
            }
            else
            {
                Console.WriteLine("Usernames entered do not match!");
            }*/

            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default: Console.WriteLine("How old are you then?");
                    break;
            }

            Console.Read();
        }
    }
}