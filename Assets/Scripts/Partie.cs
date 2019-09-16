using System.Collections.Generic;
using UnityEngine;

public class Partie
{
    private List<Joueur> _joueurs;
    private List<Carte> _pioche;
    private List<Carte> _defausse;


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







    /// <summary> Affiche les cartes de la pioche </summary>
    public void AfficherPioche()
    {
        if (pioche.Count == 0)
            Debug.Log("<b>Pioche : vide</b>");
        else
        {
            Debug.Log("<b>Pioche :</b>");
            foreach (Carte carte in pioche)
                Debug.Log(carte.titre);
        }
    }

    /// <summary> Affiche les cartes de la défausse </summary>
    public void AfficherDefausse()
    {
        if (defausse.Count == 0)
            Debug.Log("<b>Défausse : vide</b>");
        else
        {
            Debug.Log("<b>Défausse :</b>");
            foreach (Carte carte in defausse)
                Debug.Log(carte.titre);
        }
    }



    /// <summary> Retourne le joueur correspondant à son pseudo ; si non trouvé, retourne Null </summary>
    /// <param name="nom"> Nom du joueur recherché </param>
    /// <returns> Le joueur recherché, sinon null </returns>
    public Joueur TrouverJoueur(string nom)
    {
        foreach(Joueur joueur in joueurs)
        {
            if (joueur.pseudonyme == nom)
                return joueur;
        }
        return null;
    }
     



    /// <summary>
    /// Mélange les Cartes de la pioche et de la défausse
    /// </summary>
    public void MelangerPioche()
    {
        // On ajoute la défausse à la pioche, puis on la supprime
        pioche.AddRange(defausse);
        defausse.Clear();

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


    /// <summary>
    /// Vérifie pour chaque joueur s'il a gagné la partie
    /// </summary>
    /// <returns> True si au moins un joueur a gagné, sinon False </returns>

    public bool VerifierConditionsVictoire()
    {
        bool victoire = false;
        foreach (Joueur joueur in joueurs)
        {
            victoire = joueur.role.ConditionsVictoire(joueurs, joueur);

            Debug.Log(joueur.pseudonyme + " " + victoire);

            if (victoire)
                break;
        }

        return victoire;
    }


    /// <summary>
    /// Afficher les Cartes de la pioche et la défausse dans la console
    /// </summary>
    public void AfficherCartesPiocheDefausse()
    {
        AfficherPioche();
        Debug.Log("");
        AfficherDefausse();
    }




    // PARAMETRES

    public List<Joueur> joueurs
    {
        get { return _joueurs; }
        set { _joueurs = value; }
    }

    public List<Carte> pioche
    {
        get { return _pioche; }
        set { _pioche = value; }
    }

    public List<Carte> defausse
    {
        get { return _defausse; }
        set { _defausse = value; }
    }
}
