/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

using static System.Console;
Clear();
Write("Введите координату Х точки А - ");
int xA = int.Parse(ReadLine());
Write("Введите координату У точки А - ");
int yA = int.Parse(ReadLine());
Write("Введите координату Z точки А - ");
int zA = int.Parse(ReadLine());
WriteLine();
Write("Введите координату Х точки B - ");
int xB = int.Parse(ReadLine());
Write("Введите координату У точки B - ");
int yB = int.Parse(ReadLine());
Write("Введите координату Z точки B - ");
int zB = int.Parse(ReadLine());
double distance = Math. Sqrt((Math.Pow(xB-xA,2)+Math.Pow(yB-yA,2)+Math.Pow(zB-zA,2)));
WriteLine($"Растояние между точками A и B равно {distance:f2}");