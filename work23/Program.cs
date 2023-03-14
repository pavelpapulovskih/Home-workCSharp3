// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
try
{
Console.Write("Введите N: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumbKub(numb));
}
catch
{
    Console.WriteLine("Ввели неправильные данные");
}
string NumbKub(int numb, string res = "1")
{
    if(numb <= 0)
    {
        return "Вы ввели неправильное число!";
    }

    int i = 2;    
    while(i <= numb)
    {
        res =  res + "," + Convert.ToString(i*i*i);
        i++;
    }
    return res;
}
