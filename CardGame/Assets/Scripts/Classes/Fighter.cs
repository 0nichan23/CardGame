using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Hero
{
    private void Start()
    {
        PlayerClass.Add(Stat.STR);
        Name = "Fighter";
    }

    //speical ability
    //class specific logic
}
