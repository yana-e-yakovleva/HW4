 // Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит 
 //число A в натуральную степень B. Задание должно быть выполнено в методе. В методе не должно 
 //быть вывода в консоль. Не использовать Math.Pow()


bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if (!isParsed)
{
    Console.WriteLine("Incorrect");
    return -1;
}

bool isParsed1 = int.TryParse(Console.ReadLine(), out int a);

if (!isParsed1)
{
    Console.WriteLine("Incorrect");
    return -1;
}

int number = numberDegree(n, a); 
Console.WriteLine(number);


int numberDegree( int n, int a)  // ЧТо он от меня хочет??
{
    int number = 0;
    for (int i = 1; n <= a; i++;)
    {
        number = n * n;
        return number;
    }
}


