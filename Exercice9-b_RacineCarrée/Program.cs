//  Calculer la racine carré d’un nombre avec maximum 10 décimales (Math.Sqrt(x) ne peut être utilisée que pour vérifier la réponse)
Console.Write("Entrez un nombre pour calculer sa racine carrée : ");
double x = double.Parse(Console.ReadLine());

if (x < 0)
{
    Console.WriteLine("La racine carrée d'un nombre négatif n'est pas définie pour les nombres réels.");
    return;
}

double epsilon = 1e-10; // Précision jusqu'à 10 décimales
double guess = x / 2;  // Estimation initiale

// Algorithme de Newton-Raphson
for (int i = 0; i < 100; i++) // Limite d'itérations pour éviter les boucles infinies
{
    double nextGuess = (guess + x / guess) / 2;

    if (Math.Abs(nextGuess - guess) < epsilon) // Convergence atteinte
    {
        guess = nextGuess;
        break;
    }

    guess = nextGuess;
}

Console.WriteLine($"La racine carrée calculée est : {guess:F10}");

// Vérification avec Math.Sqrt
double actualSqrt = Math.Sqrt(x);
Console.WriteLine($"Vérification avec Math.Sqrt : {actualSqrt:F10}");
