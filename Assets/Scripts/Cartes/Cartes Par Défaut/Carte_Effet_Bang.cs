using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carte_Effet_Bang : Carte_Effet
{
    private static readonly string TITRE_PAR_DEFAUT = "Bang !";
    private static readonly string DESCRIPTION_PAR_DEFAUT = "Tirez sur un ennemi à portée";


    /// <summary>
    /// Constructeur avancé de la classe
    /// </summary>
    public Carte_Effet_Bang(string valeur, char couleur) : base(
        TITRE_PAR_DEFAUT,
        DESCRIPTION_PAR_DEFAUT,
        valeur,
        couleur)
    { }

    
    /// <summary>
    /// Constructeur complet de la classe
    /// </summary>
    public Carte_Effet_Bang() : base(
        TITRE_PAR_DEFAUT,
        DESCRIPTION_PAR_DEFAUT)
    { }




    public override void Effet()
    {
        throw new System.NotImplementedException();
    }
}
