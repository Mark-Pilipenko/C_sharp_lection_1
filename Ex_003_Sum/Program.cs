﻿int numberA = new Random().Next(1, 10);  // 1,2,3,...9
Console.Write(numberA);
int numberB = new Random().Next(1, 10);
Console.Write(" + ");
Console.Write(numberB);
int result = numberA + numberB;
Console.Write(" = ");
Console.WriteLine(result);