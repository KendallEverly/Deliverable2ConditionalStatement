using System;

namespace Deliverable2ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for input
            Console.WriteLine("Please enter expected grade in ISM 4300");
            //try to validate user input
            try
            {
                //read user input
                string input = Console.ReadLine();
                //input variable parsed to int
                int grade = int.Parse(input);
                //if statement for grade input
                if (grade >= 98)
                {
                    Console.WriteLine("You got an A+");
                    Console.ReadKey(true);
                }
                else if (grade >= 92)
                {
                    Console.WriteLine("You got an A");
                    Console.ReadKey(true);
                }
                else if (grade >= 90)
                {
                    Console.WriteLine("You got an A");
                    Console.ReadKey(true);
                }
                else if (grade >= 88)
                {
                    Console.WriteLine("You got a B+");
                    Console.ReadKey(true);
                }
                else if (grade >= 82)
                {
                    Console.WriteLine("You got a B");
                    Console.ReadKey(true);
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("You got a B-");
                    Console.ReadKey(true);
                }
                else if (grade >= 78)
                {
                    Console.WriteLine("You got a C+");
                    Console.ReadKey(true);
                }
                else if (grade >= 72)
                {
                    Console.WriteLine("You got a C");
                    Console.ReadKey(true);
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("You got a C-");
                    Console.ReadKey(true);
                }
                else if (grade >= 68)
                {
                    Console.WriteLine("You got a D+");
                    Console.ReadKey(true);
                }
                else if (grade >= 62)
                {
                    Console.WriteLine("You got a D");
                    Console.ReadKey(true);
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("You got a D-");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("You got an F");
                    Console.ReadKey(true);
                }
            }
            //end of try
            catch
            {
                Console.WriteLine("Please type an integer");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
            //end of catch
        }
        //end of main
    }
    //end of class
}
//end of namespace
