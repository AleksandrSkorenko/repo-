﻿Console.Clear ();
Console.WriteLine("Введите ваше число ");
int N = Convert.ToInt32(Console.ReadLine());
    
for (int i = 2; i <= N; i += 2)
    Console.WriteLine(i);