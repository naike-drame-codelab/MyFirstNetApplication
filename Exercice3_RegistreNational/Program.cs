// 3. Demander dans la console d'enregistrer un registre national belge (xx.xx.xx-xxx.yy)
// afficher dans la console si le registre est valide ou non
// n'est pas valide :
// si le nombre de caractères est incorrect
// si les . ou les - sont mal placés
// si les x ne sont pas des chiffres valides
// si les chiffres de contrôle à la fin ne sont pas bons
// (97 - xxxxxxxxx) % 97 != yy => pas valide
// bonus: ajouter la règle de contrôle si né après 2000
// vous ne pouvez pas utiliser de regex !!!

// Exemple:
// 82.05.06-203.16
// 97 - (820506203 % 97) = 16


// Main
Console.WriteLine("Entrez un numéro de registre national (11 chiffres, avec ou sans points/tirets) :");
string input = Console.ReadLine();
Console.WriteLine(IsValidBelgianNationalRegisterNumber(input) ? "Le numéro est valide." : "Le numéro est invalide.");

//Function
static bool IsValidBelgianNationalRegisterNumber(string nrn)
{
    // Retirer les points et les tirets de l'entrée
    nrn = nrn.Replace(".", "").Replace("-", "");

    // Vérifie la longueur et le contenu numérique
    if (nrn.Length != 11 || !long.TryParse(nrn, out _))
    {
        Console.WriteLine("Le numéro doit contenir exactement 11 chiffres après retrait des points et tirets.");
        return false;
    }

    // Récupère les parties du NRN
    long birthAndSequence = long.Parse(nrn.Substring(0, 9));
    int checksum = int.Parse(nrn.Substring(9, 2));

    // Calcul de la clé de contrôle
    int calculatedChecksum = 97 - (int)(birthAndSequence % 97);

    // Vérifie pour les personnes nées avant ou après 2000
    if (calculatedChecksum == checksum) return true;

    birthAndSequence += 2000000000;
    return (97 - (int)(birthAndSequence % 97)) == checksum;
}