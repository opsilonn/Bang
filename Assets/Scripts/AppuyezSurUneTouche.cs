using UnityEngine;


public class AppuyezSurUneTouche : MonoBehaviour
{
    public GameObject toClose;
    public GameObject toOpen;


    /// <summary>
    /// Change le sexe du Personnage
    /// </summary>
    void Update()
    {
        if (Input.anyKey)
        {
            toOpen.SetActive(true);
            toClose.SetActive(false);
        }
    }
}