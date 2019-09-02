using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GestionAnimation
{
    /** Lance une animation. */
    public static void LancerAnimation(Animator animator, string nomAnimation)
    {
        animator.SetTrigger( nomAnimation );
    }
}
