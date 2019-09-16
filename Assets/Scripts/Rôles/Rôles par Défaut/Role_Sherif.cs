using System.Collections.Generic;

public class Role_Sherif : Role
{
    public Role_Sherif(): base("Shérif", "Eliminez les Hors-la-Loi et les Rénégats !")
    { }


    /// <summary>
    /// Retourne True si le Rôle a gagné la partie, sinon False.
    /// Le Shérif gagne si tous les "Méchants" sont morts.
    /// </summary>
    /// <param name="joueurs"> Liste des joueurs </param>
    /// <param name="soiMeme"> Le joueur </param>
    /// <returns> True si le Rôle a gagné la partie, sinon False </returns>
    public override bool ConditionsVictoire(List<Joueur> joueurs, Joueur soiMeme)
    {
        // On regarde s'il existe au moins un joueur "méchant" en vie
        foreach(Joueur joueur in joueurs)
        {
            bool estMechant = joueur.role.GetType() == new Role_Renegat().GetType() || joueur.role.GetType() == new Role_HorsLaLoi().GetType();
            bool estVivant = joueur.EstVivant();
            if (estMechant && estVivant)
                return false;
        }

        return true;
    }
}