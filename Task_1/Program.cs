//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
int[] a = new int[4];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
a[i] = random.Next(100, 1000);
 
int b = a.Count(x => x % 2 == 0);
            
Console.WriteLine($"Массив {string.Join(", ", a)}\nЧетные {b} ");

