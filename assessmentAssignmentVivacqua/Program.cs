using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessmentAssignmentVivacqua
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            Console.WriteLine("Please enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber < 10)
            {
                Console.WriteLine("This number is too small.");
            }
            else
            {
                Console.WriteLine("This number is big enough");
            }


            //Question 2
            float[] newFloatArray = { 1.2f, 3.5f, 6.7f, 12f, 15f };
            Console.WriteLine(newFloatArray[1]);
            //Question 3
            foreach(float number in newFloatArray)
            {
                Console.Write(number + " ");
            }


            Console.WriteLine();

            //Question 4
            Console.WriteLine("Please enter a number");
            int userNumberTwo = int.Parse(Console.ReadLine());

            switch (userNumberTwo)
            {
                case 1:
                    {
                        Console.WriteLine("Only one?");
                        break;
                    }
                case 100:
                    {
                        Console.WriteLine("100? That's a lot!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Input not recognized.");
                        break;
                    }
            }
        }
    }
}
