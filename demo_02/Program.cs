﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Случайное число: {number}");

int LeftNumber = number / 100;
int rightNumber = number % 10;

System.Console.WriteLine($"{number/100}{number % 10}");
