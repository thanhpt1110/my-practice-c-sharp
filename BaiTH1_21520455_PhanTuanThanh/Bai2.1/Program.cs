using System;
namespace Hihi
{
    class Point
    {
        public double x;
        public double y;
        public void InputPoint()
        {
            Console.Write("Enter x's coordinate: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter y's coordinate: ");
            y = double.Parse(Console.ReadLine());
        }
    }

    public abstract class Shape
    {
        public abstract void Draw();
        public abstract void Input();
        public abstract double Area();
    }

    class Rectangle : Shape
    {
        int Length, Width;
        public override void Draw()
        {
            Console.WriteLine("This is a Rectangle!");
        }
        public override void Input()
        {
            Console.WriteLine("Enter your Rectangle information: ");
            Point p = new Point();
            p.InputPoint();

            Console.Write("Enter your length: ");
            Length = int.Parse(Console.ReadLine());

            Console.Write("Enter your width: ");
            Width = int.Parse(Console.ReadLine());
        }

        public override double Area()
        {
            return this.Length * this.Width;
        }
    }

    class Triangle : Shape
    {
        Point p1 = new Point();
        Point p3 = new Point();
        Point p2 = new Point();

        public override void Draw()
        {
            Console.WriteLine("This is a Triangle!");
        }

        public override void Input()
        {             
            Console.WriteLine("Enter your Triangle information: ");
            Console.Write("P1's coordinate - ");  p1.InputPoint();
            Console.Write("P2's coordinate - ");  p2.InputPoint();
            Console.Write("P3's coordinate - ");  p3.InputPoint();
        }

        public override double Area()
        {
            double l1, l2, l3;
            l1 = Math.Sqrt((p2.x - p3.x) * (p2.x - p3.x) + (p2.y - p3.y) * (p2.y - p3.y));
            l2 = Math.Sqrt((p1.x - p3.x) * (p1.x - p3.x) + (p1.y - p3.y) * (p1.y - p3.y));
            l3 = Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
            double p = (l1 + l2 + l3) / 2;
            return Math.Sqrt(p * (p - l1) * (p - l2) * (p - l3));
        }
    }

    class Circle : Shape
    {
        int Radius;
        public override void Draw()
        {
            Console.WriteLine("This is a Circle!");
        }
        public override void Input()
        {
            Console.WriteLine("Enter your Circle information: ");
            
            Console.WriteLine("Center coordinate:");
            Point p = new Point();
            p.InputPoint();

            Console.WriteLine("Enter length of Radius:");
            Radius = int.Parse(Console.ReadLine());
        }
        public override double Area()
        {
            return this.Radius * 3.14;
        }
    }

    class Square : Rectangle
    {
        int Edge;

        public override void Draw()
        {
            Console.WriteLine("This is a Square!");
        }

        public override void Input()
        {
            Console.WriteLine("Enter your Square information: ");
            Point p = new Point();
            p.InputPoint();

            Console.Write("Enter length of edge: ");
            Edge = int.Parse(Console.ReadLine());
        }

        public override double Area()
        {
            return this.Edge * this.Edge;
        }
    }

    public class HelloWorld
    {
        public static void Input(Shape[] Arr, int n)
        {
            for (int i = 0; i < n; ++i)
            {
                Random rd = new Random();
                int id = rd.Next(1, 5);
                switch (id)
                {
                    case 1:
                        Arr[i] = new Rectangle();
                        break;
                    case 2:
                        Arr[i] = new Triangle();
                        break;
                    case 3:
                        Arr[i] = new Circle();
                        break;
                    case 4:
                        Arr[i] = new Square();
                        break;
                }
                Arr[i].Input();
                Console.WriteLine("----------------------");
            }
        }

        public static void Output(Shape[] Arr, int n)
        {
            for (int i = 0; i < n; ++i)
            {
                Arr[i].Draw();
                Console.WriteLine("Area: " + Math.Round(Arr[i].Area(), 2));
                Console.WriteLine("----------------------");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your number of Shape: ");
            int n = int.Parse(Console.ReadLine());
            Shape[] Arr = new Shape[n];

            Input(Arr, n);
            Output(Arr, n);

            Console.ReadKey();
        }
    }
}
