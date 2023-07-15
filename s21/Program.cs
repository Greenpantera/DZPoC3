// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

double Rasstoyanie(int x1, int x2, int y1, int y2,int z1, int z2)
{
    int itog = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1);
    double resultat = Math.Sqrt(itog);
    return resultat;
}

int GetInfo (string message)
{
    Console.Write(message);
    int numTotschka = Convert.ToInt32(Console.ReadLine ());
    return numTotschka;
}

int x1 = GetInfo("Введите x1: ");
int y1 = GetInfo("Введите y1: ");
int z1 = GetInfo("Введите z1: ");
int x2 = GetInfo("Введите x2: ");
int y2 = GetInfo("Введите y2: ");
int z2 = GetInfo("Введите z2: ");
Console.WriteLine($"Расстояние между двумя точками будет: {Rasstoyanie(x1, x2, y1, y2, z1, z2)}");

