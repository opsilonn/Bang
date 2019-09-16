using UnityEngine;

public abstract class Carte
{
    private string _titre;
    private string _descriptionEffet;
    private string _valeur;
    private char _couleur;


    private static readonly string TITRE_PAR_DEFAUT = "Carte par Défaut";
    private static readonly string DESCRIPTION_PAR_DEFAUT = "Je n'ai pas d'effet !";




    /// <summary>
    /// Constructeur par défaut de la classe Carte
    /// </summary>
    public Carte()
    {
        titre = TITRE_PAR_DEFAUT;
        descriptionEffet = DESCRIPTION_PAR_DEFAUT;
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




    /// <summary> Retourne la couleur d'interface correspondante à celle de la Carte </summary>
    /// <returns> la couleur d'interface correspondante à celle de la Carte </returns>
    public Color GetColorUI()
    {
        if (couleur == '♥' || couleur == '♦')
            return Color.red;
        if (couleur == '♠' || couleur == '♣')
            return Color.black;

        return Color.green ;
    }

    /// <summary> Retourne la valeur et la couleur de la Carte </summary>
    /// <returns> La valeur et la couleur de la Carte </returns>
    public string GetValeurCouleur()
    {
        return valeur + " " + couleur;
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




    // PARAMETRES

    public string titre
    {
        get { return _titre; }
        set { _titre = value; }
    }

    public string descriptionEffet
    {
        get { return _descriptionEffet; }
        set { _descriptionEffet = value; }
    }
    public string valeur
    {
        get { return _valeur; }
        set { _valeur = value; }
    }

    public char couleur
    {
        get { return _couleur; }
        set { _couleur = value; }
    }
}