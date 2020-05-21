using System;

namespace tutorialfollowalong
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = ("samuel thomas");
            // strings can appear listed, ie 'string name, car, house' ...
            // numbers
            int num = 6;
            num++;
            num--;
            Console.WriteLine(num / 2);
            Console.WriteLine(name);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Round(3.44));
            // numbers

            // getting user input
            Console.Write("Enter name :"); // .write allows input on the same line as the statement
            string nameinput = Console.ReadLine();
            Console.WriteLine($"Hello {nameinput}");
            //getting user input

            //building a calculator
            double numconv = Convert.ToInt32("45");
            Console.WriteLine("Enter number :");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number :");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            // buidling a calculator

            // arrays
            int[] arraynum = { 4, 8, 4, 6, 73 };
            arraynum[1] = 344; // this can update a specific location within an array

            // individually populating an array with strings
            string[] people = new string[3];
            people[0] = "Sam";
            people[1] = "Tom";

            Console.WriteLine(arraynum[0]);
            // arrays 

            // methods
            hola(name, 8);
            Console.WriteLine(cubemethod(5)); // printing a returning method

            int cubednumber = cubemethod(5);
            Console.WriteLine(cubednumber);
            // methods

            // if statements & bool
            bool ismale = true;
            bool ishappy = true;
            // && 'and' , || 'or'
            if (ismale && ishappy) // if statement applies if variable is true (both)
            {
                Console.WriteLine("Male True");
            } else if(!ismale) // ! = not operator
            {
                Console.WriteLine("not operator");
            } else
            {
                Console.WriteLine("Male false");
            }

            Console.WriteLine(getmax(5,7));

            // switch statements 
            Console.WriteLine(getday(0));

            // while loops

            int index = 1;
            do // do executes the code before checking the while condition
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 10);


            string hidden = "sam";
            string guess = "";

            while(guess != hidden)
            {
                Console.Write("Enter guess :");
                guess = Console.ReadLine();
            }
            Console.WriteLine("Word guessed.");
        }

        static void hola(string methodstr, int vol) // 'void returns no data'
        {
            Console.WriteLine($"Method function {methodstr}, you are {vol} years old.");
        }

        static int cubemethod(int cubnum) // any value can be returned, strings, doubles, ints etc...
        {
            int intoutput = cubnum * cubnum * cubnum;
            return intoutput; // as this is not a void a value must be returned to main
        }

        static int getmax(int numval1, int numval2)
        {
            int valresult;
            if (numval1 > numval2)
            {
                valresult = numval1;
            } else
            {
                valresult = numval2;
            }
            return valresult;
        }

        static string getday(int daynum)
        {
            string dayname;
            switch (daynum)
            {
                case 0:
                    dayname = "monday";
                    break;
                case 1:
                    dayname = "tuesday";
                    break;
                case 2:
                    dayname = "wensday";
                    break;
                case 3:
                    dayname = "thursday";
                    break;
                case 4:
                    dayname = "friday";
                    break;
                case 5:
                    dayname = "saturday";
                    break;
                case 6:
                    dayname = "sunday";
                    break;
                default:
                    dayname = "Invalid.";
                    break;
            }
            return dayname;
        }

    }
}
   