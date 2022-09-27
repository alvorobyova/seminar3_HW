Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. ");
Console.WriteLine();

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

void Palindrom(string number)
{
  if (number[0] == number[4] || number[1] == number[3])
  {
    Console.WriteLine($"Число {number} является палиндромом.");
  }

  else Console.WriteLine($"Введеное вами число - не палиндром.");
}

if (number.Length == 5)
{
  Palindrom(number);
}
else Console.WriteLine($"Вы ввели непятизначное число. Повторите попытку");

Console.WriteLine();

//////////////////////////////////////////////////////

Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве ");
Console.WriteLine();

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Расстояние между точками в 3D - пространстве составляет {segmentLength}");
Console.WriteLine();

//////////////////////////////////////////////////////

Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. ");
Console.WriteLine();

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string LineNumbersPow(int numberN, int pow)
{
    int i = 1;
    string line = "";
    string outLine = string.Empty;
    while (i <= numberN)
    {
        Console.Write("{0,7}" ,Math.Pow(i, pow));
        i++;
    }
    Console.WriteLine();
    return line;
}

int num = ReadData("Введите число N: ");

string line1 = LineNumbersPow(num, 1);
string line2 = LineNumbersPow(num, 3);

