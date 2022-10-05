// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

WriteLine("Задача 41");
WriteLine("Введите несколько чисел через пробел");
string[] line=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine($"Среди этих чисел {CountPositiveNums(line)} больше нуля");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

WriteLine();
WriteLine("Задача 43");
WriteLine("Введите значения пременных:");
Write("b1 = ");
double b1=Convert.ToDouble(ReadLine()!);
Write("k1 = ");
double k1=Convert.ToDouble(ReadLine()!);
Write("b2 = ");
double b2=Convert.ToDouble(ReadLine()!);
Write("k2 = ");
double k2=Convert.ToDouble(ReadLine()!);


double[] Coordinates=FindIntersection(b1, k1, b2, k2);
WriteLine($"Точка пересечения прямых имеет координаты ({Coordinates[0]:f3}; {Coordinates[1]:f3})");

// можно так, но первый вариант вывода красивее
//WriteLine($"Точка пересечения прямых имеет координаты ({String.Join("; ", FindIntersection(b1, k1, b2, k2))})");


// methods

int CountPositiveNums(string[] array)
{
    int result=0;
    foreach (var item in array)
    {
        double number=Convert.ToDouble(item);
        if(number>0) result+=1;
    }
    return result;
}

double[] FindIntersection(double B1, double K1, double B2, double K2)
{
    double[] result=new double[2];
    result[0]=(B2-B1)/(K1-K2);
    result[1]=K1*result[0]+B1;
    WriteLine($"X = {result[0]}");
    WriteLine($"Y = {result[1]}");
    return result;
}

