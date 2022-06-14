// Test task. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам. 
//Первоначальный массив ввести с клавиатуры или задать на старте.   
Console.WriteLine("This program create new string array where lenght of all string <= 3.");
Console.WriteLine();
int lenghtArray = EnterUserData("Enter lenght of your array: ");
Console.WriteLine();
Console.WriteLine("Enter your string array below.");
Console.WriteLine();
string[] resultArray = new string[lenghtArray];
FillArray(resultArray);









void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter array element # {i + 1}: ");
        array[i] = Console.ReadLine();
        Console.WriteLine();
    }
}

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}