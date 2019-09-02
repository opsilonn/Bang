using System.Collections.Generic;

public static class ReflectionHelpers
{
    /// <summary>
    /// Retourne toutes classes qui héritent d'une classe spécifiée en paramètre
    /// </summary>
    /// <param name="aType"> Type de la classe dont on cherche tous les classe qui en héritent </param>
    public static System.Type[] GetAllDerivedTypes(this System.AppDomain aAppDomain, System.Type aType)
    {
        var result = new List<System.Type>();
        var assemblies = aAppDomain.GetAssemblies();
        foreach (var assembly in assemblies)
        {
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.IsSubclassOf(aType))
                    result.Add(type);
            }
        }
        return result.ToArray();
    }
}