string[] slovo = { "slova", "bukvarm", "sdast" };
Random rnd = new Random();
System.Text.StringBuilder word = new System.Text.StringBuilder(slovo[rnd.Next(slovo.Length)]);
System.Text.StringBuilder mask = new System.Text.StringBuilder(new string('*', word.Length));
Console.Write(word);
Console.WriteLine(" ");
char s;
Console.WriteLine(mask);
while (mask.ToString().Contains('*'))
{
    Console.WriteLine("\nВведите предполагаемую букву: ");
    char answer = char.Parse(Console.ReadLine() ?? string.Empty);
    for (int i = 0; i < mask.Length; i++)
    {
        s = mask[i];
        if (!s.Equals('*'))
            Console.Write(s);
        else if(word[i].Equals(answer))
        {
            Console.Write(answer);
            mask[i] = answer;
        }
        else
        {
            Console.Write("*");
        }
    }
}