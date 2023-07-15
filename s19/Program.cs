// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Polindrom (int n)
{
    int wspomogatN2 = n/1000;
    int n2= wspomogatN2%10;
    int wspomogatN4 = n/10;
    int n4= wspomogatN4%10;
    if (n>1000&&n<100000)
    {
    if(n/10000==n%10 && n2==n4)
    {
        Console.Write($"число является палиндромом");
    }
    else
    {
        Console.Write($"число не является палиндромом");
    }
    }
    else
    {
        Console.Write($"error");
    }
}



int GetInfo (string message)
{
    Console.Write(message);
    int numN = Convert.ToInt32(Console.ReadLine());
    return numN;
}


int n = GetInfo("Введите N: ");
Polindrom (n);
