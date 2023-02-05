namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Выбирите:\n 1 - равнобедренный треугольник;\n 2 - круг;");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            Console.Write("Введите количество строк: ");
                            if (!int.TryParse(Console.ReadLine(), out int heigth) || heigth <= 0)
                            {
                                Console.WriteLine("Неверная высота треугольника!");
                            }
                            Triangle triangle= new Triangle { Heigth = heigth };
                            triangle.Draw();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Введите радиус круга:");
                            if (!double.TryParse(Console.ReadLine(), out double r) || r <= 0)
                            {
                                Console.WriteLine("Неверный радиус!");
                            }
                            Circle circle = new Circle {Radius= r};
                            circle.Draw();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("что-то не то вы ввели!");
                            break;
                        }
                }
                Console.WriteLine("\nЗапуск - ENTER;\nВыход из программы - ESC");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
    class GeometricFigure
    {
        public string СenterСoordinates;
    }
    class Triangle : GeometricFigure 
    {
        internal int _heigth;
        public int Heigth
        {
            get { return _heigth; }
            set { _heigth = value; }
        }

        public void Draw()
        {
            for (int i = 5; i < _heigth+5; i++)
            {
                Console.SetCursorPosition(_heigth+5 - i, i + 1);
                for (int j = 0; j <= (i-5) * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Circle : GeometricFigure
    {
        internal double _radius;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public void Draw()
        {
            bool fill = true;
            string input;
            double r_in = _radius - 0.4;
            double r_out = _radius + 0.4;

            Console.WriteLine();
            for (double y = _radius; y >= -_radius; --y)
            {
                for (double x = -_radius; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                    {
                        Console.Write(".");
                    }
                    else if (fill && value < r_in * r_in && value < r_out * r_out)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
