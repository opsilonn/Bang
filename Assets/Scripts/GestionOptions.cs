using UnityEngine;

public class GestionOptions : MonoBehaviour
{
    public GameObject panelOption;
    public static bool enOptions = false;

    /// <summary>
    /// Change le volume sonore du jeu
    /// </summary>
    /// <param name="volume"> nouveau volume sonore du jeu </param>
    public void setVolume(float volume)
    {
        Debug.Log(volume);
    }




    /// <summary>
    /// Active le menu des options
    /// </summary>
    public void optionActiver()
    {
        panelOption.SetActive(true);
    }


    /// <summary>
    /// Désactive le menu des options
    /// </summary>
    public void optionDesactiver()
    {
        panelOption.SetActive(false);
    }




    /// <summary>
    /// S'assure que le menu des options soit fermé en lançant le jeu
    /// </summary>
    private void Start()
    {
        panelOption.SetActive(false);
    }
}
