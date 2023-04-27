/*Создание консольного приложения на C# для работы с числами

Создайте консольное приложение на C#.
Запросите у пользователя ввод двух чисел и сохраните их в переменные.
Выведите на экран результат сложения, вычитания, умножения и деления этих двух чисел.
Запросите у пользователя ввод третьего числа и сохраните его в переменную.
Выведите на экран максимальное и минимальное значение из трех введенных чисел.
Создайте цикл, который выводит на экран все числа от 1 до 100 включительно.
Измените цикл таким образом, чтобы он выводил на экран только четные числа от 1 до 100 включительно.
Измените цикл таким образом, чтобы он выводил на экран сумму всех чисел от 1 до 100 включительно.
Измените цикл таким образом, чтобы он выводил на экран таблицу умножения на 5.*/

Console.Write("Введите первое число: ");
int digit_one = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int digit_two = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int digit_three = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Сложение: {digit_one + digit_two}");
Console.WriteLine($"Вычитание: {digit_one - digit_two}");
Console.WriteLine($"Умножение: {digit_one * digit_two}");
Console.WriteLine($"Деление: {digit_one / digit_two}");


if ((digit_one > digit_two) && (digit_one > digit_three))
{
    Console.WriteLine($"Число {digit_one} наибольшее");
}

if ((digit_two > digit_one) && (digit_two > digit_three))
{
    Console.WriteLine($"Число {digit_two} наибольшее");
}

if ((digit_three > digit_one) && (digit_three > digit_two))
{
    Console.WriteLine($"Число {digit_three} наибольшее");
}


Console.WriteLine();
Console.WriteLine("Цикл выводящий числа от 1 до 100");
Console.WriteLine();
for (int i = 1; i < 101; i++)
{
    Console.WriteLine(i);
}



Console.WriteLine();
Console.WriteLine("Цикл выводящий только четные числа в диапазоне от 1 до 100");
Console.WriteLine();
for (int i = 1; i < 101; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}


int sum = 0;
Console.WriteLine();
Console.WriteLine("Цикл выводящий сумму чисел в диапазоне от 1 до 100");
for (int i = 1; i < 101; i++)
{
    sum += i;
}
Console.WriteLine($"Сумма: {sum}");


Console.WriteLine();
Console.WriteLine("Цикл выводящий таблицу умножения на 5");
Console.WriteLine();
for (int i = 5; i < 6; i++)
{
    for (int x = 2; x < 10; x++)
    {
        Console.WriteLine($"{x} * {i} = {x * i}");
    }
}





