//Замена текста

ZadachaReplacetext();

void ZadachaReplacetext()
{
  string text = "Дуб — дерево."
                + "Оптика — раздел физики."
                + "Старший брат — мой учитель."
                + "Старший брат мой - учитель.";


  string newText = Replace(text, ' ', '|');
  Console.WriteLine(newText);
}

string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;

  int lenght = text.Length;
  for (int i = 0; i < lenght; i++)
  {
    if (text[i] == oldValue)
      result += $"{newValue}";
    else
      result += $"{text[i]}";
  }

  return result;
}

void Zadacha17()
{
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Random random = new Random();
int x = random.Next(-10, 11);
int y = random.Next(-10, 11);
Console.WriteLine($"A({x}, {y})"); 
if (y > 0 && x > 0)
{
    Console.WriteLine("Точки находятся в первой четверти"); 
}
else if (y > 0 && x < 0)
{
    Console.WriteLine("Точки находятся во второй четверти"); 
}
else if (y < 0 && x < 0)
{
    Console.WriteLine("Точки находятся в третьей четверти"); 
}
else if (y < 0 && x > 0)
{
    Console.WriteLine("Точки находятся в четвертой четверти"); 
}
else 
{
    Console.WriteLine("Точки лежат на одной из плоскостей");
}
}
Zadacha17();

void Zadacha18()
{
  //Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine ("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("y > 0 && x > 0"); 
}
else if (x == 2)
{
    Console.WriteLine("y > 0 && x < 0"); 
}
else if (x == 3)
{
    Console.WriteLine("y < 0 && x < 0"); 
}
else if (x == 4)
{
    Console.WriteLine("y < 0 && x > 0"); 
}
else 
{
    Console.WriteLine("Точки не лежат в одной из плоскостей");
}

}

void Zadacha21()
{
  // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine ("Введите х1 число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите х2 число: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите у1 число: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите у2 число: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int k = x2 - x1;
int m = y2 - y1;
double lenght = Math.Sqrt(k * k + m * m);
Console.WriteLine (lenght); 
Console.WriteLine($"Длина {lenght}"); 

}
Zadacha21();


void Zadacha22()
{
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Число\tквадрат");
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(" {0}\t{1}\t", i, Math.Pow(i,2)); 
}

}

void Zadacha19()
{
// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
int number = 23432;
int current_number = number;
int result = 0;
while (current_number > 0)
{
    int digit = current_number % 10;
    result = result * 10 + digit;
    current_number /=10;
    Console.WriteLine(result);
}
if (number == result)
{
    Console.WriteLine($"число {number} палиндром");
}
else
{
    Console.WriteLine($"число {number} не палиндром");
}
}
Zadacha19();

void Zadacha211()
{
// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine ("Введите Координаты точки А (ах): ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите Координаты точки А (аy): ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите Координаты точки А (аy): ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите Координаты точки B (bх): ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите Координаты точки B (by): ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите Координаты точки B (bz): ");
int bz = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
Console.WriteLine (result); 

}

Zadacha211();

void Zadacha23()
{
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

int number = 7;
int counter = 1;
while (counter <= number)
{
	Console.WriteLine($"{counter}*{counter}*{counter}*= {counter * counter * counter}");
	counter++;
}
}
Zadacha23();