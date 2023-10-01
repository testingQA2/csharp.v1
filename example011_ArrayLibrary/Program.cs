
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //ограничение что бы при вводе массива выходящего за рамки индекс показывал значение "-1" что означает как элемент не найден.
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //остановит выполнение на первом индексе который мы ищем
        }
        index++;
    }
    return position;
}


int[] array = new int[10]; //функция создания массива с N числом

FillArray(array);
array[4] = 4; //исскустевнно добавлем в индекс (array[4]) значение массива "4"
array[8] = 4; //исскустевнно добавлем в индекс (array[4]) значение массива "4"
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);

