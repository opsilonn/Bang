using UnityEngine;
using UnityEngine.UI; 

public class Carte_UI : MonoBehaviour
{
    private Carte carte;
    public TMPro.TextMeshProUGUI textTitre;
    public TMPro.TextMeshProUGUI textDescription;
    public RawImage image;
    public Image bordure;


    // Start is called before the first frame update
    void Start()
    {
        carte = new Carte_Arme();
        textTitre.text = carte.titre;
        textDescription.text = carte.descriptionEffet;
        bordure.color = carte.GetCouleurEffet();
    }
}