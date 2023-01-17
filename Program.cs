// Напишите программу, которая выводит случайное число из 
//отрезка [10, 99] и показывает наибольшую цифру числа.

// int num = new Random().Next(10, 100);
// Console.WriteLine(num);

// int firstNum = num /10;
// int secondNum = num % 10;

// if (firstNum > secondNum)
// {
//     Console.WriteLine(firstNum);
// }
// else 
// {
//     Console.WriteLine(secondNum);
// }




// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// int num = new Random().Next(100, 1000);

// int result = ((num / 100)) * 10 + (num % 10);
// Console.WriteLine($"{num} -> {result}");



// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//    System.Console.WriteLine("кратно");
// }
// else
// {
//     System.Console.WriteLine($"не кратно, остаток {num1 % num2}");
// }




// Напишите программу, которая принимает на вход число и проверяет, кратно ли 
// оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}


