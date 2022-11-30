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
Zadacha18(); 

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
}
Zadacha22(); 
void Zadacha19()
{
// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

}