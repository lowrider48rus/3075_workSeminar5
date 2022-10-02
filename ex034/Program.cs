// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введи количество элементов массива: ");
int sizeArr = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи минимальное значение: ");
int minValue = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи максимальное значение: ");
int maxValue = Int32.Parse(Console.ReadLine());

int[] array = GetArray(sizeArr, minValue, maxValue);
Console.Write("Сгенерирован следующий массив: ");
Console.WriteLine(String.Join(" ", array));

Console.WriteLine($"Количество четных элементов созданного массива составляет {EvenCount(array)}");


int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int EvenCount(int[] array){
int evenCount = 0;

for (int i = 0; i < array.Length; i++){
if (array[i] %2 == 0){
evenCount++;
}
}
return evenCount;
}
