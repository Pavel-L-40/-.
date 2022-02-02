// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.

int[] array = new int []{1, 3, 4, 5, 7, 1, 2, 3, 8, 10 , 22 , 23};
List<int> new_array = new List<int>();

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        new_array.Add(array[i]);
        count += 1;
        // System.Console.WriteLine(array[i]);
    }
}
for (int i = 0; i < count; i++)
{
    System.Console.WriteLine(new_array[i]);
}