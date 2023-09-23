using System.Data.SqlTypes;
using System.Net.Http.Headers;

int number = 4566;
string numberAsString = number.ToString();
Char[] letters = numberAsString.ToArray();

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
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}

if (counter0 != 0)
{
    Console.WriteLine("Liczba 0 występuje");
    Console.WriteLine(counter0);
    Console.WriteLine("raz(y)");
    Console.WriteLine();
}

if (counter1 != 0)
{
    Console.WriteLine("Liczba 1 występuje");
    Console.WriteLine(counter1);
    Console.WriteLine("raz(y)");
    Console.WriteLine();
}

if (counter2 != 0)
{
    Console.WriteLine("Liczba 2 występuje");
    Console.WriteLine(counter2);
    Console.WriteLine("raz(y)");
    Console.WriteLine();
}

if (counter3 != 0)
{
    Console.WriteLine("Liczba 3 występuje");
    Console.WriteLine(counter3);
    Console.WriteLine("raz(y)");
    Console.WriteLine();
}

if (counter4 != 0)
{
    Console.WriteLine("Liczba 4 występuje");
    Console.WriteLine(counter4);
    Console.WriteLine("raz(y)");
    Console.WriteLine();
}

if (counter5 != 0)
{
    Console.WriteLine("Liczba 5 występuje");
    Console.WriteLine(counter5);
    Console.WriteLine("raz(y)");
    Console.WriteLine();
}

if (counter6 != 0)
{
    Console.WriteLine("Liczba 6 występuje");
    Console.WriteLine(counter6);
    Console.WriteLine("raz(y)");
    Console.WriteLine();
}

if (counter7 != 0)
{
    Console.WriteLine("Liczba 7 występuje");
    Console.WriteLine(counter7);
    Console.WriteLine("raz(y)");
    Console.WriteLine();
}

if (counter8 != 0)
{
    Console.WriteLine("Liczba 8 występuje");
    Console.WriteLine(counter8);
    Console.WriteLine("raz(y)");
    Console.WriteLine();
}

if (counter9 != 0)
{
    Console.WriteLine("Liczba 9 występuje");
    Console.WriteLine(counter9);
    Console.WriteLine("raz(y)");
    Console.WriteLine();
}