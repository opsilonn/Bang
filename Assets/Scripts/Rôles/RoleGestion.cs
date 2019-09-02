using System.Collections.Generic;
using UnityEngine;

public class RoleGestion : MonoBehaviour
{
    /// <summary>
    /// Affiche les différents Rôles dans la console
    /// </summary>
    public static void AfficherRoles()
    {
        List<Role> roles = new List<Role>();
        var types = System.AppDomain.CurrentDomain.GetAllDerivedTypes(typeof(Role));


        foreach (System.Type type in types)
            roles.Add((Role)CreateInstance.MagicallyCreateInstance(type.ToString()));


        foreach (Role role in roles)
            Debug.Log(role.getTitre());
    }




    /// <summary>
    /// Retourne une liste des différents Rôles
    /// </summary>
    /// <returns>
    /// Une liste des différents Rôles
    /// </returns>
    public static List<Role> RetournerRole()
    {
        List<Role> roles = new List<Role>();
        var types = System.AppDomain.CurrentDomain.GetAllDerivedTypes(typeof(Role));


        foreach (System.Type type in types)
            roles.Add((Role)CreateInstance.MagicallyCreateInstance(type.ToString()));


        return roles;
    }



    /// <summary>
    /// Retourne une liste contenant les titres des différents Rôles
    /// </summary>
    /// <returns>
    /// Une liste contenant les titres des différents Rôles
    /// </returns>
    public static List<string> RetournerRole_String()
    {
        List<Role> roles = new List<Role>();
        List<string> roles_string = new List<string>();
        var types = System.AppDomain.CurrentDomain.GetAllDerivedTypes(typeof(Role));


        foreach (System.Type type in types)
            roles.Add((Role)CreateInstance.MagicallyCreateInstance(type.ToString()));


        foreach (Role role in roles)
            roles_string.Add(role.getTitre());


        return roles_string;
    }
}
