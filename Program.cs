// Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введи координату X первой точки");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введи координату Y первой точки");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введи координату Z первой точки");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введи координату X второй точки");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введи координату Y второй точки");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введи координату Z второй точки");
double z2 = double.Parse(Console.ReadLine());
Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))}");