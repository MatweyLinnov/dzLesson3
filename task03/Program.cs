﻿int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(array.Length);
    System.Console.WriteLine(array[i]);
}




