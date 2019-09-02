using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personnage_BlackJack : Personnage
{
    /// <summary>
    /// Constructeur par défaut de la classe
    /// </summary>
    public Personnage_BlackJack() : base(
        "Black Jack",
        4,
        4,
        "Durant la phase 1 de son tour, il doit montrer la 2nde carte qu'il a piochée. Si c'est un Cœur ou un Carreau, il pioche une carte supplémentaire.",
        true,
        "Américain",
        'B',
        1,
        1)
    { }
}