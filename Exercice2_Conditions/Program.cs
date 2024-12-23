// 1. Demander dans la console une année
// afficher l'année est bissextile
// ou l'année n'est pas bissextile
// Exemples : 
// 1999 => pas bissextile
// 1996 => bissextile
// 1600 => bissextile
// 1700 pas bissextile


// 2. Demander dans la console d'enregistrer un registre national belge (xx.xx.xx-xxx.yy)
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