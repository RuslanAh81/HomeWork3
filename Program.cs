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


