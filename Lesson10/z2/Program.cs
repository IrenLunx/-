// В некотором машинном алфавите имеются четыре буквы "а", "и", "с", "в". 
// Покажите все слова, состоящие из n букы, которые можно построить из букв алфавита

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);
