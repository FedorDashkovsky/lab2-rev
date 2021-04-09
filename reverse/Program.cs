using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string list = " ну ка мечи стаканы на стол";
            string[] reverse = list.Split(' ');
            
                for (int i = 6; i > 0; i--)
            {

                Console.WriteLine(reverse[i]);
            }


            Console.ReadKey();

      

            
        }
    }
}