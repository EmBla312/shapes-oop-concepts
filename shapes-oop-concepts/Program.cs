using System;

namespace shapes_oop_concepts
{
    class Program : I2DShape
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + ". What shape would you like to create?");            
            bool isValid = false;
            while(!isValid)
            {
                Console.WriteLine("Shape Options:\n1) Square\n2)Triangle\n3)Rectangle\n4)Circle\nType the number of the shape you want.");
                int shapeChoice = Convert.ToInt32(Console.ReadLine());
                switch (shapeChoice)
                {
                    case 1:
                        Console.WriteLine("What is the length of the sides of this Square?");
                        double slength = Convert.ToDouble(Console.ReadLine());
                        Square square = new Square(slength);
                        Console.WriteLine("Your Square:\n Area - " + square.area + "\n Perimeter - " + square.calcParim());
                        isValid = true;
                        break;
                    case 2:
                        Console.WriteLine("What is the length of the base?");
                        double triBase = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the length of the second side?");
                        double side2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the length of the third side?");
                        double side3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the height of the triangle?");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Triangle triangle = new Triangle(triBase, side2, side3, height);
                        Console.WriteLine("Your Triangle:\nArea - " + triangle.area + "\n Perimeter - " + triangle.calcParim());
                        isValid = true;
                        break;
                    case 3:
                        Console.WriteLine("What is the length of the Rectangle?");
                        double rlength = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the height of the Rectangle?");
                        double rwidth = Convert.ToDouble(Console.ReadLine());
                        Rectangle rect = new Rectangle(rlength, rwidth);
                        Console.WriteLine("Your Rectangle:\n Area - " + rect.area + "\nPerimeter - " + rect.calcParim());
                        isValid = true;
                        break;
                    case 4:
                        Console.WriteLine("What is the radius of this circle?");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle circ = new Circle(radius);
                        Console.WriteLine("Your Circle:\n Area - " + circ.area + "\nCircumference - " + circ.calcCircumference());
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, didn't catch that. Please type only one number between 1-4 and click [ENTER].");
                        break;

                }
                if(isValid == true)
                {
                    Console.WriteLine("Would you like to do this again? (Type y = yes or n = no)");
                    char cont = Convert.ToChar(Console.ReadLine());
                    if (cont == 'y') isValid = false;
                }
                
                Console.WriteLine("================================");
            }
            String exit = Console.ReadLine();
            
        }
        public void grow(_2DShape shape, int growBy)
        {
            shape.area *= growBy;
        }
        public void shrink(_2DShape shape, int shrinkBy)
        {
            shape.area /= shrinkBy;
        }
    }
}
