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
            int val1, val2 ; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse = 0; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            int correct = 0; // utiliser dans la boucle try {} ... catch{} pour vérifier la saisie 
            int compteur = 0; // compteur de bonne réponse 
            int note = 0;

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
            Console.WriteLine($"Vous avez obtenu {compteur} bonne(s) réponse(s) sur {note} question(s) !");
            int resultat = (20 * compteur) / note;
            Console.WriteLine($"Vous avez : {resultat} / 20 "); 
            Console.ReadLine();
        }

    }
}
