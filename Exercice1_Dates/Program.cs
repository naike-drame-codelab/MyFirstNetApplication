#region Exercice 1 DateTime
DateTime today = DateTime.Now;
DateTime khunBirthday = DateTime.Parse("1982-05-06");
DateTime myBirthday = new DateTime(1990, 9, 20);

//Ex 1 : afficher âge
Console.WriteLine(today.Year - myBirthday.Year); // 34 - fonctionne uniquement si l'anniversaire est déjà passé
Console.WriteLine((today - myBirthday).TotalDays / 365.2425); //34,260796473847485

double age = (today - myBirthday).TotalDays / 365.2425;
Console.WriteLine((int)age); //34
Console.WriteLine(Math.Floor(age)); //34 - arrondi à l'unité inférieure

//Ex 2 : afficher différence age entre 1982-05-06 et ma date de naissance
Console.WriteLine(myBirthday.Year - khunBirthday.Year);

//Ex 3 : afficher le temps qui reste avant la pause de midi ("Il reste ..."); 
DateTime lunchTime = DateTime.Today.AddHours(12);
TimeSpan remainingTime = lunchTime - today;
Console.WriteLine(remainingTime);

DateTime pause = new DateTime(2024, 12, 23, 15, 0, 0);
TimeSpan diff = pause - today;
string pauseFormat = diff.ToString("c");
Console.WriteLine($"{diff.Hours:D2}:{diff.Minutes:D2}:{diff.Seconds:D2}");

#endregion
