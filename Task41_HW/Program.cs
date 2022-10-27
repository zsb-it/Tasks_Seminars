// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Примечание: Попытался решить задачу, используя методы .Split и .Parse

Console.Write("Введите несколько чисел через запятую:");

string[] numbersMassive;                                // Создаем строковый массив
string? number = Console.ReadLine();                    // Получаем от пользователя набор цифр

// Заполняем массив полученными цифрами, используя в качестве разделителя ","
numbersMassive = number.Split(',');                     // Что значит "разыменование пустой ссылки"?                  

int[] countNumbers = new int[numbersMassive.Length];    // Создаем числовой массив размером со строковый

void NumMassive(int[] stringArray)                      // Метод преобразования строкового массива в числовой
{
    for (int i = 0; i < numbersMassive.Length; i++)
        countNumbers[i] = int.Parse(numbersMassive[i]);
}

NumMassive(countNumbers);                               // Преобразуем строковый массив в числовой

int CountPositive(int[] numArray)                       // Метод подсчета количества положительных чисел в массиве
{
    int countPositive = 0;
    for (int i = 0; i < countNumbers.Length; i++)
        if (countNumbers[i] > 0) countPositive++;
    return countPositive;
}

int count = CountPositive(countNumbers);                // Подсчитываем количество положительных чисел в массиве

Console.Write(count);                                   // Выводим количество положительных чисел в консоль