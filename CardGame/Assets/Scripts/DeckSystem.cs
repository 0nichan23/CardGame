using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Collections;

public class DeckSystem : MonoBehaviour
{
    public CardDisplay card;
    public static DeckSystem Instance { get; private set; }
    //public CardDisplay[] cards = new CardDisplay[5];
    public Stack<CardDisplay> PlayerGameDeck;
    public Stack<CardDisplay> PlayerWholeDeck = new Stack<CardDisplay>(30);
    public List<Hero> IndividualDecks= new List<Hero>(3);


    //value can be anything i want to be

    private void Awake()
    {   
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        PlayerGameDeck = PlayerWholeDeck;
    }
    private void Start()
    {
        setUpDeckf();
    }

    void setUpDeckf()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Debug.Log("added card");
                Hero selectedIndex = IndividualDecks[i];
                PlayerWholeDeck.Push(selectedIndex.PlayerIndividualDeck[j]);
            }
        }
        //shuffle();
    }

    public void Addhero(Hero hero)
    {
        Debug.Log(hero.name + " added");
        IndividualDecks.Add(hero);
    }


   
    //draw functions should work in the combat manager
    // only 1 instance, created when combat intiates 

}
