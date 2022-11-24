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
