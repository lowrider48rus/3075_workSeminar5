// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введи количество элементов массива: ");
int sizeArr = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи минимальное значение: ");
int minValue = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи максимальное значение: ");
int maxValue = Int32.Parse(Console.ReadLine());

int[] array = GetArray(sizeArr, minValue, maxValue);
Console.Write("Сгенерирован следующий массив: ");
Console.WriteLine(String.Join(" ", array));


Console.WriteLine($"Максимальный элемент созданного массива: {checkMax(array)}");
Console.WriteLine($"Минимальный элемент созданного массива: {checkMin(array)}");
Console.WriteLine($"Разница (алгебраическая, она же как я думаю расстояние между этими точками на оси координат) между ними: {checkMax(array) - checkMin(array)}");


int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int checkMax (int[] array){
int max = array[0];
for (int i = 0; i < array.Length; i++){
if(max < array[i]){
    max = array[i];
}
}
return max;
}

int checkMin (int[] array){
int min = array[0];
for (int i = 0; i < array.Length; i++){
if(min > array[i]){
    min = array[i];
}
}
return min;
}
