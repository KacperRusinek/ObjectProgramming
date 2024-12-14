using System;

class Program1
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nKALKULATOR:\n1. Suma\n2. Różnica\n3. Iloczyn\n4. Iloraz\n5. Potęga\n6. Pierwiastek\n7. Funkcje trygonometryczne\n0. Wyjście");
            Console.Write("Wybierz opcję: ");
            int wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 0:
                    Console.WriteLine("Koniec programu.");
                    return;
                case 1:
                    Console.Write("Podaj dwie liczby: ");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Suma: {a + b}");
                    break;
                case 2:
                    Console.Write("Podaj dwie liczby: ");
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Różnica: {a - b}");
                    break;
                case 3:
                    Console.Write("Podaj dwie liczby: ");
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Iloczyn: {a * b}");
                    break;
                case 4:
                    Console.Write("Podaj dwie liczby: ");
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    if (b != 0)
                        Console.WriteLine($"Iloraz: {a / b}");
                    else
                        Console.WriteLine("Nie można dzielić przez zero!");
                    break;
                case 5:
                    Console.Write("Podaj podstawę i wykładnik: ");
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Potęga: {Math.Pow(a, b)}");
                    break;
                case 6:
                    Console.Write("Podaj liczbę: ");
                    a = double.Parse(Console.ReadLine());
                    if (a >= 0)
                        Console.WriteLine($"Pierwiastek: {Math.Sqrt(a)}");
                    else
                        Console.WriteLine("Nie można pierwiastkować liczby ujemnej!");
                    break;
                case 7:
                    Console.Write("Podaj kąt w radianach: ");
                    double kat = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Sin: {Math.Sin(kat)}, Cos: {Math.Cos(kat)}, Tan: {Math.Tan(kat)}");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej opcji!");
                    break;
            }
        }
        //Console.WriteLine("Podaj współczynniki trójmianu kwadratowego: a, b, c");
        //double a = double.Parse(Console.ReadLine());
        //double b = double.Parse(Console.ReadLine());
        //double c = double.Parse(Console.ReadLine());

        //double delta = b * b - 4 * a * c;
        //Console.WriteLine($"Delta: {delta}");

        //if (delta > 0)
        //{
        //    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        //    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        //    Console.WriteLine($"Pierwiastki: x1 = {x1}, x2 = {x2}");
        //}
        //else if (delta == 0)
        //{
        //    double x0 = -b / (2 * a);
        //    Console.WriteLine($"Pierwiastek podwójny: x0 = {x0}");
        //}
        //else
        //{
        //    Console.WriteLine("Brak pierwiastków rzeczywistych.");
        //}

    }
}