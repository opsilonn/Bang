using System.Collections.Generic;

public class Role_Renegat : Role
{
    public Role_Renegat(): base("Rénégat", "Soyez le dernier en vie !")
    { }


    /// <summary>
    /// Retourne True si le Rôle a gagné la partie, sinon False.
    /// Le Rénégat gagne s'il est le dernier joueur en vie.
    /// </summary>
    /// <param name="joueurs"> Liste des joueurs </param>
    /// <param name="soiMeme"> Le joueur </param>
    /// <returns> True si le Rôle a gagné la partie, sinon False </returns>
    public override bool ConditionsVictoire(List<Joueur> joueurs, Joueur soiMeme)
    {
        // on vérifie si le rénégat est encore en vie
        if (!soiMeme.EstVivant())
            return false;

        foreach (Joueur joueur in joueurs)
        {
            bool autreQueSoiMeme = !joueur.Equals(soiMeme);
            bool estVivant = joueur.EstVivant();

            if (autreQueSoiMeme && estVivant)
                return false;
        }
        return true;
    }
}