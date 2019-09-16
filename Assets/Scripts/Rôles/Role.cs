using System.Collections.Generic;
using UnityEngine;


public abstract class Role
{  
    private string _titre;
    private string _but;


    /// <summary>
    /// Constructeur complet de la classe Role
    /// </summary>
    /// <param name="role"> Rôle (titre) du Rôle </param>
    /// <param name="but"> But (description de son objectif) du Rôle </param>
    public Role(string role, string but)
    {
        this._titre = role;
        this._but = but;
    }



    /// <summary>
    /// Affiche une représentation textuelle de l'instance dans la console
    /// </summary>
    public void GetInfo()
    { 
       Debug.Log("Titre : " + titre );
       Debug.Log("But : " + but );
    }


    /// <summary>
    /// Vérifie si les conditions de Victoire sont remplies
    /// </summary>
    /// <returns> True si les conditions sont remplies, sinon False </returns>
    public abstract bool ConditionsVictoire(List<Joueur> joueurs, Joueur soiMeme);





    // PARAMETRES
    public string titre
    {
        get
        {
            return _titre;
        }
        set
        {
            _titre = value;
        }
    }
    public string but
    {
        get
        {
            return _but;
        }
        set
        {
            _but = value;
        }
    }
}