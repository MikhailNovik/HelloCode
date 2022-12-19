void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index += 1;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine(collection[index]);
        index += 1;
    }
}

int IndexOf(int[] collection, int findNum)
{
    int length = collection.Length;
    int index = 0;
    int position = -1;

    while (index < length)
    {
        if (collection[index] == findNum)
        {
             position = index;
             break;
        }
        index += 1;
    }   
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
