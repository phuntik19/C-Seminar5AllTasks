//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие орицательные, и наоборот. [-4, -8, 8,2] -> [4, 8, -8,-2]

int[] GetRandomArray()
{
      int[] array = new int[5];
      for(int i = 0; i < array.Length; i++)
    {
       array[i] = Random.Shared.Next(-9, 10);
    }

return array;
}

int[] array = GetRandomArray();
Console.WriteLine("Начальный массив это");
Console.WriteLine(string.Join(" , ", array));
for (int i = 0; i < array.Length; i++)

{
    if(array[i] > 0)
    {
        array[i] = -array[i];
    }
    else if(array[i] < 0)
    {
        array[i] = -array[i];
    }
}
Console.WriteLine("Измененный массив это");
Console.WriteLine(String.Join(" , ", array));


