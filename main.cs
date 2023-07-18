using System;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height of rectangle: ");
            int height = Convert.ToInt32(Console.ReadLine());
        
            for(int i = 1; i <= height; i++)
            {
                if(i == 1 || i == height)
                {
                    Console.Write("\n");
                    for(int j = 1; j <= length; j++)
                    {
                        Console.Write("*");
                    }
                    continue;
                }
                
                Console.Write("\n*");
                for(int k = 0; k < length - 2; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
            }
        }
    }
}