int[]array = {111, 22, 3, 73, 24, 85, 56, 73, 18};

int n = array.Length;
int find = 73;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;//если хочу чтобы найдя первый индекс, больше не искал
    }
    //index = index + 1;
    index++;
}