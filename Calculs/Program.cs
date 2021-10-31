/**
 * Application "Calculs" v03 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2, solution, choix, reponse = 0, correct = 0, compteur = 0, note = 0, resultat = 0  ; 
           /*
            * val1 / val 2 = permet d'avoir les 2 paramètres pour l'addition et la multiplication 
            * choix = choix des calculs à effectuer 
            * solution = solution de l'opération 
            * réponse = réponse de l'utilisateur 
            * correct = variable utilisé pour la boucle try{}... catch{}
            * compteur = compteur de bonne réponse 
            * note = nombre de question au total 
            * resultat = note de l'utilisateur sur 20 
            */

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                val1 = rand.Next(1, 10);
                val2 = rand.Next(1, 10);
                correct = 0;
                // affiche le menu et saisi le choix
                while (correct != 1)
                {
                    try
                    {
                        Console.WriteLine("Addition ....................... 1");
                        Console.WriteLine("Multiplication ................. 2");
                        Console.WriteLine("Quitter ........................ 0");
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());
                        correct = 1;
                    }
                    catch
                    {
                        Console.WriteLine("Veuillez saisir un entier (0, 1 ou 2) :");
                    }
                }
                // traitement des choix
                if (choix == 1)
                {
                    correct = 0;
                    // saisie de la réponse
                    while (correct != 1)
                    {
                        try
                        {
                            Console.Write(val1 + " + " + val2 + " = ");
                            reponse = int.Parse(Console.ReadLine());
                            correct = 1;
                        }
                        catch
                        {
                            Console.WriteLine("Veuillez saisir un entier naturel");
                        }
                    }
                    note += 1; // compteur de question effectué 
                    // comparaison avec la bonne réponse
                    solution = val1 + val2;
                    if (reponse == solution)
                    {
                        Console.WriteLine("Bravo !");
                        compteur += 1;
                    }
                    else
                    {
                        Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                    }
                }
                else if (choix == 2)
                {
                    correct = 0;
                    // saisie de la réponse
                    while (correct != 1)
                    {
                        try
                        {
                            Console.Write(val1 + " x " + val2 + " = ");
                            reponse = int.Parse(Console.ReadLine());
                            correct = 1;
                        }
                        catch
                        {
                            Console.WriteLine("Veuillez saisir un entier naturel");
                        }
                    }
                    note += 1; // compteur de question effectué 
                    // comparaison avec la bonne réponse
                    solution = val1 * val2;
                    if (reponse == solution)
                    {
                        Console.WriteLine("Bravo !");
                        compteur += 1;
                    }
                    else
                    {
                        Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                    }
                }
                else if (choix > 2 || choix !=0)
                {
                    Console.WriteLine("Votre choix doit être compris entre 1 et 2 (0 pour quitter le programme)");
                }
            }
            Console.WriteLine("Fin du programme");

            // condition permettant d'afficher une note
            // si l'utilisateur quitte le programme dès le lancement, alors la condition n'est pas effectué car il y a 0 question, 0 réponse
            if (note != 0)
            {
                resultat = (20 * compteur) / note;
                Console.WriteLine($"Vous avez obtenu {compteur} bonne(s) réponse(s) sur {note} question(s) !");
                Console.WriteLine($"Vous avez : {resultat} / 20 ");
            }
            Console.ReadLine();
        }

    }
}
