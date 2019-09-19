using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCorbeille : MonoBehaviour
{
    public Partie partie;

    public TMPro.TMP_Dropdown dropdownPersonnages;
    public TMPro.TMP_Dropdown dropdownRoles;
    public TMPro.TextMeshProUGUI text;

    private readonly string J1 = "Opsilonn";
    private readonly string J2 = "Khorlaedril";
    private readonly string J3 = "Bochi1505";

    public TMPro.TMP_Dropdown dropdownJoueurActif;
    public TMPro.TMP_Dropdown dropdownJoueurCible;
    public Slider sliderPV;


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
        partie.joueurs.Add(new Joueur(J1, new Personnage_BartCassidy(), new Role_Sherif()));
        partie.joueurs.Add(new Joueur(J2, new Personnage_BlackJack(),   new Role_Renegat()));
        partie.joueurs.Add(new Joueur(J3, new Personnage_BlackJack(),   new Role_HorsLaLoi()));


        partie.TrouverJoueur(J2).main.Add(new Carte_Effet_Bang());
        partie.TrouverJoueur(J2).main.Add(new Carte_Arme());

        SetText();


        // Test Automatisation
        dropdownJoueurActif.options.Clear();
        dropdownJoueurCible.options.Clear();
        dropdownJoueurActif.AddOptions(new List<string>() { J1, J2, J3 });
        dropdownJoueurCible.AddOptions(new List<string>() { J1, J2, J3 });
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            joueurCible.main.Add(new Carte_Effet_Rate());
            SetText();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("On vide la main");
            joueurCible.main.Clear();
            SetText();
        }

        if (Input.GetKeyDown(KeyCode.Y))
            joueurCible.AfficherMain();

        if (Input.GetKeyDown(KeyCode.U))
            joueurCible.personnage.ModifierVie(-1);

        if (Input.GetKeyDown(KeyCode.I))
            partie.VerifierConditionsVictoire();
    }




    public void Bang()
    {
        if (joueurCible.MainContientEffetRate())
            joueurCible.Rate();
        else
            joueurActif.Bang(joueurCible);
    }




    public void Rate()
    {
        joueurActif.Rate();
    }




    public void Boisson()
    {
        joueurActif.Boisson((int)sliderPV.value);
    }




    public Joueur joueurActif
    {
        get
        {
            int i = dropdownJoueurActif.value;

            if (i == 0)
                return partie.TrouverJoueur(J1);
            if (i == 1)
                return partie.TrouverJoueur(J2);
            if (i == 2)
                return partie.TrouverJoueur(J3);

            return null;
        }
    }




    public Joueur joueurCible
    {
        get
        {
            int i = dropdownJoueurCible.value;

            if (i == 0)
                return partie.TrouverJoueur(J1);
            if (i == 1)
                return partie.TrouverJoueur(J2);
            if (i == 2)
                return partie.TrouverJoueur(J3);

            return null;
        }
    }


    /// <summary>
    ///  INUTILE
    /// </summary>
    public void SetText()
    {
        text.SetText("");

        foreach(Carte carte in partie.TrouverJoueur(J2).main)
            text.text += carte.titre + "\n";

        if(text.text.Length == 0)
           text.SetText("Main vide !");
    }
}