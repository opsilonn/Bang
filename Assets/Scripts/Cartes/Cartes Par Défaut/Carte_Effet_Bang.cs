using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carte_Effet_Bang : Carte_Effet
{
    private static readonly string TITRE_PAR_DEFAUT = "Bang !";
    private static readonly string DESCRIPTION_PAR_DEFAUT = "Tirez sur un ennemi à portée";

    private static readonly bool EFFET_BANG_PAR_DEFAUT = true;
    private static readonly bool EFFET_BOIS_PAR_DEFAUT = false;
    private static readonly bool EFFET_RATE_PAR_DEFAUT = false;


    
    /// <summary>
    /// Constructeur avancé de la classe
    /// </summary>
    public Carte_Effet_Bang() : base(
        TITRE_PAR_DEFAUT,
        DESCRIPTION_PAR_DEFAUT,
        EFFET_BANG_PAR_DEFAUT,
        EFFET_BOIS_PAR_DEFAUT,
        EFFET_RATE_PAR_DEFAUT)
    { }


    /// <summary>
    /// Constructeur complet de la classe
    /// </summary>
    public Carte_Effet_Bang(string valeur, char couleur) : base(
        TITRE_PAR_DEFAUT,
        DESCRIPTION_PAR_DEFAUT,
        valeur,
        couleur,
        EFFET_BANG_PAR_DEFAUT,
        EFFET_BOIS_PAR_DEFAUT,
        EFFET_RATE_PAR_DEFAUT)
    { }





    public override void Effet()
    {
        throw new System.NotImplementedException();
    }
}
