using System;
using System.Linq;
using System.Xml.Schema;

namespace Assignment
{
    class CoinInput
    {
        public int[] denomination = { 1, 5, 10, 25, 50, 100, 200 };
        public int[] numofcoins
        {
            get;
        }
        public CoinInput()
        {
            numofcoins = new int[7];
        }

        public void getcoins()
        {
            for (int i = 0; i < 7; i++)
            {
                if (denomination[i] < 100)
                {
                    Console.WriteLine("Number of coins for ¢" + denomination[i] + ":");
                }
                else
                {
                    Console.WriteLine("Number of coins for $" + denomination[i] / 100 + ":");
                }
                numofcoins[i] = int.Parse(Console.ReadLine());
            }
        }



    }
    class CoinCalculate
    {
        const double fee = 0.15;
        double subtotal;
        double total = 0;
        int numofcoins = 0;
        public void calculate(int[] denomination, int[] coin)
        {

            Console.WriteLine("\t");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", "Coins", "Amount", "Total");
            for (int i = 0; i < denomination.Length; i++)
            {
                if (coin[i] > 0)
                {
                    subtotal = (denomination[i] * coin[i]) * 0.01;
                    total = total + subtotal;
                    numofcoins = numofcoins + coin[i];
                }
                if (denomination[i] < 100)

                { 

                    Console.WriteLine("{0,-10}{1, -2}{2,-10}{3,-10}", denomination[i] + "¢", "x", coin[i], subtotal);

                }

                else

                {

                    Console.WriteLine("{0,-10}{1, -2}{2,-10}{3,-10}", "$" + (denomination[i] / 100), "x", coin[i], subtotal);

                }

            }
            double feeamount = total * fee;
            Console.WriteLine("\t");
            Console.WriteLine("*******************************");
            Console.WriteLine("Number of coins " + numofcoins);

            Console.WriteLine("Fee Amount " + feeamount);

            Console.WriteLine("Total value " + (total - feeamount));
            Console.WriteLine("*******************************");


        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            CoinInput input = new CoinInput();
            input.getcoins();

            CoinCalculate cal = new CoinCalculate();
            cal.calculate(input.denomination, input.numofcoins);

        }

    }

}
