//Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int i = Convert.ToInt32(Math.Pow(a, b));
// Console.WriteLine(i);



//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Write("Введите X1: ");
// double X1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y1: ");
// double Y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Z1: ");
// double Z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите X2: ");
// double X2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y2: ");
// double Y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Z2: ");
// double Z2 = Convert.ToDouble(Console.ReadLine());
// double R = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
// Console.WriteLine(R);



//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

bool one = true;
while (one)
{
try
{
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 0;
for(int i = 1; i <= num; i++)
{
index = (int)Math.Pow(i, 3);
if (i == num) Console.Write(index + ".");
else
Console.Write(index + ", ");
}
one = false;
}
catch
{
Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
}
}