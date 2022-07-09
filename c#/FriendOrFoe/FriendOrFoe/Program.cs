using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static IEnumerable<string> FriendOrFoe(string[] names) => names.Where(x => x.Length == 4);

    public static void Main()
    {
        var items = Kata.FriendOrFoe(new string[] { "Ryan", "Kieran", "Mark", "Jimmy" });
        foreach (var item in items) Console.WriteLine(item);
    }
}