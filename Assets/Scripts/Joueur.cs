using System;
using System.Collections.Generic;
using UnityEngine;


public partial class Joueur
{
    private Guid _ID;
    private string _pseudonyme;

    private Personnage _personnage;
    private Role _role;

    private List<Carte> _main;
    private List<Carte> _effetsSubis;
    private Carte_Arme _arme;
    private Carte_Equipement _equipement;
    

    private static readonly string PSEUDONYME_PAR_DEFAUT = "John Doe";


    /// <summary>
    /// Constructeur par défaut de la classe Joueur
    /// </summary>
    public Joueur()
    {
        ID = Guid.NewGuid();
        pseudonyme = PSEUDONYME_PAR_DEFAUT;

        personnage = null;
        role = null;

        main = new List<Carte>();
        effetsSubis = new List<Carte>();
        arme = new Carte_Arme();
        equipement = null;
    }




    /// <summary>
    /// Constructeur avancé de la classe Joueur
    /// </summary>
    /// <param name="pseudonyme"> Pseudonyme du Joueur </param>
    public Joueur(string pseudonyme)
    {
        _ID = Guid.NewGuid();
        this._pseudonyme = pseudonyme;

        personnage = null;
        role = null;

        main = new List<Carte>();
        effetsSubis = new List<Carte>();
        arme = null;
        equipement = null;
    }




    /// <summary>
    /// Constructeur complet de la classe Joueur
    /// </summary>
    /// <param name="pseudonyme"> Pseudonyme du Joueur </param>
    /// <param name="personnage"> Personnage incarné par le Joueur </param>
    /// <param name="role"> Role du Joueur </param>
    public Joueur(string pseudonyme, Personnage personnage, Role role)
    {
        _ID = Guid.NewGuid();
        this._pseudonyme = pseudonyme;

        this.personnage = personnage;
        this.role = role;

        main = new List<Carte>();
        effetsSubis = new List<Carte>();
        arme = null;
        equipement = null;
    }





    /// <summary>
    /// Retourne le Rôle du Joueur pour l'interface.
    /// S'il s'agit du Shérif, ou si le joueur est mort, on affiche son rôle.
    /// Sinon, on affiche "???" pour le maintenir caché.
    /// </summary>
    /// <returns> Le Rôle du Joueur pour l'interface </returns>
    public string GetRoleUI()
    {
        string titre = role.titre;

        if(titre == "Shérif" || !EstVivant())
            return titre;

        return "???";
    }




    /// <summary> 
    /// Représentation textuelle de l'instance dans la console
    /// </summary>
    public void GetInfo()
    {
        Debug.Log("<b>Joueur " + pseudonyme + "</b>");


        if ( personnage == null )
            Debug.Log("Personnage : vide");
        else
            personnage.GetInfo();


        Debug.Log("~ ~ ~ ~ ~");


        if ( role == null )
            Debug.Log("Rôle : vide");
        else
            role.GetInfo();


        Debug.Log("");
    }
    



    /// <summary> Affiche les cartes de la main </summary>
    public void AfficherMain()
    {
        Debug.Log("<b>Main du Joueur " + pseudonyme + "</b>");

        foreach (Carte carte in main)
            carte.GetInfo();

        Debug.Log("");
    }




    /// <summary> Retourne si le Joueur est en vie </summary>
    /// <returns> True si le Joueur est en vie, sinon False </returns>
    public bool EstVivant()
    {
        return personnage.vie > 0;
    }




    /// <summary> Lance la fonction Bang du personnage </summary>
    /// <param name="joueurvise"> Joueur visé par le Bang </param>
    public void Bang(Joueur joueurvise)
    {
        personnage.Bang(this, joueurvise);
    }


    /// <summary> Lance la fonction Boisson du personnage </summary>
    /// <param name="pv"> Nombre de pv récupéré(s) </param>
    public void Boisson(int pv)
    {
        personnage.Boisson(pv);
    }


    /// <summary> Lance la fonction Raté du personnage </summary>
    public void Rate()
    {
        personnage.Rate();
    }


    /// <summary> Lance la fonction Pioche du personnage </summary>
    public void Pioche(int nombreCarte)
    {
        List<Carte> cartesAAjouter = personnage.Pioche(nombreCarte);
        foreach(Carte carte in cartesAAjouter)
            main.Add( carte );
    }


    /// <summary> Retourne True si la main du joueur contient une carte de la classe cherchée, sinon False </summary>
    /// <param name="classe"> Classe de Carte recherchée </param>
    /// <returns> True si la main du joueur contient une carte de la classe cherchée, sinon False </returns>
    public bool MainContientClasses(Type classe)
    {
        foreach (Carte carte in main)
        {
            if (carte.GetType() == classe)
                return true;
        }
        return false;
    }




    /// <summary> Retourne True si la main du joueur contient une carte avec un effet Bang, sinon False </summary>
    /// <returns> True si la main du joueur contient une carte avec un effet Bang, sinon False </returns>
    public bool MainContientEffetBang()
    {
        foreach (Carte carte in main)
        {
            if (carte.GetType().IsSubclassOf(typeof(Carte_Effet)))
            {
                Carte_Effet carteEffet = (Carte_Effet)carte;
                if (carteEffet.GetEffetBang())
                    return true;
            }
        }

        return false;
    }


    /// <summary> Retourne True si la main du joueur contient une carte avec un effet Boisson, sinon False </summary>
    /// <returns> True si la main du joueur contient une carte avec un effet Boisson, sinon False </returns>
    public bool MainContientEffetBoisson()
    {

        foreach (Carte carte in main)
        {
            if (carte.GetType().IsSubclassOf(typeof(Carte_Effet)))
            {
                Carte_Effet carteEffet = (Carte_Effet)carte;
                if (carteEffet.GetEffetBoisson())
                    return true;
            }
        }

        return false;
    }


    /// <summary> Retourne True si la main du joueur contient une carte avec un effet Raté, sinon False </summary>
    /// <returns> True si la main du joueur contient une carte avec un effet Raté, sinon False </returns>
    public bool MainContientEffetRate()
    {
        
        foreach ( Carte carte in main )
        {
            if ( carte.GetType().IsSubclassOf(typeof(Carte_Effet)) )
            {
                Carte_Effet carteEffet = (Carte_Effet)carte;
                if ( carteEffet.GetEffetRate() )
                    return true;
            }
        }
        
        return false;
    }








    // PARAMETRES

    public Guid ID
    {
        get { return _ID; }
        set { _ID = value; }
    }

    public string pseudonyme
    {
        get { return _pseudonyme; }
        set { _pseudonyme = value; }
    }

    public Personnage personnage

    {
        get { return _personnage; }
        set { _personnage = value; }
    }

    public Role role
    {
        get { return _role; }
        set { _role = value; }
    }

    public List<Carte> main
    {
        get { return _main; }
        set { _main = value; }
    }

    public List<Carte> effetsSubis
    {
        get { return _effetsSubis; }
        set { _effetsSubis = value; }
    }

    public Carte_Arme arme
    {
        get { return _arme; }
        set { _arme = value; }
    }

    public Carte_Equipement equipement
    {
        get { return _equipement; }
        set { _equipement = value; }
    }
}