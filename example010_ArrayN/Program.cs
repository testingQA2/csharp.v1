

int[] array = { 41, 22, 43, 41, 54, 36, 71, 82 };

int n = array.Length;
int find = 41; // указываем массив

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index); //программа выводит номер индекса
        break; //оператор для того, что бы программа выводила только первый найденный индекс, если значения массива одинаковые
    }
    index++;
}