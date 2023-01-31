using System;
using System.ComponentModel;
namespace Deliverable_3_Ilterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while (true)
            {
                Console.WriteLine("Enter an number between 1 and 100: ");
                input = int.Parse(Console.ReadLine());

                if(input >= 1 && input <= 100)
                {
                    break;
                }
            }

            while(true)
                {


                Console.WriteLine("Specify the series tye: Even or Odd ");
                series = Console.ReadLine();

                if(series == "Even" || series == "Odd")
                {
                    break;
                }

            }

            if (series == "Odd")
            {
                Console.WriteLine("You have selected " + series + " Series.The number between 0 and " + input
                    + " are:");
                
                for (int i = 1; i < input; i = i + 2)
                {
                    Console.WriteLine(i);
                    
                }
            }
            Console.ReadKey();

            if (series == "Even")
            {
                Console.WriteLine("You have selected " + series + " Series.The number between 0 and " + input
                    + " are:");

                for (int i = 0; i < input; i = i + 2)
                {
                    Console.WriteLine(i);
                    
                }
                Console.ReadKey();
            }

        }
    }
}

