// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество чисел ");
int m = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число ");
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Comparison(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0 - {Comparison(mas)} ");
