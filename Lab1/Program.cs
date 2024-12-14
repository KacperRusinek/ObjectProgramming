using System;

class Program1
{
    static void Main()
    {
        //wybralem sortowanie babelkowe 

        Console.Write("Podaj liczbę n (ilość liczb do wprowadzenia): ");
        int n = int.Parse(Console.ReadLine());

        int[] liczby = new int[n];

        Console.WriteLine($"Wprowadź {n} liczb:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            3
                liczby[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (liczby[j] > liczby[j + 1])
                {
                    int temp = liczby[j];
                    liczby[j] = liczby[j + 1];
                    liczby[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Posortowane liczby:");
        foreach (var liczba in liczby)
        {
            Console.WriteLine(liczba);
        }

        //while (true)
        //{
        //    Console.Write("Wprowadź liczbę (mniejszą niż 0, aby zakończyć): ");
        //    int liczba = int.Parse(Console.ReadLine());

        //    if (liczba < 0)
        //    {
        //        Console.WriteLine("Pętla zakończona.");
        //        break;
        //    }

        //    Console.WriteLine($"Wprowadzona liczba: {liczba}");
        //}

        //for (int i = 20; i >= 0; i--)
        //{
        //    if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}

        //int[] liczby = new int[10];
        //int suma = 0;
        //int iloczyn = 1;
        //int min = int.MaxValue;
        //int max = int.MinValue;

        //Console.WriteLine("Wprowadź 10 liczb:");

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write("Liczba {0}: ", i + 1);
        //    liczby[i] = int.Parse(Console.ReadLine());
        //    suma += liczby[i];
        //    iloczyn *= liczby[i];

        //    if (liczby[i] < min)
        //        min = liczby[i];
        //    if (liczby[i] > max)
        //        max = liczby[i];
        //}

        //double srednia = suma / 10.0;

        //Console.WriteLine($"Suma liczb: {suma}");
        //Console.WriteLine($"Iloczyn liczb: {iloczyn}");
        //Console.WriteLine($"Średnia liczb: {srednia}");
        //Console.WriteLine($"Wartość minimalna: {min}");
        //Console.WriteLine($"Wartość maksymalna: {max}");

        //while (true)
        //{
        //    Console.WriteLine("\nKALKULATOR:\n1. Suma\n2. Różnica\n3. Iloczyn\n4. Iloraz\n5. Potęga\n6. Pierwiastek\n7. Funkcje trygonometryczne\n0. Wyjście");
        //    Console.Write("Wybierz opcję: ");
        //    int wybor = int.Parse(Console.ReadLine());

        //    switch (wybor)
        //    {
        //        case 0:
        //            Console.WriteLine("Koniec programu.");
        //            return;
        //        case 1:
        //            Console.Write("Podaj dwie liczby: ");
        //            double a = double.Parse(Console.ReadLine());
        //            double b = double.Parse(Console.ReadLine());
        //            Console.WriteLine($"Suma: {a + b}");
        //            break;
        //        case 2:
        //            Console.Write("Podaj dwie liczby: ");
        //            a = double.Parse(Console.ReadLine());
        //            b = double.Parse(Console.ReadLine());
        //            Console.WriteLine($"Różnica: {a - b}");
        //            break;
        //        case 3:
        //            Console.Write("Podaj dwie liczby: ");
        //            a = double.Parse(Console.ReadLine());
        //            b = double.Parse(Console.ReadLine());
        //            Console.WriteLine($"Iloczyn: {a * b}");
        //            break;
        //        case 4:
        //            Console.Write("Podaj dwie liczby: ");
        //            a = double.Parse(Console.ReadLine());
        //            b = double.Parse(Console.ReadLine());
        //            if (b != 0)
        //                Console.WriteLine($"Iloraz: {a / b}");
        //            else
        //                Console.WriteLine("Nie można dzielić przez zero!");
        //            break;
        //        case 5:
        //            Console.Write("Podaj podstawę i wykładnik: ");
        //            a = double.Parse(Console.ReadLine());
        //            b = double.Parse(Console.ReadLine());
        //            Console.WriteLine($"Potęga: {Math.Pow(a, b)}");
        //            break;
        //        case 6:
        //            Console.Write("Podaj liczbę: ");
        //            a = double.Parse(Console.ReadLine());
        //            if (a >= 0)
        //                Console.WriteLine($"Pierwiastek: {Math.Sqrt(a)}");
        //            else
        //                Console.WriteLine("Nie można pierwiastkować liczby ujemnej!");
        //            break;
        //        case 7:
        //            Console.Write("Podaj kąt w radianach: ");
        //            double kat = double.Parse(Console.ReadLine());
        //            Console.WriteLine($"Sin: {Math.Sin(kat)}, Cos: {Math.Cos(kat)}, Tan: {Math.Tan(kat)}");
        //            break;
        //        default:
        //            Console.WriteLine("Nie ma takiej opcji!");
        //            break;
        //    }
        //}



        //double[] tablica = new double[10];

        //Console.WriteLine("Wprowadź 10 liczb rzeczywistych:");
        //for (int i = 0; i < tablica.Length; i++)
        //{
        //    Console.Write($"Element {i + 1}: ");
        //    tablica[i] = double.Parse(Console.ReadLine());
        //}

        //do
        //{
        //    Console.WriteLine("\nMENU:\n1. Wyświetl tablicę od pierwszego do ostatniego indeksu\n2. Wyświetl tablicę od ostatniego do pierwszego indeksu\n3. Wyświetl elementy o nieparzystych indeksach\n4. Wyświetl elementy o parzystych indeksach\n0. Wyjście");
        //    Console.Write("Wybierz opcję: ");
        //    int wybor = int.Parse(Console.ReadLine());

        //    if (wybor == 0)
        //    {
        //        Console.WriteLine("Koniec programu.");
        //        break;
        //    }
        //    else if (wybor == 1)
        //    {
        //        Console.WriteLine("Tablica od pierwszego do ostatniego indeksu:");
        //        for (int i = 0; i < tablica.Length; i++)
        //            Console.WriteLine(tablica[i]);
        //    }
        //    else if (wybor == 2)
        //    {
        //        Console.WriteLine("Tablica od ostatniego do pierwszego indeksu:");
        //        for (int i = tablica.Length - 1; i >= 0; i--)
        //            Console.WriteLine(tablica[i]);
        //    }
        //    else if (wybor == 3)
        //    {
        //        Console.WriteLine("Elementy o nieparzystych indeksach:");
        //        for (int i = 1; i < tablica.Length; i += 2)
        //            Console.WriteLine(tablica[i]);
        //    }
        //    else if (wybor == 4)
        //    {
        //        Console.WriteLine("Elementy o parzystych indeksach:");
        //        for (int i = 0; i < tablica.Length; i += 2)
        //            Console.WriteLine(tablica[i]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nie ma takiej opcji!");
        //    }
        //} while (true);

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