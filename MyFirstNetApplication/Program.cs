using System.Globalization;
using System.Text;

#region Console.WriteLine(), Console.ReadLine()
/* Console.WriteLine("Bonjour!");
Console.WriteLine("Comment vous appelez-vous ?");

string input = Console.ReadLine();

ConsoleKey key = Console.ReadKey(true).Key;

if (key == ConsoleKey.Enter)
{
    Console.WriteLine("Fais qqch");
}
else
{
    Console.WriteLine("Fais autre chose");
}


Console.WriteLine("Bienvenue " + input + " ! ♥"); 
*/
#endregion


#region Variables (déclaration, initialisation)
// déclaration d'une variable
//int number;

//// affectation d'une variable
//number = 42;

//// la variable ne peut contenier que des nombres entiers
//// number = "42"; --> False

//// initialisation d'une variable
//string name = "Naïké";

//// déclarer 2 variables de type int
//int avg1, avg2;


////définir dynamiquement le type d'une variable
//var v = "Bibi"; //type string défini à l'initialisation, on ne peut pas simplement déclarer une var

//var anonObject = new { Id = 42 }; // ici, var est obligatoire 

//var number2 = 42;
#endregion


#region Swap de variables
//Inverser la valeur de 2 variables via les tuples
//int v1 = 42;
//int v2 = 0;

////int t = v1;
////v1 = v2;
////v2 = t;

//(v1, v2) = (v2, v1);
//Console.WriteLine("V1: " + v1);
//Console.WriteLine("V2: " + v2);
#endregion


#region Types numériques
//// int
//int age = 42;
//int ageInBinary = 0b101010;
//int ageInHexa = 0x2A;

////long l = 2_000_000_000L * 10;
//double value = 3D / 2;
//Console.WriteLine(value);

//// decimal
//Console.WriteLine(0.1M * 3);
//Console.WriteLine(1M / 3 * 3);

//// float 
//Console.WriteLine(0.1F * 3);
//Console.WriteLine(1F / 3 * 3);

////petits nombres
//short number3 = 16;
//byte number4 = 8;


#endregion


#region Types caractères
//char c = 'N'; // toujours utiliser les simple qotes pour les char
//string fname = "Naïké";
//string lname = "Dramé";
//double price = 0.1D * 3;

//string s = "Bonjour \n les\t \"AMIS\"";
//string s2 = @"Bonjour
//les        ""amis""
//";

//string directory = "c:\\Users\\Desktop\\";
//string directory2 = @"c:\Users\Desktop\";


//Console.WriteLine(s);
//Console.WriteLine(s2);
//Console.WriteLine(directory);
//Console.WriteLine(directory2);

////concaténation
//Console.WriteLine("Bonjour " + fname + " " + lname + " !!!");
//// string format
//Console.WriteLine("Bonjour {0} {1} !!!", fname, lname);
////string interpolation
//Console.WriteLine($"Bonjour {fname} {lname} !!!");

////formater les chiffres
//Console.WriteLine($"Prix : {price:F2}"); //limite à 2 décimales

//int month = 1;
//int day = 5;
//int year = 2000;

//Console.WriteLine($"{day:D2}/{month:D2}/{year}");

//string alphabet = "abcdefghijklmnopqrstuvwxyz";
//char letter = alphabet[4];
//Console.WriteLine(letter); //e
//Console.WriteLine(alphabet[..5]); //abcde
//Console.WriteLine(alphabet[23..]); //xyz
//Console.WriteLine(alphabet[^3..]); //xyz
//Console.WriteLine(alphabet[5..10]); //fghij : àpd 5e non inclus jusqu'au 10e
//Console.WriteLine(alphabet[5..10] + alphabet[15..20] + "test"); //fghijpqrsttest
#endregion


#region Type DateTime
//DateTime date = new DateTime();
//Console.WriteLine(date);

//DateTime today = DateTime.Now;
//Console.WriteLine(today.ToString("dd/MM/yyyy"));
//Console.WriteLine($"{today:dd/MM/yyyy}");

//// DateTime startTraining = new DateTime(2024, 12, 9);
//DateTime startTraining = DateTime.Parse("2024-12-09");
//Console.WriteLine(startTraining);

//Console.WriteLine(startTraining.Year);
//Console.WriteLine(startTraining.DayOfWeek);

//DateTime birthday = new DateTime(1990, 9, 20);
//Console.WriteLine((today - birthday).TotalDays);
#endregion


#region Types booléens
//bool flag = false;
//bool flag2 = true;

//int age = 42;

//bool majeur = age > 1;
//Console.WriteLine(majeur);

//// > plus grand
//// >= plus grand ou égal
//// < plus petit
//// <= plus petit ou égale
//// == égal
//// != différent

//Console.WriteLine(42 == age);
//Console.WriteLine(42.Equals(age));

//string name = "    Cocoa  ".Trim();
//Console.WriteLine(name.Equals("Cocoa"));
//Console.WriteLine(name == "Cocoa");

//Console.WriteLine(name == "coCoA"); //false
//Console.WriteLine(name.Equals("cocoa", StringComparison.InvariantCultureIgnoreCase)); //true

////OU inclusif, ET, XOR (OU exclusif)
//bool jeuneAdulte = age > 18 && age < 30;
//Console.WriteLine(jeuneAdulte);
//Console.WriteLine(age == 42 || name == "Cocoa"); //OR
//Console.WriteLine(age == 42 ^ name == "Cocoa"); //XOR

//// changer OU en ET
//Console.WriteLine(age != 42 && name != "Cocoa");
//Console.WriteLine(!(!(age == 42) && !(name == "Cocoa")));

////inverser un booléen
//bool test = true;
//bool test2 = !test;

////loi de Morgan
////!(cond1 && cond2) <=> !cond1 || !cond2
////!(cond1 || cond2) <=> !cond1 && !cond2

//Console.WriteLine(true|true); //OU binaire
//Console.WriteLine(true&true); //ET binaire
//Console.WriteLine(true||true);

#endregion


#region Transtypage (cast)
////transtypage (cast) implicite

//int nb = 42;
//double nb2 = nb;
//double nb3 = 42.5;

//// transtypage (cast) explicite
//int nb4 = (int)nb3;
//// Equivalent CTS 
//Int32 nbInt32 = 42;


//string s = "42";
//// un string ne peut pat être casté en int car pas de relation entre eux cf. principe héritage
//// int nbEntier = (int)s;

//int nbEntier = int.Parse(s);
//Console.WriteLine(nbEntier * 25); 

//double floatNb = double.Parse("42.5");
//bool flag = bool.Parse("False");
//DateTime date = DateTime.Parse("1982-05-06T12:46:42");

//string v = 42.ToString();
//string v2 = DateTime.Now.ToString("dd MM yyyy", CultureInfo.GetCultureInfo("fr-BE"));
//Console.WriteLine(v2);

////ne fonctionne pas
////int myNumber = int.Parse("42.3"); 

//int.TryParse("42.3", out int myNumber);
//Console.WriteLine(myNumber); // va afficher valeur 0 car le system n'aura pas réussi à convertir mais le programme ne plante pas avec un TryParse()

//int a = default;
//Console.WriteLine(a); // O
//string b = default;
//string empty = string.Empty; //""
//Console.WriteLine(b); // ""
//bool c = default;
//Console.WriteLine(c); // False


//Console.WriteLine("Entrez un nombre: ");
//int inputNb;
//while(!int.TryParse(Console.ReadLine(), out inputNb))
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Valeur incorrecte");
//    Console.ResetColor();
//}
//Console.WriteLine(inputNb);


#endregion


#region Opérateurs
////string

////concaténation 
//Console.WriteLine("42" + 42); //4242

////nombre
////addition +
//Console.WriteLine(42 + 42); //84

////soustraction - 
//// division /
////multiplication *
//// modulo %
//Console.WriteLine(5 % 3); // 2 car 5 = 3*1 + 2

//// affectation
//int a = 42; //42
//a += 6; //a = a + 6 // 48
//a %= 9; // a = a % 9 // 3
//a <<= 2; // 12// 11 => 1100 // 12- déplacement binaire
////post-incrémentation
//a++; // 4 // a = a + 1
////pré-incrémentation
//++a; // 5 // a = a + 1 
////a--;
////--a;

//Console.WriteLine(++a); // 6
//Console.WriteLine(a); // 6

////opérateur ternaire
//int age = 42;
//string categorie = age >= 18 ? "Adulte" : "Enfant";
//Console.WriteLine(categorie);

////opérateur switch
//int jour = 5;
//string j = jour switch
//{
//    1 => "Lundi",
//    2 => "Mardi",
//    3 => "Mercredi",
//    _ => "Je ne sais pas"
//};

//Console.WriteLine(j);

////opérateur coalesce
//int? promo = null; // ? si on veut initialiser à null une variable//rendre une variable nullable
//int prix = 42;

//Console.WriteLine(42 - ((promo == null ? 0 : promo) * prix / 100)); // 32
////coalesce = ternaire qui donne une valeur par défaut si la variable est nulle
//Console.WriteLine(prix - ((promo ??  0) * prix / 100)); 

//string enter = Console.ReadLine() ?? string.Empty;

#endregion


#region Structures conditionnelles
//Console.WriteLine("Test");
//int age = 24;
//Console.OutputEncoding = Encoding.UTF8;

//// if : on teste des conditions
//if (age >= 18)
//{
//    // instructions
//    Console.WriteLine("🙈🙈🙈");
//}
//else if(age >= 12) {
//    Console.WriteLine("🐼🐼🐼");
//}
//else
//{
//    // autres instructions
//    Console.WriteLine("🦄🦄🦄");
//}

//string temps = "Soleil";
//// switch : on teste généralement des égalités, pour tester dans un switch des conditions on utilise when
//// case "Soleil" when temps.Length > 5:
//switch (temps)
//{
//    case "Soleil":
//    case "Sunny":
//        //instructions
//        Console.WriteLine("🌞");
//        break;
//    case "Nuage":
//    case "Cloudy":
//        Console.WriteLine("☁☁☁");
//        break;
//    default:
//        Console.WriteLine("🌈🌈🌈");
//        break;
//}


#endregion


#region Boucles
// for (itérateur; condition d'arrêt de la boucle; évolution de l'itérateur à chaque boucle)
// quand on sait le nb de fois que l'on veut itérer
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//    Console.WriteLine("Hello");
//}

//// multiple itérateur
//for (int i = 0, j = 25; i < 10 || j > 5; i++, j -= 2)
//{
//    Console.WriteLine(i);
//    Console.WriteLine(j);
//    Console.WriteLine("_______");
//}

// while
// quand on ne sait pas le nb de fois que l'on veut itérer
//bool condition = true;
//while (condition)
//{
//    Console.WriteLine("Entrez un nombre : ");
//    int nb = int.Parse(Console.ReadLine());
//    if (nb > 5)
//    {
//        condition = false;
//    }
//}

//int nb = 0;
////while (nb <= 5)
////{
////    Console.WriteLine("Entrez un nombre : ");
////    nb = int.Parse(Console.ReadLine());
////}

//// do while
//// pour être certain que les instructions soient exécutées au moins une fois
//do
//{
//    Console.WriteLine("Entrez un nombre : ");
//    nb = int.Parse(Console.ReadLine());
//} while (nb <= 5);

//// foreach
//int[] tab = [42, 73, 12, 53, 4, 15, 66, 87];
//foreach (int value in tab)
//{
//    Console.WriteLine(value);
//}

//// le foreach équivaut à un while caché :
//var enumerator = tab.GetEnumerator();
//while (enumerator.MoveNext())
//{
//    Console.WriteLine(enumerator.Current);
//}
//enumerator.Reset();


#endregion