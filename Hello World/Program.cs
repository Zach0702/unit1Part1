using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace currencyFormatConverter
{
    class currencyFormatConverter
    {
        static void Main(string[] args)
        {
            //variable declration
            string userInput;
            double dollar1; //amount 1
            double dollar2; //amount 2
            double dollar3; //amount 3
            double totalDollar; //variable to calculate total of 3 values entered
            double averageDollar; //stores the average of the 3 values
            double lowNumber; //stores lowest number
            double highNumber; //stores highest number
            

            //Display information to user
            Console.WriteLine("Please enter a dollar amount: ");
            
            //Storing dollar amounts 
            userInput = Console.ReadLine();

            //Converting input to double type
            dollar1 = Convert.ToDouble(userInput);

            //Display information to user
            Console.WriteLine("Please enter a dollar amount: ");

            //Storing dollar amounts 
            userInput = Console.ReadLine();

            //Converting input to double type
            dollar2 = Convert.ToDouble(userInput);

            //Display information to user
            Console.WriteLine("Please enter a dollar amount: ");

            //Storing dollar amounts 
            userInput = Console.ReadLine();

            //Converting input to double type
            dollar3 = Convert.ToDouble(userInput);

            Console.WriteLine();

            //Calculating total dollar amount
            totalDollar = dollar1 + dollar2 + dollar3;

            //Calulating average dollar amount
            averageDollar = totalDollar / 3;

            //Find lowest amount 
            if (dollar1 < dollar2 && dollar1 < dollar3)
            {
                lowNumber = dollar1;
            }

            else if (dollar2 < dollar1 && dollar2 < dollar3)
            {
                lowNumber = dollar2;
            }

            else
            {
                lowNumber = dollar3;
            }

            //Find highest number
            if (dollar1 > dollar2 && dollar1 > dollar3)
            {
                highNumber = dollar1;
            }

            else if (dollar2 > dollar1 && dollar2 > dollar3)
            {
                highNumber = dollar2;
            }

            else
            {
                highNumber = dollar3;
            }

            //Displaying information average, low number and high number
            Console.WriteLine("The Average of the 3 values entered is: ");
            Console.WriteLine(averageDollar);
            Console.WriteLine("The lowest number of the 3 values entered is: ");
            Console.WriteLine(lowNumber);
            Console.WriteLine("The highest number of the values entered is: ");
            Console.WriteLine(highNumber);
            Console.WriteLine();

            //Commands to write total in different cultures
            Console.WriteLine("Displaying total value in US, Swedish, Japanese, and Thai format: ");

            //US command
            Console.WriteLine("{0}{1}", "US: ", (totalDollar.ToString("C", CultureInfo.CurrentCulture)));

            //Swedish command
            Console.WriteLine("{0}{1}", "Swedish: ", (totalDollar.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE"))));

            //Japanese command
            Console.WriteLine("{0}{1}", "Japanese: ", (totalDollar.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"))));

            //Thai command
            Console.WriteLine("{0}{1}", "Thai: ", (totalDollar.ToString("C", CultureInfo.CreateSpecificCulture("th-TH"))));

            //Pause system
            Console.ReadKey();

        }
    }
}
