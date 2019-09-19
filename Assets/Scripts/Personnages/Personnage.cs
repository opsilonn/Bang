using System.Collections.Generic;
using UnityEngine;


public class Personnage
{
    private string _nom;
    private int _vieMax;
    private int _vie;
    private string _descriptionPouvoir;
    private bool _sexe;
    private string _nationalite;
    private char _tierList;
    private int _eloignement;
    private int _visee;

    private static readonly string NOM_PAR_DEFAUT = "John Doe";
    private static readonly int    VIE_MAX_PAR_DEFAUT = 4;
    private static readonly int    VIE_PAR_DEFAUT = 4;
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
        vieMax = VIE_MAX_PAR_DEFAUT;
        vie = VIE_PAR_DEFAUT;
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
        this._nom = nom;
        this._vieMax = vieMax;
        this._vie = vie;
        this._descriptionPouvoir = descriptionPouvoir;
        this._sexe = sexe;
        this._nationalite = nationalite;
        this._tierList = tierList;
        this._eloignement = eloignement;
        this._visee = visee;
    }


    

    /// <summary>
    /// Affiche une représentation textuelle de l'instance dans la console
    /// </summary>
    public void GetInfo()
    {
        Debug.Log("Nom : " + nom );
        Debug.Log("Vie : " + vie + " / " + vieMax );
        Debug.Log("Pouvoir : " + descriptionPouvoir );
        Debug.Log("Sexe : " + sexe );
        Debug.Log("Nationalité : " + nationalite );
        Debug.Log("Tierlist : " + tierList);
        Debug.Log("Eloignement : " + eloignement);
        Debug.Log("Visée : " + visee);
    }


    /// <summary>
    /// Modifie la vie du personnage en gardant sa valeur entre 0 et celle de _vieMax
    /// </summary>
    /// <param name="soin"> Nombre de Points de vie gagnés ou perdus </param>
    public void ModifierVie(int soin)
    {
        if (vie + soin > vieMax)
            vie = vieMax;

        else if (vie + soin <= 0)
            vie = 0;

        else
            vie += soin;
    }




    /// <summary>
    /// Je tire !
    /// </summary>
    public void Bang(Joueur soi, Joueur joueurvise)
    {
        Debug.Log("Je tire sur " + joueurvise.pseudonyme + " !");
        joueurvise.personnage.SubirTir(soi);
    }


    /// <summary>
    /// Je tire !
    /// </summary>
    public void SubirTir(Joueur joueur)
    {
        Debug.Log(joueur.pseudonyme + " me tire dessus !");
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
        ModifierVie(pv);
    }




    /// <summary>
    /// Je pioche !
    /// </summary>
    public List<Carte> Pioche(int nombreCarte)
    {
        Debug.Log("Je pioche " + nombreCarte + " carte !");

        List<Carte> cartesARetourner = new List<Carte>();
        for (int i = 0; i < nombreCarte; i++)
            cartesARetourner.Add(new Carte_Arme());

        return cartesARetourner;
    }






    // PARAMETRES

    public string nom
    {
        get { return _nom; }
        set { _nom = value; }
    }

    public int vie
    {
        get { return _vie; }
        set
        {
            if (value < 0)
                _vie = 0;
            else if (value > vieMax)
                _vie = vie;
            else
                _vie = value;
        }
    }

    public int vieMax
    {
        get { return _vieMax; }
        set
        {
            if (value < 0)
                _vieMax = 0;
            else
                _vieMax = value;
        }
    }

    public string descriptionPouvoir
    {
        get { return _descriptionPouvoir; }
        set { _descriptionPouvoir = value; }
    }

    public bool sexe
    {
        get { return _sexe; }
        set { _sexe = value; }
    }

    public string nationalite
    {
        get { return _nationalite; }
        set { _nationalite = value; }
    }

    public char tierList
    {
        get { return _tierList; }
        set { _tierList = value; }
    }

    public int eloignement
    {
        get { return _eloignement; }
        set { _eloignement = value; }
    }

    public int visee
    {
        get { return _visee; }
        set { _visee = value; }
    }
}