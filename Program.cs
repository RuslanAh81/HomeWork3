// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrome(int number)
{
    int count = 1;
    int length = number.ToString().Length;
    double degree = Math.Pow(10, (length - 1));
    int degree1 = Convert.ToInt32(degree);

    while(count <= (length / 2))
     {
        if(number % 10 == number / degree1)
        {
            number = number % 10 / degree1;
            count++;
            if(number <10)
            {
                Console.WriteLine("Ваше число палиндром ");
            }
        }
        else
        {
            Console.WriteLine("Ваше число не палиндром");
        }
        break;
     }
}
Console.Write("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);
*/

//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3д пространстве.

/*
double FindDistance (double ax, double ay, double az, double bx, double by, double bz)
{   
    double sumAB = Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2);
    double distance = Math.Round(Math.Sqrt(sumAB), 2);
    return distance;
}
Console.Write("Введите координату Х точки А : ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y точки А : ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z точки А : ");
double az = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X точки B: ");
double bx = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y точки B: ");
double by = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y точки B: ");
double bz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками A и B равно {FindDistance(ax, ay, az, bx, by, bz)}");

*/

//Задача 3. Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.


void FindCubeOfNumbers(int numb)
{
    int cur = 1;
    while(cur <= numb)
    {
        Console.WriteLine(Math.Pow(cur, 3));
        cur++;
    }
}
Console.WriteLine("Введите положительное число : ");
int numb = Convert.ToInt32(Console.ReadLine());
FindCubeOfNumbers( numb);
if(numb <= 0) 
{
    Console.Write("Число отрицательное");
}