using System.Collections.Generic;
using UnityEngine;

public class Role_HorsLaLoi : Role
{
    public Role_HorsLaLoi(): base("Hors-la-Loi", "Tuez le Shérif ! Ou d'autres, histoire d'avoir leurs récompenses...")
    { }


    /// <summary>
    /// Retourne True si le Rôle a gagné la partie, sinon False.
    /// Le(s) Hors-La-Loi gagne(nt) lorsque le Shérif meure (et que le(s) Rénégat(s) ne gagne(nt) pas avant eux)
    /// </summary>
    /// <param name="joueurs"> Liste des joueurs </param>
    /// <param name="soiMeme"> Le joueur </param>
    /// <returns> True si le Rôle a gagné la partie, sinon False </returns>
    public override bool ConditionsVictoire(List<Joueur> joueurs, Joueur soiMeme)
    {
        // On regarde si le Shérif est mort
        bool sherifMort = false;

        foreach (Joueur joueur in joueurs)
        {
            bool estLeSherif = joueur.role.GetType() == new Role_Sherif().GetType();
            bool estMort = !joueur.EstVivant();
            sherifMort = estLeSherif && estMort;

            if (sherifMort)
                break;
        }


        // S'il est mort, on vérifie si les Hors-La-Loi gagnent (= au moins un Hors-La-Loi en vie)
        if (sherifMort)
        {
            foreach (Joueur joueur in joueurs)
            {
                if (joueur.role.GetType() == new Role_HorsLaLoi().GetType() && joueur.EstVivant())
                    return true;
            }
        }

        return false;
    }
}