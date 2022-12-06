//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

bool isParsed = int.TryParse(Console.ReadLine(), out int a);
if (!isParsed)
{Console.WriteLine("Incorrect number");
return;}

int TotalSum (int a) 
{
    int sum = 0; 

    while (a > 0) 
    {
        sum = sum + a % 10; 
        a = a / 10; 
    } 
    return sum; 
}

int sum = TotalSum(a);

Console.WriteLine(sum);
