// найти произведение пар чисел в одномерном массиве

Console.WriteLine("Введи количество элементов массива: ");
int sizeArr = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи минимальное значение: ");
int minValue = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи максимальное значение: ");
int maxValue = Int32.Parse(Console.ReadLine());

int[] array = GetArray(sizeArr, minValue, maxValue);

Console.WriteLine($"Сгенерирован следующий массив: {String.Join(" ", array)}");

int[] newarray = multipl(array);

Console.WriteLine($"Результат перемножения пар чисел: {String.Join(" ", newarray)}");

int[] multipl(int[] array){
int size = array.Length;
if (size % 2 ==0) // определяем по какому пути считать, в звисимости от заданного количества элементов массива
    {
    int j = array.Length-1; // первый элемент-то нулевой, ага
    int[] res = new int[size/2]; // формируем новый массив, куда запишем результаты
    for (int i = 0; i < size/2; i++)
        {
        res[i] = array[i] * array[j-i]; // для массива с четным количеством элементов все просто: перемножили 1 с начала и 1 с конца и так до конца перебора половинчатого интервала длины массива
        }
return res;
}
else {                              // если массив с нечетным количеством, то надо сделать так чтобы всегда правильно опрделялся номер "центрального" элемента массива
    int[] res = new int[size/2+1]; // массив должен вмещать в себя произведения пар чисел из массива и непарное "центральное" число 
    int j = array.Length-1; // первый элемент-то нулевой, ага
    int jj = (size/2+1)/2; //номер "центрального" элемента массива с нечетным числом элементов
    for (int i = 0; i <= jj; i++)
        {
        res[i] = array[i] * array[j-i]; // перебираем и перемножаем все парные элементы с начала и до "центра", его не берем
        }
        res[jj+1] = array[size/2]; // записываем его отдельно в последний элемент массива, так как мы приходим после перебора к нему в последнюю очередь
return res;
}
}



int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}
