using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carte_Effet_Rate : Carte_Effet
{
    private static readonly string TITRE_PAR_DEFAUT = "Raté !";
    private static readonly string DESCRIPTION_PAR_DEFAUT = "Esquivez un Bang";


    /// <summary>
    /// Constructeur avancé de la classe
    /// </summary>
    public Carte_Effet_Rate(string valeur, char couleur) : base(
        TITRE_PAR_DEFAUT,
        DESCRIPTION_PAR_DEFAUT,
        valeur,
        couleur)
    { }


    /// <summary>
    /// Constructeur complet de la classe
    /// </summary>
    public Carte_Effet_Rate() : base(
        TITRE_PAR_DEFAUT,
        DESCRIPTION_PAR_DEFAUT)
    { }




    public override void Effet()
    {
        throw new System.NotImplementedException();
    }
}
