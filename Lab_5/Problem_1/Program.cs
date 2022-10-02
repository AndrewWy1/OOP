using System;
using System.Threading;

namespace Problem_1
{
    class Box
    {
        private double length;
        public double Length {
            get
            {
                return length;
            }
            set
            {
                if (value > 0)
                    length = value;

                else
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
            }
        }

        private double width;
        public double Width {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                    width = value;

                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }

        private double height;
        public double Height {
            get
            {
                return height;
            }
            set
            {
                if(value > 0)
                height = value;

                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }

        }


        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double SurfaceArea()
        {
            return (2 * Length * Width) +
                (2 * Length * Height) +
                (2 * Width * Height);
        }

        public double LateralSurfaceArea()
        {
            return (2 * Length * Height) +
                (2 * Width * Height);
        }

        public double Volume()
        {
            return Length * Height * Width;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length, width and height:");
            double length = Convert.ToDouble(Console.ReadLine()), 
                heigth = Convert.ToDouble(Console.ReadLine()),
                width = Convert.ToDouble(Console.ReadLine());
            
            Box box = new Box(length, heigth, width);

            Console.WriteLine($"Surface Area – {box.SurfaceArea()}");
            Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea()}");
            Console.WriteLine($"Volume –  {box.Volume()}");
        }
    }
}
