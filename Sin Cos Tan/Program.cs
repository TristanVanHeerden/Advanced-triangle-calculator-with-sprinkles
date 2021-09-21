using System;

namespace Sin_Cos_Tan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome To The Advanced Triangle calculator lol");
            Console.WriteLine("this project was completed in a half an hour(I hope)");
            top:
            Console.WriteLine(@"select preocedure
1: pythagorian theorum
2: Sin, Cos and Tan 
3: non right angle triangle 
");

            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    {
                        Console.WriteLine(@"

                X   
              /|
             / |
            /  |
           /   |
          /    |
         /     |
        /      |
       /       |
      /        |
     /         |
    /          |
   /           |
  /____________| 
Z                Y
Solve for:
1: XY 
2: XZ (Hypotenuse)
3: ZY");
                        int operation_2 = Convert.ToInt32(Console.ReadLine());
                        case 1:
                        {

                        }
                         break;


                    }
                    break;
            }
        }
    }
}
