using System;

namespace Lab_10_Circles
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hey! Welcome to Circles.");

            //declared int num=0 so we can start to keep track of how many circles (passes) the user made with the program
            int num = 0;
            bool go = true;
            while (go)
            {
                Console.WriteLine("Please enter in a radius");
                //double Input = double.Parse(Console.ReadLine());
                try
                {
                    //parse input
                    double Input = double.Parse(Console.ReadLine());

                    //calling on the Circle class and passing through the user input 
                    Circle circle = new Circle(Input);

                    //calling on method made in circle class, gave it variable name "circumference" and passing user input
                    double circumference = circle.CalculateCircumference(Input);
                    double area = circle.CalculateArea(Input);//same step here

                    Console.WriteLine($"The Circumference is: {circumference}");
                    Console.WriteLine($"The Area is: {area}");

                    //num++ will keep count of how many times the user has been through the loop
                    num++;
                     //called on method and passed the num that was declared above while loop
                    go = Continue(num);
                }
                catch
                {
                    Console.WriteLine("AHH AHH AHHH! You didn't say the magic word. ");
                }
            }
        }

        //gave continue a  int parameter so we can pass num from the top through it to display counter
        public static bool Continue(int number)
        {
            //will prompt the user if they would like to cont. if not end the program
            Console.WriteLine($"Press {'y'} to continue or press any other key to exit.");
            char response = Console.ReadKey(true).KeyChar;
            if (response == 'y')
            {
                return true;
            }
            else
            {
                //if the user enter 'y' the program will return false and end the program
                //if false it will then display the below text with how many circles they have made.
                Console.WriteLine($"You created {number} circles. Good-Bye");
                return false;
            }
        }
    }
}
