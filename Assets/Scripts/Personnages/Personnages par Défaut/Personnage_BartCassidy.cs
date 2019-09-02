using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personnage_BartCassidy : Personnage
{
    /// <summary>
    /// Constructeur par défaut de la classe
    /// </summary>
    public Personnage_BartCassidy() : base(
        "Bart Cassidy",
        4,
        4,
        "Chaque fois qu’il perd un point de vie, il pioche immédiatement une carte.",
        true,
        "Américain",
        'B',
        1,
        1)
    { }
}
