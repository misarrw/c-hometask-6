// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Random rndm = new Random();
int M = rndm.Next(1,11);
int[] FillArray(int[] array)
{
    for (int i = 0; i<M; i++)
        array[i] = int.Parse(Console.ReadLine()!);
        return array;
}


int SummPositive(int[] massive)
{
    int summ = 0;
    for (int j = 0; j<M; j++)
    {
        if (massive[j]>0)
            summ++;
    }

    return summ;
}

int[] numbers = new int[M];
Console.WriteLine(FillArray(numbers));
Console.WriteLine(SummPositive(numbers));
