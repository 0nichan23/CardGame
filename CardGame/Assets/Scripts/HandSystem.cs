using System.Collections;
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
}



