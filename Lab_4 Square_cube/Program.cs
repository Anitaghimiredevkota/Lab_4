using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Square_cube
{
    class Program
    {
        static void Main(string[] args)
        {
            string Choice = "y";
            int numSquare, numCube;
            Console.WriteLine("Learn your squares and cubes!");

            while(Choice =="y")
            { 
            Console.WriteLine("Enter an integer:");
            string num = Console.ReadLine();

            bool valid = int.TryParse(num, out int input);
                if (!valid)
                {
                    Console.WriteLine("Enter valid number");
                }
                else
                {

                    Console.WriteLine("{0} {1} {2} ", " Number ", " Square ", " Cube ");
                    Console.WriteLine(" ====== " + " ======= " + " ======= ");

                    for (int i = 1; i <= input; i++)
                    {
                        numSquare = i * i;
                        numCube = i * i * i;

                        Console.WriteLine("{0}         {1}         {2}", i , numSquare , numCube);                       
                    }
                    Console.WriteLine("Do you want to continue?(y/n)");
                    Choice = Console.ReadLine();
                }
            }


        }
    }
}
