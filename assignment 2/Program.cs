Console.Write($"Pleaase Enter the word : ");
string str = Console.ReadLine();
Dictionary <char,int> letterCounts = new Dictionary<char,int>();
foreach (var item  in str)
{
    if (letterCounts.ContainsKey(item))
    {
        letterCounts[item]++; 
    }
    else
    {
        letterCounts.Add(item,1) ; 
    }
}
foreach(var item in letterCounts)
{
    if (item.Value > 1)
    {
        Console.WriteLine($"{item.Key} = {item.Value}");
    }
}
