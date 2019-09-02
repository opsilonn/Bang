using System;
using System.Collections.Generic;
using UnityEngine;


public partial class Joueur
{  
    private Guid ID;
    private string pseudonyme;

    private Personnage personnage;
    private Role role;

    private List<Carte> main;
    private List<Carte> effetsSubis;
    private Carte_Arme arme;
    private Carte_Equipement equipement;

    private static readonly string NOM_PAR_DEFAUT = "John Doe";



    /// <summary>
    /// Constructeur par défaut de la classe Joueur
    /// </summary>
    public Joueur()
    {
        ID = Guid.NewGuid();
        pseudonyme = NOM_PAR_DEFAUT;

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
        ID = Guid.NewGuid();
        this.pseudonyme = pseudonyme;

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
        ID = Guid.NewGuid();
        this.pseudonyme = pseudonyme;

        this.personnage = personnage;
        this.role = role;

        main = new List<Carte>();
        effetsSubis = new List<Carte>();
        arme = null;
        equipement = null;
    }




    /// <summary> Retourne l'ID du Joueur </summary>
    /// <returns> L'ID du Joueur </returns>
    public Guid GetID() { return ID; }

    /// <summary> Change l'ID du Joueur </summary>
    /// <param name="nom"> Nouvel ID du Joueur </param>
    public void SetID(Guid ID) { this.ID = ID; }




    /// <summary> Retourne le pseudonyme du Joueur </summary>
    /// <returns> Le pseudonyme du Joueur </returns>
    public string GetPseudonyme() { return pseudonyme; } 
    
    /// <summary> Change le pseudonyme du Joueur </summary>
    /// <param name="pseudonyme"> Nouveau pseudonyme du Joueur </param>
    public void SetPseudonyme(string pseudonyme) { this.pseudonyme = pseudonyme; }




    /// <summary> Retourne le Personnage incarné par le Joueur </summary>
    /// <returns> Le Personnage incarné par le Joueur </returns>
    public Personnage GetPersonnage() { return personnage; }

    /// <summary> Change le personnage incarné par le Joueur </summary>
    /// <param name="personnage"> Nouveau personnage incarné par le Joueur </param>
    public void SetPersonnage(Personnage personnage) { this.personnage = personnage; }




    /// <summary> Retourne le Rôle du Joueur </summary>
    /// <returns> Le Rôle du Joueur </returns>
    public Role GetRole() { return role; }

    /// <summary> Change le Rôle du Joueur </summary>
    /// <param name="role"> Nouveau Rôle du Joueur </param>
    public void SetRole(Role role) { this.role = role; }




    /// <summary> Retourne la main du Joueur </summary>
    /// <returns> La main du Joueur </returns>
    public List<Carte> GetMain() { return main; }

    /// <summary> Change la main du Joueur </summary>
    /// <param name="main"> Nouvelle main du Joueur </param>
    public void SetRole(List<Carte> main) { this.main = main; }




    /// <summary> Retourne les Effets Subis par le Joueur </summary>
    /// <returns> Les Effets Subis du Joueur </returns>
    public List<Carte> GetEffetsSubis() { return effetsSubis; }

    /// <summary> Change les Effets Subis du Joueur </summary>
    /// <param name="effetsSubis"> Nouveaux Effets Subis du Joueur </param>
    public void SetEffetsSubis(List<Carte> effetsSubis) { this.effetsSubis = effetsSubis; }




    /// <summary> Retourne l'arme du Joueur </summary>
    /// <returns> L'arme du Joueur </returns>
    public Carte_Arme GetArme() { return arme; }

    /// <summary> Change l'arme du Joueur </summary>
    /// <param name="arme"> Nouvelle arme du Joueur </param>
    public void SetArme(Carte_Arme arme) { this.arme = arme; }




    /// <summary> Retourne l'équipement du Joueur </summary>
    /// <returns> L'équipement du Joueur </returns>
    public Carte_Equipement GetEquipement() { return equipement; }

    /// <summary> Change l'équipement du Joueur </summary>
    /// <param name="equipement"> Nouvel équipement du Joueur </param>
    public void SetEquipement(Carte_Equipement equipement) { this.equipement = equipement; }




    /// <summary> Retourne si le Joueur est en vie </summary>
    /// <returns> True si le Joueur est en vie, sinon False </returns>
    public bool EstVivant()
    {
        return GetPersonnage().GetVie() > 0 ;
    }




    /// <summary> 
    /// Représentation textuelle de l'instance dans la console
    /// </summary>
    public void GetInfo()
    {
        Debug.Log("<b>Joueur " + GetPseudonyme() + "</b>");


        if ( personnage == null )
            Debug.Log("Personnage : vide");
        else
            personnage.GetInfo();


        Debug.Log("~ ~ ~ ~ ~");


        if ( role == null )
            Debug.Log("Rôle : vide");
        else
            role.getInfo();


        Debug.Log("");
    }




    /// <summary> Retourne True si la main du joueur contient une carte de la classe cherchée, sinon False </summary>
    /// <param name="classe"> Classe de Carte recherchée </param>
    /// <returns> True si la main du joueur contient une carte de la classe cherchée, sinon False </returns>
    public bool MainContientClasses(Type classe)
    {
        foreach (Carte carte in GetMain())
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

        foreach (Carte carte in GetMain())
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

        foreach (Carte carte in GetMain())
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
        
        foreach ( Carte carte in GetMain() )
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
}