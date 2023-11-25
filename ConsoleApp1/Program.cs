int number = 1234567890;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {counter0++;}
    else if (letter == '1')
    {counter1++;}
    else if (letter == '2')
    { counter2++; }
    else if (letter == '3')
    { counter3++; }
    else if (letter == '4')
    { counter4++; }
    else if (letter == '5')
    { counter5++; }
    else if (letter == '6')
    { counter6++; }
    else if (letter == '7')
    { counter7++; }
    else if (letter == '8')
    { counter8++; }
    else if (letter == '9')
    { counter9++; }
}
Console.WriteLine("0=> " + counter0);
Console.WriteLine("1=> " + counter1);
Console.WriteLine("2=> " + counter2);
Console.WriteLine("3=> " + counter3);
Console.WriteLine("4=> " + counter4);
Console.WriteLine("5=> " + counter5);
Console.WriteLine("6=> " + counter6);
Console.WriteLine("7=> " + counter7);
Console.WriteLine("8=> " + counter8);
Console.WriteLine("9=> " + counter9);

/* -----------------Początek przykładów z lekcji------------------
int[] grades = new int[365];
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piątek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";
string[] dayOfWeeks2 = {"poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
Console.WriteLine(dayOfWeeks[2]);
Console.WriteLine(dayOfWeeks2[0]);
for (int i = 0; i <dayOfWeeks.Length; i=i+2)
{ 
    Console.WriteLine(dayOfWeeks[i]);
}
List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add( "wtorek");
dayOfWeeks.Add( "środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add( "niedziela");
for (int i = 0; i < dayOfWeeks.Count; i = i + 1)
{ Console.WriteLine(dayOfWeeks[i]);}
----------------Koniec przykładu--------------------
*/