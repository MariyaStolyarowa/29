//Задача 29: Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Clear();
int[] Array= new int[8];
for (int i=0; i<8; i++)
{Array[i]=new Random().Next(0, 100);}
for (int i=0; i<8; i++)
if (i==7)
{ Console.Write($"{Array[i]} ");}
else
{ Console.Write($"{Array[i]}, ");}