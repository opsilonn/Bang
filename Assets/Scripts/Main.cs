﻿using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Main : MonoBehaviour
{
    Joueur joueur;


    /// <summary>
    /// Fait des trucs (A SUPPRIMER)
    /// </summary>
    void Start()
    {
        
        joueur = new Joueur("Opsilonn");
        joueur.GetInfo();

        joueur.SetPersonnage(new Personnage_BartCassidy());
        joueur.SetRole(new Role_Adjoint());
        joueur.GetInfo();
        


        PersonnageGestion.AfficherPersonnages();
    }
}