// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = 1;

while (count <= b)
{
result = result * a;
count++;
}
Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()); //452
int i = 0;
int summ = 0;

while (i < a)
{
    summ = summ + a % 10;
    a = a / 10;

    i++;
}
Console.WriteLine(summ);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] array = new int[8];
int count = array.Length;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine($"[{string.Join(", ", array)}]");