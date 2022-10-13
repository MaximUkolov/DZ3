
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Введите пятизначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int first = a / 10000;
// int second = (a % 10000) / 1000;
// int therd = (a % 1000) / 100;
// int fourth = (a % 100) / 10;
// int fith = (a % 10);
//     if (first==fith & second==fourth)
//     {
//         Console.WriteLine("Число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Число не является палиндромом");
//     }





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

// bool one = true;
// while (one)
// {
// try
// {
// Console.Write("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int index = 0;
// for(int i = 1; i <= num; i++)
// {
// index = (int)Math.Pow(i, 3);
// if (i == num) Console.Write(index + ".");
// else
// Console.Write(index + ", ");
// }
// one = false;
// }
// catch
// {
// Console.WriteLine("Ошибка, повторите ввод: ");
// }
// }