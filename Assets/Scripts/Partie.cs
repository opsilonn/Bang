using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Partie
{
    public List<Joueur> joueurs;
    public List<Carte> pioche;
    public List<Carte> defausse;


    /// <summary>
    /// Constructeur par défaut de la classe Partie
    /// </summary>
    public Partie()
    {
        joueurs = new List<Joueur>();
        pioche = new List<Carte>();
        defausse = new List<Carte>();
    }


    /// <summary>
    /// Constructeur complet de la classe Partie
    /// </summary>
    /// <param name="joueurs"> Liste des joueurs présents </param>
    /// <param name="pioche"> Liste des cartes à piocher </param>
    /// <param name="defausse"> Liste des cartes défaussées </param>
    public Partie(List<Joueur> joueurs,  List<Carte> pioche, List<Carte> defausse)
    {
        this.joueurs = joueurs;
        this.pioche = pioche;
        this.defausse = defausse;
    }




    public Joueur TrouverJoueur(string nom)
    {
        foreach(Joueur joueur in joueurs)
        {
            if (joueur.GetPseudonyme() == nom)
                return joueur;
        }
        return null;
    }
     

    /// <summary>
    /// Mélange les Cartes de la pioche et de la défausse
    /// </summary>
    public void MelangerPioche()
    {
        pioche.AddRange(defausse);
        System.Random rng = new System.Random();
        int n = pioche.Count;
        while (n > 1)
        {
            n--;
            int index = rng.Next(n + 1);
            Carte carte = pioche[index];
            pioche[index] = pioche[n];
            pioche[n] = carte;
        }
    }
}
