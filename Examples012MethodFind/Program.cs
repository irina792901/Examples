int[] array = { 11, 13, 51, 68, 97, 4, 45, 912 };
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
