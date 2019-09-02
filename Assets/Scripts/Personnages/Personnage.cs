using UnityEngine;


public class Personnage
{
    private string nom;

    private int vie;
    private int vieMax;

    private string descriptionPouvoir;

    private bool sexe;
    private string nationalite;
    private char tierList;

    private int eloignement;
    private int visee;

    private static readonly string NOM_PAR_DEFAUT = "John Doe";
    private static readonly int    VIE_PAR_DEFAUT = 4;
    private static readonly int    VIE_MAX_PAR_DEFAUT = 4;
    private static readonly string DESCRIPTION_POUVOIR_PAR_DEFAUT = "Je n'ai aucun pouvoir ...";
    private static readonly bool   SEXE_PAR_DEFAUT = true;
    private static readonly string NATIONALITE_PAR_DEFAUT = "Américain";
    private static readonly char   TIERLIST_PAR_DEFAUT = 'A';
    private static readonly int    ELOIGNEMENT_PAR_DEFAUT = 0;
    private static readonly int    VISEE_PAR_DEFAUT = 0;


    /// <summary>
    /// Constructeur par défaut de la classe Personnage
    /// </summary>
    public Personnage()
    {
        nom = NOM_PAR_DEFAUT;

        vie = VIE_PAR_DEFAUT;
        vieMax = VIE_MAX_PAR_DEFAUT;

        descriptionPouvoir = DESCRIPTION_POUVOIR_PAR_DEFAUT;

        sexe = SEXE_PAR_DEFAUT;
        nationalite = NATIONALITE_PAR_DEFAUT;
        tierList = TIERLIST_PAR_DEFAUT;

        eloignement = ELOIGNEMENT_PAR_DEFAUT;
        visee = VISEE_PAR_DEFAUT;
    }


    /// <summary>
    /// Constructeur complet de la classe Personnage
    /// </summary>
    /// <param name="nom"> nom du Personnage </param>
    /// <param name="vie"> vie actuelle du Personnage </param>
    /// <param name="vieMax"> vie Maximale du Personnage </param>
    /// <param name="descriptionPouvoir"> description du pouvoir du Personnage </param>
    /// <param name="sexe"> sexe du Personnage </param>
    /// <param name="nationalite"> nationalite du Personnage </param>
    /// <param name="tierList"> rang du Personnage dans la TierList </param>
    /// <param name="eloignement"> Eloignement par défaut du Personnage </param>
    /// <param name="visee"> Visée par défaut du Personnage </param>

    public Personnage(string nom, int vie, int vieMax, string descriptionPouvoir, bool sexe, string nationalite, char tierList, int eloignement, int visee)
    {
        this.nom = nom;

        this.vie = vie;
        this.vieMax = vieMax;

        this.descriptionPouvoir = descriptionPouvoir;

        this.sexe = sexe;
        this.nationalite = nationalite;
        this.tierList = tierList;

        this.eloignement = eloignement;
        this.visee = visee;
    }




    /// <summary> Retourne le nom du Personnage </summary>
    /// <returns> le nom du Personnage </returns>
    public string GetNom() { return nom; }

    /// <summary> Change le nom du Personnage </summary>
    /// <param name="nom"> nouveau nom du Personnage </param>
    public void SetNom(string nom) { this.nom = nom; }




    /// <summary> Retourne la vie du Personnage </summary>
    /// <returns> la vie du Personnage </returns>
    public int GetVie() { return vie; }
    
    /// <summary> Change les Points de vie du Personnage </summary>
    /// <param name="soin"> Point(s) de vie ajouté(s) au Personnage </param>
    public void SetVie(int soin)
    {
        if (vie + soin > GetVieMax())
            vie = vieMax;
        else
            vie += soin;
    }




    /// <summary> Retourne la vie Maximale du Personnage </summary>
    /// <returns> la vie Maximale du Personnage </returns>
    public int GetVieMax() { return vieMax; }
    
    /// <summary> Change le vie Maximale du Personnage </summary>
    /// <param name="vieMax"> nouvelle vie Maximale du personnage </param>
    public void SetVieMax(int vieMax) { this.vieMax = vieMax; }




    /// <summary> Retourne la description du pouvoir du Personnage </summary>
    /// <returns> la description du pouvoir du Personnage </returns>
    public string GetDescriptionPouvoir() { return descriptionPouvoir; }

    /// <summary> Change la description du Pouvoir du Personnage </summary>
    /// <param name="descriptionPouvoir"> nouvelle description du Pouvoir du personnage </param>
    public void SetDescriptionPouvoir(string descriptionPouvoir) { this.descriptionPouvoir = descriptionPouvoir; }




    /// <summary> Retourne le sexe du Personnage </summary>
    /// <returns> le sexe du Personnage </returns>
    public bool GetSexe() { return sexe; }


    /// <summary> Change le sexe du Personnage </summary>
    /// <param name="sexe"> nouveau sexe du personnage </param>
    public void SetSexe(bool sexe) { this.sexe = sexe; }




    /// <summary> Retourne la nationalité du Personnage </summary>
    /// <returns> la nationalité du Personnage </returns>
    public string GetNationalite() { return nationalite; }

    /// <summary> Change la nationalité du Personnage </summary>
    /// <param name="nationalite"> nouvelle nationalité du personnage </param>
    public void Setnationalite(string nationalite) { this.nationalite = nationalite; }




    /// <summary> Retourne le rang du Personnage dans la TierList </summary>
    /// <returns> le rang du Personnage dans la TierList </returns>
    public char GetTierList() { return tierList; }

    /// <summary> Change le rang du Personnage dans la TierList </summary>
    /// <param name="sexe"> le nouveau rang du Personnage dans la TierList </param>
    public void SetTierList(char tierList) { this.tierList = tierList; }




    /// <summary> Retourne l'éloignement du Personnage </summary>
    /// <returns> l'éloignement du Personnage </returns>
    public int GetEloignement() { return eloignement; }

    /// <summary> Change l'éloignement du Personnage </summary>
    /// <param name="eloignement"> le nouvel éloignement du Personnage </param>
    public void SetEloignement(int eloignement) { this.eloignement = eloignement; }




    /// <summary> Retourne la visée du Personnage </summary>
    /// <returns> La visée du Personnage </returns>
    public int GetVisee() { return visee; }

    /// <summary> Change la visée du Personnage </summary>
    /// <param name="visee"> La nouvelle visée du Personnage </param>
    public void SetVisee(int visee) { this.visee = visee; }




    /// <summary>
    /// Affiche une représentation textuelle de l'instance dans la console
    /// </summary>
    public void GetInfo()
    {
        Debug.Log("Nom : " + GetNom() );
        Debug.Log("Vie : " + GetVie() + " / " + GetVieMax() );
        Debug.Log("Pouvoir : " + GetDescriptionPouvoir() );
        Debug.Log("Sexe : " + GetSexe() );
        Debug.Log("Nationalité : " + GetNationalite() );
        Debug.Log("Tierlist : " + GetTierList());
        Debug.Log("Eloignement : " + GetEloignement());
        Debug.Log("Visée : " + GetVisee());
    }




    /// <summary>
    /// Je tire !
    /// </summary>
    public void Bang(Joueur joueur)
    {
        Debug.Log("Je tire sur " + joueur.GetPseudonyme() + " !");
    }



    /// <summary>
    /// T'as raté !
    /// </summary>
    public void Rate()
    {
        Debug.Log("tir raté !");
    }


    /// <summary>
    /// Je bois !
    /// </summary>
    public void Boisson(int pv)
    {
        Debug.Log("Je gagne " + pv + " pv !");
        SetVie(pv);
    }
}
