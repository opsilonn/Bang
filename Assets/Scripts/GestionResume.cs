using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GestionResume : MonoBehaviour
{
    private bool resume;
    public MainCorbeille mainCorbeille;


    public Transform container;
    public Transform template;
    private float templateHeight = -50f;

    private static readonly string TEXTE_PSEUDONYME = "Valeur_Pseudonyme";
    private static readonly string TEXTE_ROLE       = "Valeur_Rôle";
    private static readonly string TEXTE_PERSONNAGE = "Valeur_Personnage";
    private static readonly string TEXTE_VIE        = "Valeur_PV";
    private static readonly string TEXTE_CARTES     = "Valeur_Cartes";

    private List<Transform> transforms;


    private void Awake()
    {
        resume = false;
        container.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            resume = !resume;
            container.gameObject.SetActive(resume);

            if (resume)
                CreerTable();
            else
                EffacerTable();
            template.gameObject.SetActive(!resume);
        }
    }




    private void CreerTable()
    {
        transforms = new List<Transform>();
        int i = 0;

        foreach (Joueur joueur in mainCorbeille.partie.joueurs)
            CreerTableRang(joueur, i++);
    }


    private void CreerTableRang(Joueur joueur, int rang)
    {
        Transform tableTransform = Instantiate(template, container);
        RectTransform tableRectTransform = tableTransform.GetComponent<RectTransform>();
        tableRectTransform.anchoredPosition = new Vector2(0, templateHeight * rang);

        tableTransform.Find(TEXTE_PSEUDONYME).GetComponent<TMPro.TextMeshProUGUI>().text = joueur.pseudonyme;
        tableTransform.Find(TEXTE_ROLE).GetComponent<TMPro.TextMeshProUGUI>().text = joueur.GetRoleUI();
        tableTransform.Find(TEXTE_PERSONNAGE).GetComponent<TMPro.TextMeshProUGUI>().text = joueur.personnage.nom;
        tableTransform.Find(TEXTE_VIE).GetComponent<TMPro.TextMeshProUGUI>().text = joueur.personnage.vie.ToString() + " / " + joueur.personnage.vieMax.ToString();
        tableTransform.Find(TEXTE_CARTES).GetComponent<TMPro.TextMeshProUGUI>().text = joueur.main.Count.ToString();

        transforms.Add(tableTransform);
    }


    private void EffacerTable()
    {
        foreach (Transform transform in transforms)
            Destroy(transform.gameObject, 0);   
    }
}