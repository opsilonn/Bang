using UnityEngine;

public class Carte_Equipement : Carte
{
    /// <summary>
    /// Constructeur par défaut de la classe
    /// </summary>
    public Carte_Equipement(string titre, string descriptionEffet) : base(
            titre,
            descriptionEffet)
    { }




    /// <summary>
    /// Constructeur complet de la classe
    /// </summary>
    public Carte_Equipement(string titre, string descriptionEffet, string valeur, char couleur) : base(
            titre,
            descriptionEffet,
            valeur,
            couleur)
    { }

    public override void Effet()
    {
        throw new System.NotImplementedException();
    }




    /// <summary>
    /// Affiche une représentation textuelle de l'instance dans la console
    /// </summary>
    public override void GetInfo()
    {
        Debug.Log("Carte Equipement : " + GetTitre());
        Debug.Log("Effet : " + GetDescriptionEffet());
        Debug.Log("Valeur : " + GetValeur() + " " + GetCouleur());
        Debug.Log("");
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
