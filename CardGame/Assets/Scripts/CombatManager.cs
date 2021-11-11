using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public static CombatManager Instance { get; private set; }
    //the value the deck holds, can be anything i want it to be 
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
    }

    public void DrawCard() //gets called every time the player draws a card from his deck to his hand
    {
        CardDisplay pulledCard = DeckSystem.Instance.PlayerGameDeck.Peek();
        Debug.Log(pulledCard.Name.text + " added to the players hand"); 
        HandSystem.Instance.PlayerHand.Add(DeckSystem.Instance.PlayerGameDeck.Pop());
    }

    public void PlayCard(CardDisplay SelectedCard)
    {
        //add the selected card to the discard pile
        DiscardPileSystem.Instance.DiscardPile.Add(SelectedCard);
        //play the card and activate its effect, events are added to the cooresponging ones.
        SelectedCard.RefCard.Play();
        HandSystem.Instance.PlayerHand.Remove(SelectedCard);
    }

    public void StartCombat()
    {
        DealCards();
        Debug.Log("combat started");
    }

    void DealCards()
    {
        for (int i = 0; i < 5; i++)
        {
            DrawCard();
        }
        ViewDeck();
    }

    void ViewDeck()
    {
        foreach (var item in DeckSystem.Instance.PlayerGameDeck)
        {
            Debug.Log("card in deck");
        }
        foreach (var item in HandSystem.Instance.PlayerHand)
        {
            Debug.Log("card in hand");
        }
    }

    //events - on turn end, on turn beginning, on play card - tba

}
