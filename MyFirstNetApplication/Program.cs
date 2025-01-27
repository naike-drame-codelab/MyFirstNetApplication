﻿using System.Globalization;
using System.Collections;
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


#region Tableaux
//// type de valeur[]
//// derrière les [] se cache la class Array --> type référence (struct en C# : type valeur)

////créer un tableau contenant 4 entiers
//// par défaut [0,0,0,0]
//int[] tableau = new int[4];
//Console.WriteLine();

//string[] tableauDeString = new string[4];
//// par défaut [null,null,null,null]

//// initialisation d'un tableau avec plusieurs valeurs
//string[] noms = [ "Khun", "Mike", "Thierry" ];
//string[] autresNoms = { "Khun", "Mike", "Thierry" };

//// comparer 2 tableaux
//Console.WriteLine(noms == autresNoms); // false car tableau = type référence, == : compare les adresses mémoires
//Console.WriteLine(noms.SequenceEqual(autresNoms)); // true, SequenceEqual() : compare les valeurs des 2 tableaux

//// récupérer un élément du tableau
//Console.WriteLine(noms[2]); ; // Thierry

//// modifier un élément du tableau
//Console.WriteLine(noms[2] = "Simon");
//Console.WriteLine(noms[2]); // Simon

//// slice
//string[] nomsDeMesCollegues = autresNoms[^2..]; // récupère un tableau contenant Mike et Thierry/ les 2 derniers éléments

//// longueur d'un tableau
//int l = nomsDeMesCollegues.Length;
//int l2 = nomsDeMesCollegues.Count(); // récupère la taille de n'importe quelle collection mais plus lent

//// attention à ne pas sortir des index d'un tableau
//// les tableaux ont une taille FIXE
////string n = noms[42]; // erreur

//// inverser les valeurs du tableau
//noms = noms.Reverse().ToArray();
//Console.WriteLine(string.Join(",", noms));

//// copier l'adresse mémoire du tableau
//string[] t = noms;
//t[0] = "Caroline";
//Console.WriteLine(noms[0]); // Caroline

//// copie des valeurs du tableau
//// string[] t2 = noms.ToArray();
//string[] t2 = [.. noms]; 
//t2[0] = "John";
//Console.WriteLine(noms[0]); //Caroline

//string[] t3 = ["Ringo", .. noms, "Steve"]; // ["Ringo", "Caroline", "Mike", "Khun", "Steve"]


////Any() : mieux d'utiliser Length pour des questions de performances
//int[] ints = new int[0];
////if(!ints.Any()) 
//if(ints.Length == 0)
//{
//    Console.WriteLine("Le tableau est vide");
//}


//// multidimension

//// tableau de tableaux ou orthogonaux
//int[][] tableauDeTableaux = new int[5][];
//tableauDeTableaux[0] = [1, 2, 3];
//tableauDeTableaux[1] = [5, 2, 42];

//// les tailles des tableaux internes peuvent être différentes
//tableauDeTableaux[2] = [5, 2, 44, 33, 66];
//Console.WriteLine();


//// tableau matriciel : chaque dimension contient le même nb d'éléments
//// les dimensions sont séparées par une virgule
//int[,] matrice = new int[4, 6];
//matrice[0, 5] = 42;

//int[,,,,] matrice5Dimensions = new int[4, 5, 3, 2, 6];
//Console.WriteLine();

//object[] objects = [1, "", 555F, true];
//object[][] tabtab = new object[5][];
//tabtab[0] = [1,2,3];
//tabtab[2] = ["", "", ""];

#endregion


#region Collections - ArrayList & List
// ArrayList - Besoin d'ajouter using System.Collections;
//on peut mettre ce que l'on veut

//ArrayList list = new();

//list.Add(42);
//list.Add(39);

//foreach(var item in list)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(list.Count);

//list.Add("Coucou");

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

////List : typé

//List<int> numbers = new();
//numbers.Add(42);
////ints.Add("Hello"); --> error

//numbers.Add(4.13);
//numbers.Add(42);



//// numbers.Remove(42); //retire la 1ère occurence trouvée --> [4.13, 42]
//// numbers.RemoveAt(2);
//// numbers.RemoveAll(x => x == 42);

//numbers.AddRange([12, 66, 55]); // [4.13, 42, 12, 66, 55]

//// vider une liste
//numbers.Clear();


//Console.WriteLine("--------");
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}


#endregion


#region Collections - Hashtable - A éviter car manque de typage cohérent

//Hashtable hashtable = new();

//// on détermine nous-mêmes les indices au départ (pas auto-incrémentés) --> key/value pair
//hashtable.Add("one", "Maison");
//hashtable.Add("two", "Appartement");
//hashtable.Add("three", "Chateau");

//// comme on définit nous-mêmes, cela peut amener à des inconvénients : 
//hashtable.Add(false, true);
//hashtable.Add("test", "khun");
//hashtable.Add("machin", "mike");

//foreach(var item in hashtable)
//{
//    Console.WriteLine(item.GetType());
//    Console.WriteLine(((DictionaryEntry)item).Value);
//}

#endregion


#region Collections - Dictionary<Tk, Tv>

//Dictionary<string, string> dico = new();
//dico.Add("test", "khun");
//dico.Add("machin", "mike");


//foreach(var item in dico.Values)
//{
//    Console.WriteLine(item);
//}
//foreach (var item in dico.Keys)
//{
//    Console.WriteLine("clé: ");
//    Console.WriteLine(item);
//    Console.WriteLine("valeur: ");
//    Console.WriteLine(dico[item]);
//}

//foreach (KeyValuePair<string, string> item in dico)
//{
//    Console.WriteLine("clé: ");
//    Console.WriteLine(item.Key);
//    Console.WriteLine("valeur: ");
//    Console.WriteLine(item.Value);
//}




#endregion


#region Collections  - Queue  - FIFO (// file d'attente)

#endregion


#region Collections  - Stack  - LIFO (// pile d'assiettes)

#endregion


#region Collections  - Objet anonyme
//Dictionary<string, int> trad = new(); //dictionary = similaire à objet anonyme
//trad.Add("One", 1);
//trad.Add("Two", 2);

//var trad2 = new { One = 1, Two = 2 };
//Console.WriteLine(trad["One"]);
//Console.WriteLine(trad2.One);

#endregion

#region Collections  - Objet dynamique
//dynamic d = new ExpandoObject();
//d.One = 1;
//d.Two = 2;
//d.Three = 3;

//Console.WriteLine(d.One);

#endregion


#region Structures
////-------------- Grosse différence entre struct & une class & un record: ----------------
//// struct =  de type valeur ---> n'est pas un élément null
//// class =  de type référence ---> peut être nullable
//// record = constante, on ne peut plus modifier les infos venant de l'extérieur = info de base fixe (// ajouter readonly)


//PersonStruct p = new PersonStruct();
//p.age = 42;
//p.fname = "Khun";
//p.name = "Ly";

//PersonStruct p2 = p;
//Console.WriteLine(p2.age); // 42

//PersonStruct.Test t = new();


//PersonClass p = new();
//p.age = 42;
//p.fname = "Khun";
//p.name = "Ly";
//PersonClass p2 = p;
//p2.age = 43;
//Console.WriteLine(p.age); // 43

//PersonClass p3 = new();
//p3.age = 42;
//p3.fname = "Mike";
//p3.name = "Person";


//PersonRecord record1 = new PersonRecord("Ly", "Khun", 42);
//// record1.name = "test"; // error : on ne peut pas modifier
//Console.WriteLine(record.age);


//// Création d'un struct = création d'un type
//// on peut créer des struct imbriquées (slide 167) 
//struct PersonStruct
//{
//    // !!! on ne peut pas définir de valeur par défaut sauf si déclarée avec const ou static
//    public string name; // ""
//    public string fname; // ""
//    public int age; //0
//    const int test = 42;

//    //peut avoir des méthodes
//    public void Speak() { }

//    //peut avoir des struct internes
//    public struct Test
//    {

//    }


//}


//class PersonClass
//{
//    public string name;
//    public string fname;
//    public int age;
//}

//record PersonRecord(string name, string fname, int age)
//{
//    public void Speak() { }
//}


#endregion


#region Méthodes 
//Fonction = ensemble d'instructions encapsulées dans un espace mémoire, avec un nom et le type de retour de ladite fonction

// appel de la fonction Speak()
Person p;
p.Speak();
p.Speak();
p.Speak();
p.Speak();
p.Speak();

// appel de la fonction Test()
Test();
Test();
Test();
Test();
Test();
Test();

// appel de la fonction FactorielDeNb() qui retourne n!
int value = FactorielDeNb(5);
Console.WriteLine(value);

// définition de la fonction Test() qui ne retourne rien
void Test()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Ceci est un test");
    Console.ResetColor();
}

// définition de la fonction FactorielDe5() qui retourne un int
int FactorielDeNb(int nb)
{
    int result = 1;
    for (int i = 2; i <= nb; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine(Divide(1, 3));
Console.WriteLine(Divide(42)); //on remplace le param a
Console.WriteLine(Divide(b : 42)); // on remplace le param b

double Divide( double a = 1, double b = 1) // avec params par défaut
{
    return a / b;
}

// un param précdé du mot-clé in n'est plus modifiable au sein de la fonction
void Test44(in string s = "", int nb = 55)
{
    // on ne peut plus le modifier
    //s = "fjhjfhfskj";
}

double Sum(params double[] values)   //lLorsque nous ignorons le nombre de paramètres à passer, on peut passer un ensemble de params ou un array de doubles
{
    double result = 0;

    foreach (var item in values)
    {
        result += item;
    }

    return result;
}

Console.WriteLine("--------------");
Console.WriteLine(Sum(42, 7, 8, 9, 11, 33, 99));
// ||     ||       ||
Console.WriteLine(Sum([42, 7, 8, 9, 11, 33, 99]));


int v = 42;
void UpdateValue(int v2)
{
    v2 = 45;
}

UpdateValue(v);
Console.WriteLine(v); // 42 car on modifie v2 et non v


//ref : on passe en param l'adresse mémoire de l'élément passé en param, et on peut ensuite modifier sa valeur
void UpdateValueWithRef(ref int v2)
{
    v2 = 45;
}

UpdateValueWithRef(ref v);
Console.WriteLine(v); // 45


List<int> list = [1,2,3];  
List<int> list2 = [1,2,3];   

UpdateList(list);
Console.WriteLine(list.Last());  // 4

void UpdateList(List<int> l)
{
    l.Add(4);
}

void UpdateListWithRef(ref List<int> l)
{
    l = [..l, 4];
}

UpdateListWithRef(ref list2);
Console.WriteLine(list2.Last()); // 4 car on modifie la ref list2

// --- ou == ref
void UpdateValueWithRef2(out int v2)
{
    v2 = 45;
}

UpdateValueWithRef2(out v);
Console.WriteLine(v); // 45

// on peut retourner plusieurs valeurs // un tuple
(int, bool, string, char) Test55555()
{
    return (42, true, "", '\n');
}

(int nb, bool flag, string s, char c) = Test55555();
(int, bool i, string, char) tuple = Test55555();
Console.WriteLine(nb);
Console.WriteLine(tuple.Item1); // 42
Console.WriteLine(tuple.i); // true

// ancienne syntaxe :
Tuple<int, bool> t = new Tuple<int, bool>(42, true);
int bbb = t.Item1;
bool fff = t.Item2;




// Surcharge de méthode : un seul nom de méthode, mais en fonction du param appelé, la bonne méthode sera appelée
/*
public void MyMethod()
{
    //
}
public void MyMethod(int i)
{
    //
}
public void MyMethod(string s)
{
    //
}

*/


//---------------//

struct Person
{
    // définition de la fonction ----> ne pas oublier d documenter la fonction avec un summary, plus qu'avec des commentaires
    /// <summary>
    /// Ecrit dans la console qqch
    /// </summary>
    public void Speak()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Bonjour, je m'appelle Khun");
        Console.ResetColor();
    }

}
#endregion