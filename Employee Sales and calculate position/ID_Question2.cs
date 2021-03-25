using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a file assigning to a location
            string file = @"C:\Users\mathu\Desktop\name.txt";

            // if condition will check file exists or not , if file exists file will be deleted.
            if (File.Exists(file)) 
            { 
                File.Delete(file); 
            }

            //Open Streamwriter object
            using (StreamWriter output = File.AppendText(file))
            {
                //write to a file
                output.WriteLine(" Time     Position");
                output.WriteLine("            ");

                //for loop to calculate position for time 0 to 20; 
                for (double i = 0; i <= 20; i++)
                {
                    string text = i + "            " + calculatePosition(i);

                    output.WriteLine(text);

                }

                //Clos the object
                output.Close();

                //Read the contents of the file. 
                Console.WriteLine(File.ReadAllText(file));

            }
            
        
                
        }
        //calculatePostition method with double time as argument to calculate the position.
        static double calculatePosition(double time)
        {
            //Formula to calculate the position
            double position = 4 - (2 * time);

            //return the position to main method. 
            return position;
        }
    }
}
