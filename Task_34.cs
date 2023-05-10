int[] newarray = createRandomArray(5);

Console.WriteLine(countEvenNumber(newarray));


int[] createRandomArray(int num)
{
    Random rand = new Random();
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}



int countEvenNumber(int[] array)
{
    int count = 0;
    foreach (int item in newarray)
    {
        if (Convert.ToInt32(item % 2) == 0) count++;
    }
    return count;
}
