using UnityEngine;

public abstract class Carte
{
    private string titre;
    private string descriptionEffet;
    private string valeur;
    private char couleur;




    /// <summary>
    /// Constructeur par défaut de la classe Carte
    /// </summary>
    public Carte()
    {
        titre = "Carte par Défaut";
        descriptionEffet = "Je n'ai pas d'effet !";
        SetValeurCouleurAleatoire();
    }


    /// <summary>
    /// Constructeur avancé de la classe Carte
    /// </summary>
    /// <param name="titre"> Nom de la Carte </param>
    /// <param name="descriptionEffet"> Description de l'effet de la Carte </param>
    public Carte(string titre, string descriptionEffet)
    {
        this.titre = titre;
        this.descriptionEffet = descriptionEffet;
        SetValeurCouleurAleatoire();
    }


    /// <summary>
    /// Constructeur complet de la classe Carte
    /// </summary>
    /// <param name="titre"> Nom de la Carte </param>
    /// <param name="descriptionEffet"> Description de l'effet de la Carte </param>
    /// <param name="valeur"> Valeur de la Carte </param>
    /// <param name="couleur"> Couleur de la Carte </param>
    public Carte(string titre, string descriptionEffet, string valeur, char couleur)
    {
        this.titre = titre;
        this.descriptionEffet = descriptionEffet;
        this.valeur = valeur;
        this.couleur = couleur;
    }



    public void SetValeurCouleurAleatoire()
    {
        string chars = "♥♦♠♣";
        System.Random rand = new System.Random();

        valeur = rand.Next(1, 13).ToString();
        if (valeur == "11") valeur = "J";
        if (valeur == "12") valeur = "Q";
        if (valeur == "13") valeur = "K";
        couleur = chars[rand.Next(0, chars.Length - 1)];
    }




    /// <summary> Retourne le titre de la Carte </summary>
    /// <returns> le titre de la Carte </returns>
    public string GetTitre() { return titre; }

    /// <summary> Change le titre de la carte </summary>
    /// <param name="titre"> le nouveau titre de la carte </param>
    public void SetTitre(string titre) { this.titre = titre; }




    /// <summary> Retourne la Description de l'Effet de la Carte </summary>
    /// <returns> la Description de l'Effet de la Carte </returns>
    public string GetDescriptionEffet() { return descriptionEffet; }

    /// <summary> Change la Description de l'Effet de la carte </summary>
    /// <param name="descriptionEffet"> la nouvelle Description de l'Effet de la carte </param>
    public void SetDescriptionEffet(string descriptionEffet) { this.descriptionEffet = descriptionEffet; }




    /// <summary> Retourne la valeur de la Carte </summary>
    /// <returns> la valeur de la Carte </returns>
    public string GetValeur() { return valeur; }

    /// <summary> Change la valeur de la carte </summary>
    /// <param name="valeur"> la nouvelle valeur de la carte </param>
    public void SetValeur(string valeur) { this.valeur = valeur; }




    /// <summary> Retourne la couleur de la Carte </summary>
    /// <returns> la couleur de la Carte </returns>
    public char GetCouleur() { return couleur; }

    /// <summary> Change la couleur de la carte </summary>
    /// <param name="couleur"> la nouvelle couleur de la carte </param>
    public void SetCouleur(char couleur) { this.couleur = couleur; }




    /// <summary> Retourne la couleur d'interface correspondante à celle de la Carte </summary>
    /// <returns> la couleur d'interface correspondante à celle de la Carte </returns>
    public Color GetColorUI()
    {
        if (couleur == '♥' || couleur == '♦')
            return Color.red;
        if (couleur == '♠' || couleur == '♣')
            return Color.black;

        return Color.blue;
    }

    /// <summary> Retourne la valeur et la couleur de la Carte </summary>
    /// <returns> La valeur et la couleur de la Carte </returns>
    public string GetValeurCouleur()
    {
        return GetValeur() + " " + GetCouleur();
    }



    /// <summary>
    /// Affiche une représentation textuelle de l'instance dans la console
    /// </summary>
    public abstract void GetInfo();




    /// <summary>
    /// L'effet de la carte
    /// </summary>
    public abstract void Effet();



 
    /// <summary>
    /// Retourne la couleur de la bordure de la carte
    /// </summary>
    /// <returns> La couleur de la bordure de la carte </returns>
    public abstract Color32 GetCouleurEffet();
}