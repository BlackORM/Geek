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
int num = InputPositiveNumber("Введите количество записей в массиве: ", "Ошибка ввода данных!");

//Создаем массив заданной размерности
string[] userString = new string[num];

//Переменная считающая количество элементов с заданными условиями
int count = 0;

//Заполняем массив введенными пользователем строками
for (int i = 0; i < num; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    userString[i] = (Console.ReadLine() ?? "");

    if (userString[i].Length <= 3) count++;
}

if (count == 0)
{
    Console.WriteLine($"[\"{string.Join("\", \"", userString)}\"] => []");
}
else
{
    //Создаем массив для элементов у которых не более 3 символов
    string[] finalString = new string[count];
    count = 0;

    //Переносим элементы с 3 и менее символами в итоговый массив
    for (int i = 0; i < num; i++)
    {
        if (userString[i].Length <= 3)
        {
            finalString[count] = userString[i];
            count++;
        }
    }

    //Вывод результатов
    Console.WriteLine($"[\"{string.Join("\", \"", userString)}\"] => [\"{string.Join("\", \"", finalString)}\"]");
}

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

