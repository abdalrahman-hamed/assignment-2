string str = "successfully";
int countS = 0;
int countU = 0;
int countC = 0;
int countE = 0;
int countF = 0;
int countL = 0;
int countY = 0;
foreach (var item in str)
{
    switch (item)
    {
        case 's':
            countS++;
            break;
        case 'u':
            countU++;
            break;
        case 'c':
            countC++;
            break;
        case 'e':
            countE++;
            break;
        case 'f':
            countF++;
            break;
        case 'l':
            countL++;
            break;
        case 'y':
            countY++;
            break;
    }
}
Console.WriteLine($"S = {countS}");
Console.WriteLine($"U = {countU}");
Console.WriteLine($"C = {countC}");
Console.WriteLine($"E = {countE}");
Console.WriteLine($"F = {countF}");
Console.WriteLine($"L = {countL}");
Console.WriteLine($"Y = {countY}");