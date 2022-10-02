// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введи количество элементов массива: ");
int sizeArr = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи минимальное значение: ");
int minValue = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи максимальное значение: ");
int maxValue = Int32.Parse(Console.ReadLine());

int[] array = GetArray(sizeArr, minValue, maxValue);
Console.Write("Сгенерирован следующий массив: ");
Console.WriteLine(String.Join(" ", array));


Console.WriteLine($"Сумма элементов на нечетных местах созданного массива составляет {notEvenSum(array)}");


int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int notEvenSum (int[] array){
int sum = 0;
for (int i = 0; i < array.Length; i+=2){
sum += array[i];
}
return sum;
}