using UnityEngine;
using UnityEngine.SceneManagement;


public class GestionScene : MonoBehaviour
{
    /// <summary>
    /// Lance une scène
    /// </summary>
    /// <param name="scene"> Nom de la scène à lancer </param>
    public void LancerScene(string scene)
    {
        SceneManager.LoadScene( scene );
    }


    /// <summary>
    /// Ferme le programme
    /// </summary>
    public void QuitterJeu()
    {
        Application.Quit();
    }
}
