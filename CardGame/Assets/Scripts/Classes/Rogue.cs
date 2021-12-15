using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Hero
{
    private void Start()
    {
        PlayerClass.Add(Stat.DEX);
        Name = "Rogue";
        DeckSystem.Instance.Addhero(this);
        PlayerIndividualDeck = new List<CardDisplay>(10);
    }

    //speical ability
    //class specific logic
}
