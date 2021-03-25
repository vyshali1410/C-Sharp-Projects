using System;
//Vyshali Mathukumalli - C0772238
namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Asking user to input choice of parking
            Console.WriteLine("Welcome to Parking at Airport");
            Console.WriteLine("Please select Long-Term or Short-Term Parking.");
            Console.WriteLine("For Long-Term Parking, Enter a");
            Console.WriteLine("For Short-Term Parking(Maximum-24hours), Enter b");
            string parking = Console.ReadLine();
            
            //If longterm parking ,ask user to input number of days,calculate and display the total amount of parking.
            if (parking == "a" || parking == "A")
            {
                Console.WriteLine("Enter number of days for parking:");
                int longparking = Convert.ToInt32(Console.ReadLine());
                int totallong;
                totallong = 25 + (40 * longparking);
                Console.WriteLine("The total parking Fee is : $" + totallong);
            }

            //If shortterm parking, ask user to input the number of hours, calculate and display the total amount of parking.
            if (parking == "b" || parking == "B")
            {
                Console.WriteLine("Enter number of hours parked(max 24 hours)");
                int shortparking = Convert.ToInt32(Console.ReadLine());
                int totalshort;

                //Calculation of total amount parking for 1 hour
                if (shortparking == 1)
                {
                    totalshort = 4;
                    Console.WriteLine("The Total Parking Fee is: $" + totalshort);
                }

                //Calculation of total amount parking for 24 hour
                else if (shortparking == 24)
                {
                    totalshort = 40;
                    Console.WriteLine("The Total Parking Fee is: $" + totalshort);
                }

                //Calculation of total amount parking if greater than 24 hour
                else if (shortparking > 24)
                {
                    Console.WriteLine("Please select Long term parking");
                }

                //Calculation of total amount parking for the user input more than 1 hour
                else
                {
                    totalshort = 4 + (3 * (shortparking - 1));
                    Console.WriteLine("The Total Parking Fee is: $" + totalshort);
                }
            }

        }
    }
}
