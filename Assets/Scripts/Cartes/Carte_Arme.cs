using UnityEngine;

public class Carte_Arme : Carte
{
    private int portee;

    private static readonly string TITRE_PAR_DEFAUT = "Colt. 45";
    private static readonly string DESCRIPTION_EFFET_PAR_DEFAUT = "L'arme de base";
    private static readonly int PORTEE_PAR_DEFAUT = 1;


    /// <summary>
    /// Constructeur par défaut de la classe
    /// </summary>
    public Carte_Arme() : base(
            TITRE_PAR_DEFAUT,
            DESCRIPTION_EFFET_PAR_DEFAUT)
    {
        portee = PORTEE_PAR_DEFAUT;
    }
    
    
    
    
    /// <summary>
    /// Constructeur complet de la classe
    /// </summary>
    public Carte_Arme(string titre, string descriptionEffet, string valeur, char couleur, int portee) : base(
            titre,
            descriptionEffet,
            valeur,
            couleur)
    {
        this.portee = portee;
    }




    /// <summary> Retourne la portée de la Carte Arme </summary>
    /// <returns> La portée de la Carte Arme </returns>
    public int GetPortee() { return portee; }

    /// <summary> Change la portée de la carte </summary>
    /// <param name="portee"> La nouvelle portée de la carte </param>
    public void SetPortee(int portee) { this.portee = portee; }




    /// <summary>
    /// Affiche une représentation textuelle de l'instance dans la console
    /// </summary>
    public override void GetInfo()
    {
        Debug.Log("Carte Arme : " + GetTitre());
        Debug.Log("Effet : " + GetDescriptionEffet());
        Debug.Log("Distance de tir : " + GetPortee());
        Debug.Log("Valeur : " + GetValeur() + " " + GetCouleur());
        Debug.Log("");
    }




    /// <summary>
    /// L'effet de la carte
    /// </summary>
    public override void Effet()
    {
        throw new System.NotImplementedException();
    }



    /// <summary>
    /// Retourne la couleur de la bordure de la carte
    /// </summary>
    /// <returns> La couleur de la bordure de la carte </returns>
    public override Color32 GetCouleurEffet()
    {
        return new Color32(107, 140, 200, 255);
    }
}