using UnityEngine;

public abstract class Carte_Effet : Carte
{
    private bool effetBang;
    private bool effetBoisson;
    private bool effetRate;


    /// <summary>
    /// Constructeur par défaut de la classe
    /// </summary>
    public Carte_Effet(string titre, string descriptionEffet, bool effetBang, bool effetBoisson, bool effetRate) : base(
            titre,
            descriptionEffet)
    {
        this.effetBang = effetBang;
        this.effetBoisson = effetBoisson;
        this.effetRate = effetRate;
    }




    /// <summary>
    /// Constructeur complet de la classe
    /// </summary>
    public Carte_Effet(string titre, string descriptionEffet, string valeur, char couleur, bool effetBang, bool effetBoisson, bool effetRate) : base(
            titre,
            descriptionEffet,
            valeur,
            couleur)
    {
        this.effetBang = effetBang;
        this.effetBoisson = effetBoisson;
        this.effetRate = effetRate;
    }




    /// <summary> Retourne true si la Carte a un effet Bang, sinon false </summary>
    /// <returns> true si la Carte a un effet Bang, sinon false </returns>
    public bool GetEffetBang() { return effetBang; }

    /// <summary> Change le booléen assurant si la carte a un effet Bang ou non </summary>
    /// <param name="effetBang"> le booléen assurant si la carte a un effet Bang ou non </param>
    public void SetEffetBang(bool effetBang) { this.effetBang = effetBang; }




    /// <summary> Retourne true si la Carte a un effet Boisson, sinon false </summary>
    /// <returns> true si la Carte a un effet Boisson, sinon false </returns>
    public bool GetEffetBoisson() { return effetBoisson; }

    /// <summary> Change le booléen assurant si la carte a un effet Boisson ou non </summary>
    /// <param name="effetBoisson"> le booléen assurant si la carte a un effet Boisson ou non </param>
    public void SetEffetBoisson(bool effetBoisson) { this.effetBoisson = effetBoisson; }




    /// <summary> Retourne true si la Carte a un effet Raté, sinon false </summary>
    /// <returns> true si la Carte a un effet Raté, sinon false </returns>
    public bool GetEffetRate() { return effetRate; }

    /// <summary> Change le booléen assurant si la carte a un effet Raté ou non </summary>
    /// <param name="effetRate"> le booléen assurant si la carte a un effet Raté ou non </param>
    public void SetEffetRate(bool effetRate) { this.effetRate = effetRate; }




    /// <summary>
    /// Affiche une représentation textuelle de l'instance dans la console
    /// </summary>
    public override void GetInfo()
    {
        Debug.Log("Carte Effet : " + titre);
        Debug.Log("Effet : " + descriptionEffet);
        Debug.Log("Effet Bang : " + GetEffetBang());
        Debug.Log("Effet Boisson : " + GetEffetBoisson());
        Debug.Log("Effet Raté : " + GetEffetRate());
        Debug.Log("Valeur : " + valeur + " " + couleur);
        Debug.Log("");
    }




    /// <summary>
    /// Retourne la couleur de la bordure de la carte
    /// </summary>
    /// <returns> La couleur de la bordure de la carte </returns>
    public override Color32 GetCouleurEffet()
    {
        return new Color32(164, 157, 199, 255);
    }
}
