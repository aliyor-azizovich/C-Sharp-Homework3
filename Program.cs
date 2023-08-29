// Task 25
int A = 2; // замените на нужное значение
int B = 3; // замените на нужное значение
int result = 1;

for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine("{0} в степени {1} равно {2}", A, B, result);

// Task 27

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()); // считываем число с консоли
int sum = 0;

while (num != 0)
{
    sum += num % 10; // находим остаток от деления на 10 и добавляем его к сумме
    num /= 10; // уменьшаем число на порядок
}

Console.WriteLine("Сумма цифр в числе: {0}", sum);

// Task 29

int[] array = new int[8]; // создаем массив из 8 элементов

Random rand = new Random(); // создаем объект класса Random для генерации псевдослучайных чисел

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100); // заполняем массив псевдослучайными числами от 0 до 99
}

Console.WriteLine("Элементы массива:");

foreach (int element in array)
{
    Console.Write(element + " "); // выводим каждый элемент массива на экран
}

Console.WriteLine(); // переходим на новую строку

