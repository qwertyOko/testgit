﻿using System;


Console.WriteLine("Введите ваше ФИО:");
string fullName = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write(fullName.Split(' ')[0]);
Console.ResetColor();


