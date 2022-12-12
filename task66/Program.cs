/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int sum = 0;
void DigitCount(int number1, int number2) 
{
    if (number1 < number2)
        {
        if (number1 == number2+1)
        {
            return;
        }
        sum = sum + number1;
        number1++;
        DigitCount(number1, number2);
    }
    if (number1 > number2)
        {
        if (number2 == number1+1)
        {
            return;
        }
        sum = sum + number2;
        number2++;
        DigitCount(number1, number2);
        }
}

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
DigitCount(numberM, numberN);
Console.WriteLine(sum);