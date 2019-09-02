using System;
using System.Linq;
using System.Reflection;


public static class CreateInstance
{
    /// <summary>
    /// Crée une instance d'un objet d'après le nom de sa classe
    /// </summary>
    /// <param name="className"> nom de la classe à instancier </param>
    /// <returns> Une instance de la classe </returns>

    public static object MagicallyCreateInstance(string className)
    {
        var assembly = Assembly.GetExecutingAssembly();

        var type = assembly.GetTypes().First(t => t.Name == className);

        return Activator.CreateInstance(type);
    }
}
