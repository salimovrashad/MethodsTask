namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius = 10;
            int sideA = 10;
            int sideB = 10;
            int sideC = 10;

            Console.WriteLine("Area of the circle: " + Area(radius));
            Console.WriteLine("Area of the square: " + Area(sideA, sideB));
            Console.WriteLine("Area of the paralelpiped: " + Area(sideA, sideB, sideC));
            Console.WriteLine("Area of the circle in triangle: " + Area(sideA, sideB, sideC, radius));
        }
        static int Area(int radius)
        {
            int p = 3;
            return (radius * radius) * p;
        }
        static int Area(int sideA, int sideB)
        {
            return sideA * sideB;
        }
        static int Area(int sideA, int sideB, int sideC)
        {
            return 2 * (sideA * sideB + sideA * sideC + sideB * sideC);
        }
        static int Area(int sideA, int sideB, int sideC, int radius)
        {
            return (sideA + sideB + sideC) / 2 * radius;
        }
    }
}