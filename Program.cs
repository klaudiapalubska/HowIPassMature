using System.Runtime.CompilerServices;

namespace KalkulatorProblemówMatematycznych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Program do rozwiązyania problemów matematycznych---------------");
            menu:
            Console.WriteLine("Wybierz swój problem matematyczny wypisując liczbę na ekranie:");
            Console.WriteLine("|1 Miejsca zerowe funkcji |2 Dzielenie wielomianów prostych schematem Hornera |3 Wzory skróconego mnożenia");
            
            string wybor = Console.ReadLine();
            int wyboor = int.Parse(wybor);
            switch (wyboor)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Wypełnij wartości funkcji:");
                    Console.WriteLine("Wartość a:");
                    string ai = Console.ReadLine();
                    Console.WriteLine("Wartość b:");
                    string bi = Console.ReadLine();
                    Console.WriteLine("Wartość c:");
                    string ci = Console.ReadLine();

                    double a = double.Parse(ai);
                    double b = double.Parse(bi);
                    double c = double.Parse(ci);
                    if (a == 0)
                    {
                        Console.WriteLine("a nie może być zerem wtf mordo xDDD");
                    }
                    else
                    {



                        Console.WriteLine($"Twoja funkcja to: y = {a}x^+{b}x+{c}");
                        double potegab = Math.Pow(b, 2);
                        double delta = potegab - 4 * a * c;
                        delta = Math.Sqrt(delta);
                        Console.WriteLine("Miejsca zerowe dla tej funkcji:");
                        if (delta > 0)
                        {
                            double x1 = (-b - delta) / (2 * a);
                            double x2 = (-b + delta) / (2 * a);
                            Console.WriteLine($" x1 = {x1} x2 = {x2}");
                        }
                        else if (delta == 0)
                        {
                            double x1 = (-b - delta) / (2 * a);
                            Console.WriteLine($" x1 = {x1} x2 nie ma");
                        }
                        else
                        {
                            Console.WriteLine("Funkcja nie posiada miejsc zerowych");
                        }

                    }
                    break;

                case 2:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Wybierz najwyższą potęge w wielomianie:");
                    Console.WriteLine("4| potęga czwarta 3| potęga trzecia |(więcej mi się narazie nie chcę robić)");
                    string potega = Console.ReadLine();
                    int potegaa = int.Parse(potega);
                    if (potegaa == 3)
                    {
                        Console.WriteLine("Wypełnij wartości funkcji: (Wpisz zero jeśli nie ma nic)");
                        Console.WriteLine("Pozycja przy x^3:");
                        string a3potega = Console.ReadLine();
                        Console.WriteLine("Pozycja przy x^2:");
                        string b3potega = Console.ReadLine();
                        Console.WriteLine("Pozycja przy x:");
                        string c3potega = Console.ReadLine();
                        Console.WriteLine("Pozycja bez x:");
                        string d3potega = Console.ReadLine();

                        double a3 = double.Parse(a3potega);
                        double b3 = double.Parse(b3potega);
                        double c3 = double.Parse(c3potega);
                        double d3 = double.Parse(d3potega);



                        Console.WriteLine("Twoja funkcja:");
                        Console.WriteLine($"{a3}x^3 + {b3}x^2 + {c3}x + {d3}");
                        Console.WriteLine("Podaj miesjce zerowe przez które dzielisz:");
                        string x3potega = Console.ReadLine();
                        double x3 = double.Parse(x3potega);
                        Console.WriteLine("Twoje równanie:");
                        Console.WriteLine($"({a3}x^3 + {b3}x^2 + {c3}x + {d3}) : (x + {x3}) =");
                        if(x3 < 0)
                        {
                            x3 = x3 * -1; //dodatnia
                        }
                        else
                        {
                            x3 = x3 * -1; //ujemna
                        }
                        b3 = (a3 * x3) + b3;
                        c3 = (b3 * x3) + c3;
                        d3 = (c3 * x3) + d3;
                        Console.WriteLine($"{a3}x^2 + {b3}x + {c3} reszta: {d3}");



                    }
                    else if (potegaa == 4)
                    {
                        Console.WriteLine("Wypełnij wartości funkcji: (Wpisz zero jeśli nie ma nic");
                        Console.WriteLine("Pozycja przy x^4:");
                        string y34potega = Console.ReadLine();
                        Console.WriteLine("Pozycja przy x^3:");
                        string a34potega = Console.ReadLine();
                        Console.WriteLine("Pozycja przy x^2:");
                        string b34potega = Console.ReadLine();
                        Console.WriteLine("Pozycja przy x:");
                        string c34potega = Console.ReadLine();
                        Console.WriteLine("Pozycja bez x:");
                        string d34potega = Console.ReadLine();

                        double y34 = double.Parse(y34potega);
                        double a34 = double.Parse(a34potega);
                        double b34 = double.Parse(b34potega);
                        double c34 = double.Parse(c34potega);
                        double d34 = double.Parse(d34potega);



                        Console.WriteLine("Twoja funkcja:");
                        Console.WriteLine($"{y34}x^4 + {a34}x^3 + {b34}x^2 + {c34}x + {d34}");
                        Console.WriteLine("Podaj miesjce zerowe przez które dzielisz:");
                        string x34potega = Console.ReadLine();
                        double x34 = double.Parse(x34potega);
                        Console.WriteLine("Twoje równanie:");
                        Console.WriteLine($"({y34}x^4 + {a34}x^3 + {b34}x^2 + {c34}x + {d34}) : (x + {x34}) =");
                        if (x34 < 0)
                        {
                            x34 = x34 * -1; //dodatnia
                        }
                        else
                        {
                            x34 = x34 * -1; //ujemna
                        }
                        a34 = (y34 * x34) + a34;    
                        b34 = (a34 * x34) + b34;
                        c34 = (b34 * x34) + c34;
                        d34 = (c34 * x34) + d34;
                        Console.WriteLine($"{y34}x^3 +{a34}x^2 + {b34}x + {c34} reszta: {d34}");
                    }
                    else
                    {
                        Console.WriteLine("Podano błędną wartość");
                    }
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Narazie nie ma bo mi się nie chcę ok");
                    break;
              default:
                    Console.WriteLine("Podano nie poprawną wartość");
                    break;
            }
            Console.WriteLine("Jeżeli chcesz powrócić do menu wybierz 1 jeżeli chcesz zakończyć program wybierz dowolna liczbę");
           string men = Console.ReadLine();
            if (men == "1")
            {
                goto menu;
            }
          
            
        }
    }
}