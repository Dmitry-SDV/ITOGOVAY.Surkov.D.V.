﻿/*
Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массивможно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] text;
Console.WriteLine("Введите массив строк через пробел");
string String = Console.ReadLine();     //Вводим строку
Console.WriteLine();

text = String.Split(' ');               //Разбиваем массив text на элементы с помощью метода Split
int Size = 0;                           //Создаем переменную Size, которая определяет текущий элемент массива
