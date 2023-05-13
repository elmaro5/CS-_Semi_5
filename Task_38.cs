//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] newarray = createRandomArray(8);

Console.WriteLine(Math.Abs((getMinEl(newarray) - getMaxEl(newarray))));


int[] createRandomArray(int num)
{
    Random rand = new Random();
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = rand.Next(0, 1000);
    }
    return array;
}

int getMinEl(int[] array)
{
    return array[0];
}

int getMaxEl(int[] array)
{
    return array[^1];
}




