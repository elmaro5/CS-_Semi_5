//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] newarray = createRandomArray(5);

Console.WriteLine(countNotEvenElem(newarray));


int[] createRandomArray(int num)
{
    Random rand = new Random();
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = rand.Next(0, 100);
    }
    return array;
}



int countNotEvenElem(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        count += array[i];
    }

    return count;
}


