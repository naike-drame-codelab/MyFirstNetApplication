// Calculer les 25 premiers nombres de la suite de Fibonacci
int fnMoins1 = 1, fnMoins2 = 1;
Console.WriteLine($"F1 : {fnMoins1}");
Console.WriteLine($"F2 : {fnMoins2}");

for (int i = 3; i <= 25; i++)
{
    int fn = fnMoins1 + fnMoins2;
    fnMoins2 = fnMoins1;
    fnMoins1 = fn;
    Console.WriteLine($"F{i} : {fn}");
}