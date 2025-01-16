using System;
using System.Diagnostics;

class PierreFeuilleCiseau
{
    public string playerChoice = "";
    public string aIChoice = "";
    int playerScore = 0;
    int aIScore = 0;
    List<string> possibleChoices = new List<string> {"Pierre" , "Feuille", "Ciseaux"};

    void LaunchGame()
    {
        while(true)
        {
            Console.WriteLine("Bienvenue dans le jeu Pierre / Feuille / Ciseaux !");
            
            // Choix du joueur
            Console.WriteLine("Veuillez entrer votre choix pour ce tour : ");
            string playerChoice = Console.ReadLine();
            if (possibleChoices.Contains(playerChoice))
            {
                Console.WriteLine("Vous avez choisi : " + playerChoice);
            }

            else {Console.WriteLine("Choix non valide. Veuillez réessayer");}
        
            // Choix de l'IA
            Random random = new Random();
            int aIChoiceIndex = random.Next(0, possibleChoices.Count);
            aIChoice = possibleChoices[aIChoiceIndex];

            Console.WriteLine("L'IA a choisi : " + aIChoice);

            string roundOutcome = PlayerVictory(playerChoice, aIChoice);
            
            if(roundOutcome == "player") 
            { 
                playerScore++;
            }
            else if (roundOutcome == "ai") 
            { 
                aIScore++;
            }
            else
            {

            }

            Console.WriteLine("Le score est de " + playerScore + " (vous) à " + aIScore + " IA");

        }
    }
    static string PlayerVictory(string playerChoice, string aIChoice)
    {
        if (playerChoice == aIChoice)
        {
            Console.WriteLine("Egalité !");
            return "none";
        }

        else
        {
            switch (playerChoice)
            {
                case "Pierre":
                    if (aIChoice == "Feuille")
                    {
                        Console.WriteLine("Perdu !");
                        return "ai";
                    }
                    else
                    {
                        Console.WriteLine("Gagné !");
                        return "player";
                    }
                    break;

                case "Feuille":
                    if (aIChoice == "Ciseaux")
                    {
                        Console.WriteLine("Perdu !");
                        return "ai";
                    }
                    else
                    {
                        Console.WriteLine("Gagné !");
                        return "player";
                    }
                    break;

                case "Ciseaux":
                    if (aIChoice == "Pierre")
                    {
                        Console.WriteLine("Perdu !");
                        return "ai";
                    }
                    else
                    {
                        Console.WriteLine("Gagné !");
                        return "player";
                    }
                    break;
            }
            return "none"; // Retour par défaut si aucune valeur n'est reconnue
        }
    }

    static void Main()
    {
        PierreFeuilleCiseau game = new PierreFeuilleCiseau();
        game.LaunchGame();
    }
}
