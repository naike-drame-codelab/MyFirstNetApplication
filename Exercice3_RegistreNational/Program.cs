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


#region Réponse
// Main
//Console.WriteLine("Entrez un numéro de registre national (11 chiffres, avec ou sans points/tirets) :");
//string input = Console.ReadLine();
//Console.WriteLine(IsValidBelgianNationalRegisterNumber(input) ? "Le numéro est valide." : "Le numéro est invalide.");

////Function
//static bool IsValidBelgianNationalRegisterNumber(string nrn)
//{
//    // Retirer les points et les tirets de l'entrée
//    nrn = nrn.Replace(".", "").Replace("-", "");

//    // Vérifie la longueur et le contenu numérique
//    if (nrn.Length != 11 || !long.TryParse(nrn, out _))
//    {
//        Console.WriteLine("Le numéro doit contenir exactement 11 chiffres après retrait des points et tirets.");
//        return false;
//    }

//    // Récupère les parties du NRN
//    long birthAndSequence = long.Parse(nrn.Substring(0, 9));
//    int checksum = int.Parse(nrn.Substring(9, 2));

//    // Calcul de la clé de contrôle
//    int calculatedChecksum = 97 - (int)(birthAndSequence % 97);

//    // Vérifie pour les personnes nées avant ou après 2000
//    if (calculatedChecksum == checksum) return true;

//    birthAndSequence += 2000000000;
//    return (97 - (int)(birthAndSequence % 97)) == checksum;
//}
#endregion

#region Correction
Console.WriteLine("Entrez le registre national belge que vous souhaitez vérifier : ");
string enter = Console.ReadLine() ?? ""; //coalesce : si l'input est null, je mets une chaîne de caractère vide
int year, month, day;
string cleanedString = enter.Replace(".", "").Replace("-", "");
int toControl, controlNumber;

// Vérifier le nombre de caractères : xx.xx.xx-xxx.xx
//if (enter.Length != 15)
//{
//    Console.WriteLine("Invalide");
//}

//// Vérifier le placement des points et des tirets
//if (enter[2] != '.' || enter[5] != '.' || enter[12] != '.' || enter[8] != '-' )
//{
//    Console.WriteLine("Invalide");
//}

//// Vérifier que les 6 premiers caractères forment une date correcte

//if (!int.TryParse(enter[..2], out year))
//{
//    Console.WriteLine("Invalide");
//}

//else if (!int.TryParse(enter[3..5],out month) || month > 12)
//{
//    Console.WriteLine("Invalide");
//}

// else if(!!int.TryParse(enter[6..8], out day) || day > 31)
//{
//    Console.WriteLine("Invalide");
//}

//// Vérifier la clé de contrôle : (97 - (xxxxxxxxx % 97)) == xx

//else if (
//    !int.TryParse(cleanedString[..9], out toControl) 
//    || !int.TryParse(cleanedString[^2..], out controlNumber) 
//    || 97 - (toControl % 97) != controlNumber
//    )
//{
//    Console.WriteLine("Invalide");
//}

//else
//{
//    Console.WriteLine("Registre national valide");
//}


#endregion

#region Solution avec une Regex

#endregion