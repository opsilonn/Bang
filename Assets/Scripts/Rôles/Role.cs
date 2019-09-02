using UnityEngine;


public abstract class Role
{  
    private string titre;
    private string but;

    /// <summary>
    /// Constructeur complet de la classe Role
    /// </summary>
    /// <param name="role"> Rôle (titre) du Rôle </param>
    /// <param name="but"> But (description de son objectif) du Rôle </param>
    public Role(string role, string but)
    {
        this.titre = role;
        this.but = but;
    }



    /// <summary> Retourne le titre du Rôle </summary>
    /// <returns> le titre du Rôle </returns>
    public string getTitre() { return titre; }

    /// <summary> Change le titre du Rôle </summary>
    /// <param name="titre"> le nouveau titre du Rôle </param>
    public void setTitre(string titre) { this.titre = titre; }


    /// <summary> Retourne le but du Rôle </summary>
    /// <returns> le but du Rôle </returns>
    public string getBut() { return but; }
    
    /// <summary> Change le but du Rôle </summary>
    /// <param name="but"> le nouveau but du Rôle </param>
    public void setBut(string but) { this.but = but; }




    /// <summary>
    /// Affiche une représentation textuelle de l'instance dans la console
    /// </summary>
    public void getInfo()
    { 
       Debug.Log("Titre : " + getTitre() );
       Debug.Log("But : " + getBut() );
    }

    /// <summary>
    /// Vérifie si les conditions de Victoire sont remplies
    /// </summary>
    /// <returns> True si les conditions sont remplies, sinon False </returns>
    public abstract bool conditionsVictoire();
}