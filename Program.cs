/* напишите программу которая измассива случайных чисел 
ищет второй максимум */

int[] NewArray(int len = 5)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10); 
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
int[] arrey = NewArray(); 
PrintArray(arrey);

int SecondMax (int[] arrey)
{
    int max = arrey[0];
    int secondMax = arrey[0];
    for (int i = 2; i < arrey.Length; i++)
    {
       if (arrey[i] > max)
       {
        secondMax = max;
        max = arrey[i];
       } 
       if (secondMax == max)
       {
        if (i < arrey.Length - 1)
        {
            secondMax = arrey [i+1];
        }
       }
       if (arrey[i] > secondMax & arrey[i] != max)
       {
        secondMax = arrey[i];
       }
    }
return secondMax;
}
int number = SecondMax(arrey);
Console.WriteLine($"второе максимальное число {number}");

