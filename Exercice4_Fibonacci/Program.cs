// Calculer les 25 premiers nombres de la suite de Fibonacci
int f0 = 0, f1 = 1;
Console.WriteLine($"F0 : {f0}");
Console.WriteLine($"F1 : {f1}");
int fNext;

for (int i = 2; i <= 25; i++)
{
    fNext = f0 + f1;
    Console.WriteLine($"F{i} : {fNext}");
    f0 = f1;
    f1 = fNext;
    i++;
}