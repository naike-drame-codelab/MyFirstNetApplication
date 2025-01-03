// Calculer le nombre factoriel d'un nombre donné
bool isConverted;
int number;
do
{
    Console.Write("Veuillez introduire un nombre entier : ");
    string input = Console.ReadLine();
    isConverted = int.TryParse(input, out number);
} while (!isConverted);

long value = 1;
for (int i = 2; i <= number; i++)
{
    checked
    {
        value *= i; //6 * 5 * 4 * 3 * 2 * 1
    }
}

Console.WriteLine($"Le factoriel de {number} est {value}.");
