// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int [] array = new int[4];
// int evenNumbers = 0;
// int i = 0;
// int arraySize = array.Length;

// while (i < arraySize)
// {
//     array[i] = new Random().Next(1000);
//     i++;
// }
// Console.WriteLine($"Array: [ {String.Join(",", array)} ]");

// for (int j = 0; j < arraySize; j++)
// {
//     if (array[j] % 2 == 0) evenNumbers++;
// }

// Console.WriteLine($"Количество четных = {evenNumbers} ");



//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.

// int [] array = new int[4];
// int sumOddPositionNumbers = 0;
// int i = 0;

// while (i < array.Length)
// {
//     array[i] = new Random().Next(10);
//     i++;
// }
// Console.WriteLine($"Array: [ {String.Join(",", array)} ]");

// for (int j = 0; j < array.Length; j++)
// {
//     if (j % 2 != 0) 
//     {
//         sumOddPositionNumbers += array[j];
//     }
// }

// Console.WriteLine($"Сумма элементов, на нечётных позициях = {sumOddPositionNumbers} ");



// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double[4];
int i = 0;

while (i < array.Length)
{
    array[i] = new Random().NextDouble();
    i++;
}
Console.WriteLine($"Array: [ {String.Join(",", array)} ]");

double min = Math.Round(array.Min(),2)*100;
double max = Math.Round(array.Max(),2)*100;

Console.WriteLine($"Min: {min}, Max: {max}");
Console.WriteLine($"Разница между мин и макс = {max} - {min} = {max-min}");
