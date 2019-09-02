using UnityEngine;

public class GestionPause : MonoBehaviour
{
    public GameObject panelPause;
    public static bool enPause = false;

    /// <summary>
    /// Pause le jeu
    /// </summary>
    public void pauseActiver()
    {
        panelPause.SetActive(true);
    }


    /// <summary>
    /// Quitte le menu Pause
    /// </summary>
    public void pauseDesactiver()
    {
        panelPause.SetActive(false);
    }


    /// <summary>
    /// S'assure que le menu Pause soit fermé en lançant le jeu
    /// </summary>
    private void Start()
    {
        panelPause.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (enPause)
                pauseDesactiver();
            else
                pauseActiver();

            enPause = !enPause;
        }
    }
}