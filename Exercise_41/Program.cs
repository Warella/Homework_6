// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int[] DataInput(string str)
{
    int count = 1;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ',') count++; // посчитали количество чисел в строке с учетом того, что после последнего числа нет запятой
    }
    int[] array = new int[count]; // вводим массив, который заполнится значениями пользователя, размера count
    int index = 0;
    for (int i = 0; i < str.Length; i++)
    {
        string temp = "";
        while (str[i] != ',') 
        {
            if (i != str.Length - 1)
            {
                temp += str[i].ToString();
                i++;
            }
            else
            {
                temp += str[i].ToString();
                break;
            }
        }
        array[index] = Convert.ToInt32(temp); // создали массив по данным из строки
        index++;
    }
    return array;
}
int PositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите числа через запятую: ");
int[] arr = DataInput(Console.ReadLine());
int result = PositiveNumber(arr);
Console.WriteLine($"Количество значений больше нуля: {result}");
