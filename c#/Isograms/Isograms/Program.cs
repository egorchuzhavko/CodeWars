Console.WriteLine(IsIsogram("Dermatoglyphics"));

static bool IsIsogram(string str)
{
    int len = str.Length;
    return str.Where(c => Char.IsLetter(c)).Select(q => Char.ToLower(q)).Distinct().Count() == len;
}