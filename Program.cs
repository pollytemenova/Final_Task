// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
using System.ComponentModel;

string[] array = { "0", "25", "world", ":-)" };
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
                        if (array[i].Length <= 3)
                        {
                                                counter++;
                        }
}
string[] newArray = new string[counter];
counter = 0;
for (int i = 0; i < array.Length; i++)
{
                        if (array[i].Length <= 3)
                        {
                                                newArray[counter] = array[i];
                                                counter++;
                        }
}
Console.WriteLine(String.Join(",", newArray));