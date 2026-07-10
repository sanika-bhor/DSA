int[] array=[15,65,63,96,78,28,39,15,236,45,79,92,73];

for(int i=0;i<array.Length;i++)
{
    Console.Write(array[i]+", ");
}

int temp;
for (int i = 0; i < array.Length; i++)
{
    int min=i;
    for (int j = i+1; j < array.Length; j++)
    {
       if(array[min]>array[j])
        {
           min=j;
        }
    }

    if(min!=i)
    {
        temp=array[min];
        array[min]=array[i];
        array[i]=temp;
    }
}

Console.WriteLine("\n After Sorting: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}
