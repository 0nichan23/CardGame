using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeckSystem : MonoBehaviour
{
    public CardDisplay card;
    public static DeckSystem Instance { get; private set; }
    public CardDisplay[] cards = new CardDisplay[5];
    public Stack<CardDisplay> PlayerGameDeck;
    public Stack<CardDisplay> PlayerWholeDeck;
    
    

    //value can be anything i want to be

    private void Awake()
    {
        
        PlayerWholeDeck = new Stack<CardDisplay>();
        if (Instance == null)
        {
            Instance = this;
            for (int i = 0; i < 30; i++)
            {
                PlayerWholeDeck.Push(cards[Random.Range(0, cards.Length)]);
            }
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        PlayerGameDeck = PlayerWholeDeck;
    }

    //draw functions should work in the combat manager
    // only 1 instance, created when combat intiates 
     
}
