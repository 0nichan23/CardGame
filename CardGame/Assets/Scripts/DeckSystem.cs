using System.Collections.Generic;
using UnityEngine;


public class DeckSystem : MonoBehaviour
{
    public CardDisplay card;
    public static DeckSystem Instance { get; private set; }
    //public CardDisplay[] cards = new CardDisplay[5];
    public Stack<CardDisplay> PlayerGameDeck;
    public Stack<CardDisplay> PlayerWholeDeck;
    public List<Hero> IndividualDecks;


    //value can be anything i want to be

    private void Awake()
    {

        PlayerWholeDeck = new Stack<CardDisplay>(30);
        IndividualDecks = new List<Hero>(3);
        if (Instance == null)
        {
            Instance = this;
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Debug.Log("added card");
                    Hero selectedIndex = IndividualDecks[0];
                    PlayerWholeDeck.Push(selectedIndex.PlayerIndividualDeck[j]);

                }
            }
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        PlayerGameDeck = PlayerWholeDeck;
    }

    public void Addhero(Hero hero)
    {
        Debug.Log(hero.name + " added");
        IndividualDecks.Add(hero);
    }

    //draw functions should work in the combat manager
    // only 1 instance, created when combat intiates 

}
