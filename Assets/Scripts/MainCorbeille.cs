using UnityEngine;


public class MainCorbeille : MonoBehaviour
{
    public Partie partie;

    public TMPro.TMP_Dropdown dropdownPersonnages;
    public TMPro.TMP_Dropdown dropdownRoles;
    public Joueur joueurActif;
    public TMPro.TextMeshProUGUI text;

    private readonly string J1 = "Opsilonn";
    private readonly string J2 = "Khorlaedril";
    private readonly string J3 = "Bochi1505";


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


        joueurActif = partie.TrouverJoueur(J1);

        partie.TrouverJoueur(J2).main.Add(new Carte_Effet_Bang());
        partie.TrouverJoueur(J2).main.Add(new Carte_Arme());

        partie.TrouverJoueur(J1).personnage.ModifierVie(-4);
        partie.TrouverJoueur(J3).personnage.ModifierVie(-4);

        SetText();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if( partie.TrouverJoueur(J2).MainContientEffetRate() )
                partie.TrouverJoueur(J2).Rate();
            else
                joueurActif.personnage.Bang(partie.TrouverJoueur(J2));
        }

        if (Input.GetKeyDown(KeyCode.Z))
            joueurActif.Rate();

        if (Input.GetKeyDown(KeyCode.E))
            joueurActif.Boisson(2);

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("on ajoute une carte Raté");
            partie.TrouverJoueur(J2).main.Add(new Carte_Effet_Rate());
            SetText();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("On vide la main");
            partie.TrouverJoueur(J2).main.Clear();
            SetText();
        }

        if (Input.GetKeyDown(KeyCode.Y))
            partie.TrouverJoueur(J2).AfficherMain();

        if (Input.GetKeyDown(KeyCode.U))
            partie.TrouverJoueur(J2).personnage.ModifierVie(-1);

        if (Input.GetKeyDown(KeyCode.I))
            partie.VerifierConditionsVictoire();
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