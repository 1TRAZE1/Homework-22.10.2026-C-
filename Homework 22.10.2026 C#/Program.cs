using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22_10_2026_CSharp
{
    struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        }
    }

    struct Rectangle
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    struct Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Title} - {Author} ({Year})";
        }
    }

    struct ComplexNumber
    {
        public double Real;
        public double Imag;

        public ComplexNumber(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            return new ComplexNumber(Real + other.Real, Imag + other.Imag);
        }

        public ComplexNumber Subtract(ComplexNumber other)
        {
            return new ComplexNumber(Real - other.Real, Imag - other.Imag);
        }

        public ComplexNumber Multiply(ComplexNumber other)
        {
            double r = Real * other.Real - Imag * other.Imag;
            double i = Real * other.Imag + Imag * other.Real;
            return new ComplexNumber(r, i);
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }

    struct Color
    {
        public byte R;
        public byte G;
        public byte B;

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public string ToHex()
        {
            return $"#{R:X2}{G:X2}{B:X2}";
        }
    }

    struct SimpleDate
    {
        public int Day;
        public int Month;
        public int Year;

        public SimpleDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public bool IsLeapYear()
        {
            return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
        }
    }

    struct Vector2D
    {
        public double X;
        public double Y;

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public Vector2D Normalize()
        {
            double len = Length();
            if (len == 0) return new Vector2D(0, 0);
            return new Vector2D(X / len, Y / len);
        }

        public double Dot(Vector2D other)
        {
            return X * other.X + Y * other.Y;
        }
    }

    struct Money
    {
        public long Rubles;
        public int Kopecks;

        public Money(long rubles, int kopecks)
        {
            Rubles = rubles + kopecks / 100;
            Kopecks = kopecks % 100;
        }

        private long ToTotalKopecks()
        {
            return Rubles * 100 + Kopecks;
        }

        public Money Add(Money other)
        {
            long total = ToTotalKopecks() + other.ToTotalKopecks();
            return new Money(total / 100, (int)(total % 100));
        }

        public Money Subtract(Money other)
        {
            long total = ToTotalKopecks() - other.ToTotalKopecks();
            return new Money(total / 100, (int)(total % 100));
        }

        public int Compare(Money other)
        {
            return ToTotalKopecks().CompareTo(other.ToTotalKopecks());
        }

        public override string ToString()
        {
            return $"{Rubles} руб. {Kopecks:D2} коп.";
        }
    }

    struct Triangle
    {
        public Point A;
        public Point B;
        public Point C;

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GetPerimeter()
        {
            double sideA = B.DistanceTo(C);
            double sideB = A.DistanceTo(C);
            double sideC = A.DistanceTo(B);
            return sideA + sideB + sideC;
        }

        public double GetArea()
        {
            double sideA = B.DistanceTo(C);
            double sideB = A.DistanceTo(C);
            double sideC = A.DistanceTo(B);
            double p = GetPerimeter() / 2.0;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }

    struct Point3D
    {
        public double X;
        public double Y;
        public double Z;

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceTo(Point3D other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2) + Math.Pow(other.Z - Z, 2));
        }
    }

    struct ChessPiece
    {
        public string Name;
        public string Position;

        public ChessPiece(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public void Move(string newPosition)
        {
            Position = newPosition;
        }
    }

    struct GeoPoint
    {
        public double Latitude;
        public double Longitude;

        public GeoPoint(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double DistanceTo(GeoPoint other)
        {
            double earthRadiusKm = 6371.0;
            double dLat = (other.Latitude - Latitude) * Math.PI / 180.0;
            double dLon = (other.Longitude - Longitude) * Math.PI / 180.0;
            double lat1 = Latitude * Math.PI / 180.0;
            double lat2 = other.Latitude * Math.PI / 180.0;
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return earthRadiusKm * c;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1.0, 2.0);
            Point p2 = new Point(4.0, 6.0);
            Console.WriteLine($"Точки: ({p1.X}, {p1.Y}) и ({p2.X}, {p2.Y}) | Расстояние: {p1.DistanceTo(p2)}");

            Rectangle rect = new Rectangle(5.0, 10.0);
            Console.WriteLine($"Прямоугольник — Площадь: {rect.GetArea()}, Периметр: {rect.GetPerimeter()}");

            Book book = new Book("Метро 2033", "Дмитрий Глуховский", 2005);
            Console.WriteLine($"Книга: {book}");

            ComplexNumber c1 = new ComplexNumber(3, 2);
            ComplexNumber c2 = new ComplexNumber(1, 4);
            Console.WriteLine($"Комплексные числа — Сложение: {c1.Add(c2)}, Вычитание: {c1.Subtract(c2)}, Умножение: {c1.Multiply(c2)}");

            Color color = new Color(255, 128, 0);
            Console.WriteLine($"Цвет RGB(255, 128, 0) в Hex: {color.ToHex()}");

            SimpleDate date = new SimpleDate(1, 1, 2024);
            Console.WriteLine($"Год 2024 високосный: {date.IsLeapYear()}");

            Vector2D vec = new Vector2D(3, 4);
            Console.WriteLine($"Вектор (3, 4) — Длина: {vec.Length()}, Нормализованный: ({vec.Normalize().X}, {vec.Normalize().Y})");

            Money m1 = new Money(150, 50);
            Money m2 = new Money(50, 75);
            Console.WriteLine($"Деньги — Сложение: {m1.Add(m2)}, Сравнение: {m1.Compare(m2)}");

            Triangle tri = new Triangle(new Point(0, 0), new Point(3, 0), new Point(0, 4));
            Console.WriteLine($"Треугольник — Периметр: {tri.GetPerimeter()}, Площадь: {tri.GetArea()}");

            Point3D p3d1 = new Point3D(0, 0, 0);
            Point3D p3d2 = new Point3D(3, 4, 12);
            Console.WriteLine($"3D Расстояние: {p3d1.DistanceTo(p3d2)}");

            ChessPiece knight = new ChessPiece("Конь", "E4");
            knight.Move("F6");
            Console.WriteLine($"Шахматная фигура {knight.Name} переместилась на {knight.Position}");

            GeoPoint moscow = new GeoPoint(55.7558, 37.6173);
            GeoPoint spb = new GeoPoint(59.9343, 30.3351);
            Console.WriteLine($"Расстояние между Москвой и СПб: {moscow.DistanceTo(spb):F2} км");

            Console.ReadKey();
        }
    }
}