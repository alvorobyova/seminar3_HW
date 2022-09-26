// Задача 19. 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void palindrom(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Число {number} является палиндромом.");
  }
  else Console.WriteLine($"Введеное вами число {number} - НЕ палиндром.");
}

if (number.Length == 5)
{
  Palindrom(number);
}
else Console.WriteLine("Введите пятизначное число");
