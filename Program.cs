//branch 1: Task 41
//branch 2: Task 43

/*Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/


string CheckDotEndArray(string array)
{
    if (array[array.Length - 1] != '.')
    {
        array += ".";
    }
    return array;
}



int QuantityNumbersInString(string array)
{
    int countNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] == ',' || array[i] == '.')
        {
            countNumbers++;
        }
    }
    return countNumbers;
}



int[] ConvertStringToArrayIntegerNumbers(string array, int lengthArray)
{
    string convertStringToNumbers = "";
    int[] newArray = new int[lengthArray];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != ',' && array[i] != '.' && array[i] != ' ')
        {
            convertStringToNumbers += array[i];
        }
        else if (array[i] == ',' || array[i] == '.')
        {
            newArray[count] = Convert.ToInt32(convertStringToNumbers);
            convertStringToNumbers = "";
            count++;
        }
    }
    return newArray;
}



void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i + 1 != array.Length)
        {
            Console.Write(", ");
        }
        else
        {
            Console.WriteLine(". ");
        }
    }
}

int QuantityPositiveNumbersArray(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (0 < array[i])
        {
            count++;
        }
        else
        {
            continue;
        }
    }
    Console.Write($"Quantity positive numbers in array: {count}");
    return count;
}



Console.Write("Ipnut numbers array using ',' and add '.' at the end array: ");
string array = Convert.ToString(Console.ReadLine());
array = CheckDotEndArray(array);
int[] numbersArray = ConvertStringToArrayIntegerNumbers(array, QuantityNumbersInString(array));
PrintArray(numbersArray);
QuantityPositiveNumbersArray(numbersArray);


