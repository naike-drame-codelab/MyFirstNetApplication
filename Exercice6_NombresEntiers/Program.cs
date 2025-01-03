// Calculer les n nombres premiers
int nb = int.Parse(Console.ReadLine() ?? "");
int counter = 0;

for (int i = 2; counter < nb; i++)
{
    bool isPrime = true;
    for (int j = 2; j < i; j++)
    {
        if(i % j == 0)
        {
            isPrime = false;
        }

        if (isPrime)
        {
            Console.WriteLine(i);
            counter++;
        }
    }
}