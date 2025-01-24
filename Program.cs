
// Initialisation des variables
using System.Diagnostics;
using System.Globalization;

int numPass = 0;
int numEchec = 0;
double total = 0;
int count = 0;
double minGrade = 100.0;
double maxGrade = 0.0;
double grade = 0; //Variable non initialisée

do
{                   
    // Demander à l'utilisateur de saisir une note
    Console.WriteLine("Entrez une note ou -1 pour terminer : ");
                                    //Accepter le point (.) décimal
    grade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
} while (grade > 100 || grade < -1);
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

    do
    {
        // Demander une autre note
        Console.WriteLine("Entrez une note ou -1 pour terminer : ");
        grade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    } while (grade > 100 || grade < -1) ;
}
// Affichage des résultats
if (count > 0)
{
    double moyenne = total / count; // Variable non initialisée
    Console.WriteLine($"La moyenne est : {moyenne:F2}");
    Console.WriteLine("Le nombre de succès est : " + numPass);
    Console.WriteLine("Le nombre d'échecs est : " + numEchec);
    Console.WriteLine("La plus grande note est : " + maxGrade);
    Console.WriteLine("La plus petite note est : " + minGrade);

    // Succès ou échec
    if (Math.Round(moyenne) >= 60)
        Console.WriteLine("Cet étudiant passe !");
    else
        Console.WriteLine("Cet étudiant échoue !");
}
