// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int a1, b1, c1, a2, b2, c2;

Console.WriteLine("Введите a1: ");
a1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите a2: ");
a2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите b1: ");
b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите b2: ");
b2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите c1: ");
c1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите c2: ");
c2 = int.Parse(Console.ReadLine());

double sq1 = Math.Pow((a2-a1), 2);
double sq2 = Math.Pow((b2-b1), 2);
double sq3 = Math.Pow((c2-c1), 2);

double sq_res = sq1+sq2+sq3;

Console.WriteLine((float)Math.Sqrt(sq_res));