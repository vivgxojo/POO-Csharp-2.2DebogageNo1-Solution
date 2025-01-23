
// Initialisation des variables
using System.Globalization;

double numPass = 0;
double numEchec = 0;
double total = 0;
double count = 0;
double minGrade = 100.0;
double maxGrade = 0.0;

// Demander à l'utilisateur de saisir une note
Console.WriteLine("Entrez une note ou -1 pour terminer : ");
//Variable non initialisée
double grade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
while (grade >= 0.0)
{
    // Déterminer le nombre de réussites et d'échecs
    if (grade >= 60.0)
        numPass = numPass + 1; //Erreur dans le nom de variable
    else
        numEchec = numEchec + 1;

    // Déterminer la note la plus petite ou la plus grande
    if (grade < minGrade)
        minGrade = grade;    //Erreur dans le nom de variable
    if (grade > maxGrade)
        maxGrade = grade;    //Erreur dans le nom de variable

    // Calculer la somme des notes
    total = total + grade; //Erreurs nom de variable et de calcul 
    count = count + 1;

    // Demander une autre note
    Console.WriteLine("Entrez une note ou -1 pour terminer : ");
    grade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

}
// Affichage des résultats
if (count > 0)
{
    double moyenne = total / count; // Variable non initialisée
    Console.WriteLine("La moyenne est : " + Math.Round(moyenne, 2));
    Console.WriteLine("Le nombre de succès est : " + numPass);
    Console.WriteLine("Le nombre d'échecs est : " + numEchec);
    Console.WriteLine("La plus grande note est : " + maxGrade);
    Console.WriteLine("La plus petite note est : " + minGrade);

    // Succès ou échec
    if (moyenne >= 60.00)
        Console.WriteLine("Cet étudiant passe !");
    else
        Console.WriteLine("Cet étudiant échoue !");
}
