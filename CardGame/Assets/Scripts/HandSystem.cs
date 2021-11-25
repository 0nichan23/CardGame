using System.Collections.Generic;
using UnityEngine;

public class HandSystem : MonoBehaviour
{
    public static HandSystem Instance { get; private set; }
    public List<CardDisplay> PlayerHand;
    //the value the deck holds, can be anything i want it to be 
    private void Awake()
    {
        if (Instance == null)
        {
            PlayerHand = new List<CardDisplay>();
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    [ContextMenu("test filter cards")]
    public void FilterCards()
    {
        if (GameManager.SelectedHero == null)
        {
            ClearFilter(true);
            return;
        }
        ClearFilter(false);
        foreach (var Card in PlayerHand)
        {
            if (Card.CardStat == Stat.NRML)
            {
                Card.gameObject.SetActive(true);
                continue;
            }
            foreach (var HeroStat in GameManager.SelectedHero.PlayerClass)
            {
                if (Card.CardStat == HeroStat)
                {
                    Card.gameObject.SetActive(true);
                    break;
                }
            }
        }
    }
    
    public void ClearFilter(bool B)
    {
        foreach (var item in PlayerHand)
        {
            item.gameObject.SetActive(B);
        }
    }
}



