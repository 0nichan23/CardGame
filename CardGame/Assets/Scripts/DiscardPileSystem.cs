using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardPileSystem : MonoBehaviour
{
    public static DiscardPileSystem Instance { get; private set; }
    public List<CardDisplay> DiscardPile;
    //the value the deck holds, can be anything i want it to be 
    private void Awake()
    {
        DiscardPile = new List<CardDisplay>();
        DiscardPile.Clear();
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
