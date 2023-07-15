// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Qub (int n)
{
  int i = 1;
while (i<n)
{
  int itog = i*i*i;
  Console.Write($"{itog}, ");
  i++;
}  
Console.Write($"{n*n*n}.");
}

int GetInfo (string message)
{
    Console.Write(message);
    int numN = Convert.ToInt32(Console.ReadLine ());
    return numN;
}


int n = GetInfo("Введите N: ");
Qub (n);

