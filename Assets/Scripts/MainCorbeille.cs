using UnityEngine;
using UnityEngine.UI;

public class MainCorbeille : MonoBehaviour
{
    Partie partie;
    public TMPro.TMP_Dropdown dropdownPersonnages;
    public TMPro.TMP_Dropdown dropdownRoles;
    public Joueur joueurActif;

    /// <summary>
    /// Fait des trucs (A SUPPRIMER)
    /// </summary>
    void Start()
    {
        // Dropdown Personnage
        dropdownPersonnages.options.Clear();
        dropdownPersonnages.AddOptions( PersonnageGestion.RetournerPersonnages_String() );
        if(dropdownPersonnages.options.Count == 0)
            dropdownPersonnages.captionText.text = "Aucun Personnage disponible !";


        // Dropdown Rôle
        dropdownRoles.options.Clear();
        dropdownRoles.AddOptions( RoleGestion.RetournerRole_String() );
        if (dropdownRoles.options.Count == 0)
            dropdownRoles.captionText.text = "Aucun Rôle disponible !";


        // Test Partie
        partie = new Partie();
        partie.joueurs.Add(new Joueur("J1", new Personnage_BartCassidy(), new Role_Sherif()));
        partie.joueurs.Add(new Joueur("J2", new Personnage_BlackJack(), new Role_Renegat()));
        partie.joueurs.Add(new Joueur("J3", new Personnage_BlackJack(), new Role_HorsLaLoi()));

        joueurActif = partie.TrouverJoueur("J1");

        foreach (Carte c in partie.TrouverJoueur("J2").GetMain())
            c.GetInfo();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if(partie.TrouverJoueur("J2").MainContientClasses(typeof(Carte_Effet_Rate) ))
                partie.TrouverJoueur("J2").GetPersonnage().Rate();
            else
                joueurActif.GetPersonnage().Bang(partie.TrouverJoueur("J2"));

        }

        if (Input.GetKeyDown(KeyCode.Q))
            joueurActif.GetPersonnage().Bang(partie.TrouverJoueur("J3"));

        if (Input.GetKeyDown(KeyCode.Z))
            joueurActif.GetPersonnage().Rate();

        if (Input.GetKeyDown(KeyCode.E))
            joueurActif.GetPersonnage().Boisson(2);


        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("on ajoute une carte Raté");
            partie.TrouverJoueur("J2").GetMain().Add(new Carte_Effet_Rate());
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("on retire une carte Raté");
            partie.TrouverJoueur("J2").GetMain().Clear();
        }
    }
}