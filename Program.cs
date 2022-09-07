using System;

namespace Csharp.B
{
    class Program
    {
        static void Main(string[] args)
        {
             //Week1 Assignment
            var myName = "Oladejo Abimbola";
            string Track = "Backend Dev Track";
            Console.WriteLine("Hello, my name is " + myName + " I am in " + Track + " of Wella Schools.");
            var R = "My reason for learning Backend Development is because I will like be a software dev and also gain " +
                "\nmore knowlege in programmming.\t Hopefully someday I get to develop my own website.";
            Console.WriteLine(R);

            //Assignment 2- Declare 10 variables with different data types, show example of implicit and explicit conversion
            string welcome = "Welcome to my first C# program";
            char letStart = 'S';
            bool isCSharpEasy = true;
            bool a = 111 >= 101;
            int myFavouriteNumber = 31;
            float b = 119 / 4;
            float b1 = 100e3F;
            long b2 = 143508600000;
            double c = 12e24;
            char end = 'E';

            Console.WriteLine(welcome);
            Console.WriteLine(letStart);

            Console.WriteLine(isCSharpEasy);
            Console.WriteLine(a);
            Console.WriteLine(myFavouriteNumber);
            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(c);
            Console.WriteLine(end);

            //implicit and explicit
            int myLevel = 4;
            char myLevelChar = (char)myLevel;  //explicit

            float myCpga = 4.98F;
            double m = myCpga;

            int courses = 11;
            float n = courses;
            long l = courses;

            Console.WriteLine(myLevel);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(l);
            
            //Week 3
            int myAge = 20;
            Console.WriteLine(myAge);
            myAge += 2;
            Console.WriteLine(myAge);
            int firstRemainder = 88 % 5;
            Console.WriteLine(firstRemainder);

            Console.WriteLine("This is a Calculator App");
            Console.Write("Type in your first number: ");
            string firstNumber = Console.ReadLine();
            //int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Type in your second number: ");
            string secondNumber = Console.ReadLine();
            string result = firstNumber + secondNumber;

            Console.WriteLine("The answer is " + result);

            //Week4
            //<<<Decision making/Conditionals>>
            if (false)
            {
                Console.WriteLine("The statement is true");
            }
            else if (true)
            {
                Console.WriteLine("The second statement is false");
            }
            else
            {
                Console.WriteLine("The statement is false");
            }

            //<Realtional Operators>>
            if (2 == 5)
            {
                Console.WriteLine("They are equal");
            }
            else if (2 > 1)
            {
                Console.WriteLine("Two is greater than 1");
            }
            else if (5 >= 5)
            {
                Console.WriteLine("5 is greater than or equal to 5");

            }
            else
            {
                Console.WriteLine("They are not equal");
            }

            //<<<Logical operator>>>
            if (true && true)
            {
                Console.WriteLine("AND operator is true");
            }
            if (false || false)
            {
                Console.WriteLine("OR operator is false");
            }

            if (true && true)
            {
                Console.WriteLine("1 is true");
            }
            else
            {
                Console.WriteLine("1 is false");
            }

            //Week 3
            int myAge = 20;
            Console.WriteLine(myAge);
            myAge += 2;
            Console.WriteLine(myAge);
            int firstRemainder = 88 % 5;
            Console.WriteLine(firstRemainder);

            Console.WriteLine("This is a Calculator App");
            Console.Write("Type in your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            //int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Type in your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int result = firstNumber + secondNumber;

            Console.WriteLine("The answer is " + result);

            //Week4
            //<<<Decision making/Conditionals>>
            /*if (false)
            {
                Console.WriteLine("The statement is true");
            }
            else if (true)
            {
                Console.WriteLine("The second statement is false");
            }
            else
            {
                Console.WriteLine("The statement is false");
            }*/

            //<Realtional Operators>>
            /*   if (2 == 5)
               {
                   Console.WriteLine("They are equal");
               }
               else if (2 > 1)
               {
                   Console.WriteLine("Two is greater than 1");
               }
               else if (5 >= 5)
               {
                   Console.WriteLine("5 is greater than or equal to 5");
               }
               else
               {
                   Console.WriteLine("They are not equal");
               }
               //<<<Logical operator>>>
               if (true && true)
               {
                   Console.WriteLine("AND operator is true");
               }
               if (false || false)
               {
                   Console.WriteLine("OR operator is false");
               }
               if (true && true)
               {
                   Console.WriteLine("1 is true");
               }
               else
               {
                   Console.WriteLine("1 is false");
               }*/

            //A simple App
            Console.WriteLine("Welcome to Veepay");
            Console.Write("Will you like to sign up: ");
            string signup = Console.ReadLine();
            if (signup == "Yes")
            {
                Console.WriteLine("Click the button below to create an account.");
                Console.WriteLine("Input your information.");

                Console.Write("Name:  ");
                string name = Console.ReadLine();

                Console.Write("How old are you? ");
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.Write("Phone Number:  ");
                    string phoneNumber = Console.ReadLine();
                }
                else
                {
                    Console.Write("You are not allowed to create an account.");
                }
                Console.Write("Account Number: ");
                string acctNo = Console.ReadLine();
                Console.Write("Create a password: ");
                string password = Console.ReadLine();
                Console.WriteLine("Account created, login to your account");
            }
            else
            {
                Console.WriteLine("Already have an account?, then Sign in now.");
                Console.Write("Email Address or Mobile Number:  ");
                string emailAddress = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                Console.WriteLine("Sign in");
            }

            //Assignment Lab 3
            Console.WriteLine("Input your first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            int answer = firstNum + secondNum;
            if (answer < 100)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("Enter the Number to check prime: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                if (number <= 1)
                {
                    if (number == 2)
                    {
                        Console.WriteLine("It is a prime number");
                    }
                    else
                    {
                        Console.WriteLine("It is not a prime number");
                    }
                    //Console.WriteLine("It is not a prime number");
                }
                else
                {
                    Console.WriteLine("It is not a prime number");
                }
                //Console.WriteLine("It is not a prime number");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }

            ///<<<Week 5>>>>
            //Switch statement
            Console.Write("What state are you from...? ");
            string state = Console.ReadLine();
            switch (state)
            {
                case "Lagos":
                case "Ogun":
                    Console.WriteLine("You are from the west");
                    break;
                case "Delta":
                case "Rivers":
                    Console.WriteLine("You are from the south");
                    break;
                case "Kaduna":
                case "Abuja":
                    Console.WriteLine("You are from the North");
                    break;
                case "Abia":
                case "Imo":
                    Console.WriteLine("You are from the east");
                    break;

                default:
                    Console.WriteLine("Default");
                    break;
            }

            Console.WriteLine("What is your score? ");
            int score = int.Parse(Console.ReadLine());
            switch (score)
            {
                case int scoreFromUser when scoreFromUser >= 70:
                    Console.WriteLine("You had an A");
                    break;
                case int scoreFromuser when scoreFromuser >= 60:
                    Console.WriteLine("You had a B");
                    break;
                case int scoreFromUser when scoreFromUser >= 40:
                    Console.WriteLine("You had a C");
                    break;
                default:
                    Console.WriteLine("You had an F");
                    break;
            }

            //<<Loop>>
            //For Loop
            //While Loop
            //Do While Loop
            Console.Write("Give me a num ...");
            int num = int.Parse(Console.ReadLine());

            //for loop
            for (int i = 0; i <= num; i++)
            {
                if (i >= 10 && i <= 20) //do not print any number between number 10 and 20
                {
                    continue;
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is an even number ");
                }
                else if (i > 50)
                {
                    break;
                }

            }

            //while loop
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 40);


        }

        }
    }
}
