// ReSharper disable StringLiteralTypo
Console.WriteLine("--------------------------------------");
Console.WriteLine("|  Bienvenue dans le jeux des maths  |");
Console.WriteLine("--------------------------------------");
Console.WriteLine("");


int NOMBREMIN = 1;
int NOMBREMAX = 10;
int NOMBREQUESTION = 5;


Operation(NOMBREQUESTION, NOMBREMIN, NOMBREMAX);


static void Operation(int NOMBREQUESTION, int NOMBREMIN, int NOMBREMAX)
{
    int BONNEREPONSE = 0;
    int NUMBER = 0;
    
    for (int i = 0; i < NOMBREQUESTION; i++)
    {
        Console.WriteLine($"Question: {i + 1} sur {NOMBREQUESTION}");
        
        Random aleatoire = new Random();
        int signe = aleatoire.Next(0, 2);
        
        int numberOne = aleatoire.Next(NOMBREMIN, NOMBREMAX);
        int numbertwo = aleatoire.Next(NOMBREMIN, NOMBREMAX);
        
        if (signe == 0)
        {
            Console.WriteLine($"{numberOne} + {numbertwo}");
            int RESPONSE = DemanderNombre(NUMBER);
            int operation = numberOne + numbertwo;
            if (RESPONSE == operation)
            {
                Console.WriteLine("Bonne réponse !");
                Console.WriteLine(operation);
                BONNEREPONSE++;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse !");
                Console.WriteLine(operation);
            }
        }

        if (signe == 1)
        {
            Console.WriteLine($"{numberOne} x {numbertwo}");
            int operation = numberOne * numbertwo;
            int RESPONSE = DemanderNombre(NUMBER);
            if (RESPONSE == operation)
            {
                Console.WriteLine("Bonne réponse !");
                BONNEREPONSE++;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse !");
            }
        }
    }
    Console.WriteLine($"Vous avez {BONNEREPONSE} bonne(s) réponse sûr {NOMBREQUESTION}");
};

static int DemanderNombre(int NUMBER)
{
    
    while (NUMBER <= 0)
    {
        Console.Write("Réponse : ");
        string number_str = Console.ReadLine();

        try
        {
            NUMBER = int.Parse(number_str);
            return NUMBER;
        }
        catch
        {
            Console.WriteLine("Erreur :  Vous devez rentrer un nombre valide.");
        }
    }
    Console.WriteLine($"fontction 2 {NUMBER}");
    return NUMBER;
}