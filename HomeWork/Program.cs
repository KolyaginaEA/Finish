int n = 10;
Console.WriteLine($"В заданном массиве всего {n} элементов");

string[] array = new string[n];
array[0] = "МСК";
array[1] = "Париж";
array[2] = "Денмарк";
array[3] = "СПБ";
array[4] = "Коломна";
array[5] = "Волгоград";
array[6] = "Казань";
array[7] = "Обь";
array[8] = "ОР";
array[9] = "PБ";

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine($"Внимание, ваш исходный массив:");
PrintArray(array);

string[] arrayLessThanThree(string[] array)
{
    int lengthOfNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) lengthOfNewArray++;
    }

    string[] newArray = new string[lengthOfNewArray];

    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;

}

Console.WriteLine();
Console.WriteLine($"Вывод итогового массива:");
PrintArray(arrayLessThanThree(array));