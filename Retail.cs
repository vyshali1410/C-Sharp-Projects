using System;
//Vyshali Mathukumalli - C0772238
namespace RetailCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking User to enter the sales for the month
            Console.WriteLine("Enter the Total Sales for the Month");
            int Sales = Convert.ToInt32(Console.ReadLine());

            //Initialize the amount of provincial,general sales tax and total sales tax with double data type. 
            double Provincial;
            double General;
            double Total;

            //Calculating the Provincial and General Tax
            Provincial = 0.07 * Sales;
            General = 0.04 * Sales;
            Total = Provincial + General;

            //Displaying the provincial,general sales tax and total sales tax
            Console.WriteLine("-----Monthly Sales Tax Report-----");
            Console.WriteLine("The Total Sales for the month:" + Sales);
            Console.WriteLine("The Amount of the Provincial Sales tax (PST):"+Provincial);
            Console.WriteLine("The amount of the General Sales tax (GST):"+General);
            Console.WriteLine("The Total Sales tax(PST plus GST):"+Total);


        }
    }
}
