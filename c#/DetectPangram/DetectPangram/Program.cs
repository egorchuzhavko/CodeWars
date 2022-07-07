string str = "Raw Danger! (Zettai Zetsumei Toshi 2) for the PlayStation 2 is a bit queer, but an alright game I guess, uh... CJ kicks and vexes Tenpenny precariously? This should be a pangram now, probably.";

Console.WriteLine(IsPangram(str));

static bool IsPangram(string str)
{
    str = str.ToLower();
    List<char> smbls = new List<char> { '1', '2', '3','4','5','6','7','8','9','0',
    '!','@','#','%','^','&','*','(',')','-','_','+','=','/','.',',','|',' ','?'};
    List<char> letters = new List<char>();
    foreach(char letter in str)
    {
        bool flag = false;
        foreach (char c in letters)
            if (c == letter)
            {
                flag = true;
                break;
            }
        bool flag1 = false;
        foreach(char c in smbls)
        {
            if(c == letter)
            {
                flag1 = true;
                break;
            }
        }
        if (!flag & !flag1) letters.Add(letter);
    }
    Console.WriteLine(letters.Count);
    return letters.Count == 26 ? true : false;
}