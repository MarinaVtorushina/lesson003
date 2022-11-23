// See https://aka.ms/new-console-template for more information
Void ZadachaReplacetext()

{   
        string text = "Дуб — дерево."
        + "Оптика — раздел физики."
        + "Старший брат — мой учитель."
        + "Старший брат мой - учитель.";

        string Replace (string text, char oldValue, char newValue)
    {
        string result = String.Empty;

        int lenght = text.lenght;
        for (int i = 0; i < lenght; i++)
        {
            if(text [i] ==oldValue) resalt = result + $"{newValue}";
            else result = result + $"{text [i]}";
        }
        
        return result;
    }

    string newText = Replace(text, ' ', '|');
    Console.WriteLine(newText);
}
Void ZadachaReplacetext();