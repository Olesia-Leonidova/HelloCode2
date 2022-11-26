void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index+1
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //Вместо 0 ставим -1, это такой
                       //искуственный приём, на случай если элемента
                       // нет, таким образом если искать несуществующий эл-т увидим -1
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
    
}


int[] array = new int[10];

FillArray(array);
array[4] = 4; //принудительно добавили 4 на 4 позицию
array[6] = 4; //принудительно добавили 4 на 6 позицию
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);