int A = 2; // замените на нужное значение
int B = 3; // замените на нужное значение
int result = 1;

for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine("{0} в степени {1} равно {2}", A, B, result);