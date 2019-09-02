using System.Collections.Generic;
using UnityEngine;


public static class PersonnageGestion
{
    /// <summary>
    /// Affiche les différents Personnages dans la console
    /// </summary>
    public static void AfficherPersonnages()
    {
        List<Personnage> personnages = new List<Personnage>();
        var types = System.AppDomain.CurrentDomain.GetAllDerivedTypes(typeof( Personnage ));


        foreach (System.Type type in types)
            personnages.Add( (Personnage)CreateInstance.MagicallyCreateInstance(type.ToString()) );


        foreach (Personnage personnage in personnages)
            Debug.Log( personnage.GetNom() );
    }



    /// <summary>
    /// Retourne une liste des différents Personnages
    /// </summary>
    /// <returns>
    /// Une liste des différents Personnages
    /// </returns>
    public static List<Personnage> RetournerPersonnages()
    {
        List<Personnage> personnages = new List<Personnage>();
        var types = System.AppDomain.CurrentDomain.GetAllDerivedTypes(typeof(Personnage));


        foreach (System.Type type in types)
            personnages.Add((Personnage)CreateInstance.MagicallyCreateInstance(type.ToString()));


        return personnages;
    }



    /// <summary>
    /// Retourne une liste contenant les titres des différents Personnages
    /// </summary>
    /// <returns>
    /// Une liste contenant les titres des différents Personnages
    /// </returns>
    public static List<string> RetournerPersonnages_String()
    {
        List<Personnage> personnages = new List<Personnage>();
        List<string> personnages_string = new List<string>();
        var types = System.AppDomain.CurrentDomain.GetAllDerivedTypes(typeof(Personnage));


        foreach (System.Type type in types)
            personnages.Add((Personnage)CreateInstance.MagicallyCreateInstance(type.ToString()));


        foreach (Personnage personnage in personnages)
            personnages_string.Add( personnage.GetNom() );


        return personnages_string;
    }
}