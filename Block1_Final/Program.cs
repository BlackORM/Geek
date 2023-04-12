// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

//Пользователь вводит количество элеметов массива через метод с проверкой
//Заполняем массив введенными пользователем строками
string[] userString = InputUserString();

//Создаем итоговый массив для элементов у которых не более 3 символов
string[] finalString = InputFinalString(userString, SizeFinalArray(userString));

//Вывод результатов
Console.WriteLine($"\n{PrintUserString(userString)} -> {PrintUserString(finalString)}");

//---------методы---------

//ввод и проверка ввода положительных чисел 
int InputPositiveNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}

//Ввод пользователем размерности и строк
string[] InputUserString()
{
    int num = InputPositiveNumber("Введите количество записей в массиве: ", "Ошибка ввода данных!");
    string[] userInput = new string[num];

    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        userInput[i] = (Console.ReadLine() ?? "");
    }
    return userInput;
}

//Вывод результатов
string PrintUserString(string[] inArray)
{
    if (inArray.Length == 0) return "[]";
    return $"[\"{String.Join("\", \"", inArray)}\"]";
}

//Определение размерности итогового массива
int SizeFinalArray(string[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3) count++;
    }
    return count;
}

//Заполнение итогового массива
string[] InputFinalString(string[] inArray, int count)
{
    string[] itog = new string[count];
    count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            itog[count] = inArray[i];
            count++;
        }
    }
return itog;
}
