using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Hero
{
    private void Start()
    {
        PlayerClass.Add(Stat.INT);
        Name = "Mage";
        DeckSystem.Instance.Addhero(this);

    }

    //speical ability
    //class specific logic
}
