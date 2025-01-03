// A l’aide de boucles « for » afficher les 5 premières tables de multiplication en allant jusque « x20 »
for (int tab = 1; tab <= 5; tab++)
{
    for (int multiplier = 1; multiplier <= 20; multiplier++)
    {
        Console.WriteLine($"{tab} X {multiplier} = {tab * multiplier}");
    }
    Console.WriteLine();
}
