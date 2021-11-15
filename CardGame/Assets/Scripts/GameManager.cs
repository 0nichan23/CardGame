using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    void Start()
    {
        CombatManager.Instance.StartCombat();
    }

    public void playcard()
    {
        if (HandSystem.Instance.PlayerHand[0])
        {
            CombatManager.Instance.PlayCard(HandSystem.Instance.PlayerHand[0]);
        }
        else
        {
            Debug.LogError("u aint got anymoe cards");
        }
    }
}
