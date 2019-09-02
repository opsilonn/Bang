using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    public string nomScene;
    public string nomAnimation;


    /// <summary>
    /// Cette fonction active l'animation.
    /// </summary>
    public void Call_Fade_Out()
    {
        GestionAnimation.LancerAnimation(animator, nomAnimation);
    }


    /// <summary>
    /// Cette fonction est activée à la fin d'une animation.
    /// Une fois activée, elle lance la prochaine scène.
    /// </summary>
    public void OnFadeComplete()
    {
        SceneManager.LoadScene( nomScene );
    }


    /// <summary>
    /// A SUPPRIMER
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            Call_Fade_Out();
    }
}