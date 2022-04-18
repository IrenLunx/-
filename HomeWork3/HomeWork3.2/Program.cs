// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double xa = 4, ya = 8, za = 10, xb = 1, yb = 5, zb = 7;
double spacing = (xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb);
spacing = Math.Sqrt(spacing);
Console.WriteLine("Расстояние между точками = " + "{0:f3}", spacing);

