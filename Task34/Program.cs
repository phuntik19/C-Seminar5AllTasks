//Задача 34: Задайте массив заполненный случайными положительными трехназначными числами. Напишите программу, которая покажет количество четных числе в массиве.
// [345, 897, 598, 234] -> 2


Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void RandomNumbers(int[] numbers)
{
      for(int i = 0; i < size; i++)
    {
       numbers[i] = Random.Shared.Next(100, 1000);
    }
}

int count = 0;
  for(int x = 0; x < numbers.Length; x++)

    if(numbers[x] % 2 == 0)
    {
        count++;
    }   
    Console.WriteLine($" из {numbers.Length} чисел, {count} четных");

    void PrintArray(int[] numbers)
    {
        Console.Write("[ ");
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
