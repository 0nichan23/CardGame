using System.Collections.Generic;
using UnityEngine;

public class Fighter : Hero
{
    private void Start()
    {
        PlayerClass.Add(Stat.STR);
        Name = "Fighter";
        for (int i = 0; i < PlayerClass.Count; i++)
        {
            for (int j = 0; j < PlayerIndividualDeck.Count; j++)
            {
                Debug.Log("card1");
            }
        }
        DeckSystem.Instance.Addhero(this);

    }

    //speical ability
    //class specific logic
}
