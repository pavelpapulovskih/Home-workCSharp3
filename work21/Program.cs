// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите первую кординату x ");
int y1 = ReadInt("Введите первую кординтау y ");
int z1 = ReadInt("Введите первую кординтау z ");
int x2 = ReadInt("Введите вторую кординтау x ");
int y2 = ReadInt("Введите вторую кординтау y ");
int z2 = ReadInt("Введите вторую кординтау z ");

int a = x2 - x1;
int b = y2 - y1;
int c = z1 - z2;

double length =Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine(Math.Round(length,2));