using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card RefCard;
    public Text Name;
    public Text Description;
    public Image ClassArt;
    public Image TypeArt;
    public Image Back;
    public Stat CardStat;

    private void Update()
    {
        if (DeckSystem.Instance.PlayerGameDeck.Contains(this))
        {
            Back.gameObject.SetActive(true);
        }
        else
        {
            Back.gameObject.SetActive(false);
        }
    }
    void Start()
    {
        Name.text = RefCard.Name;
        Description.text = RefCard.Description;
        TypeArt.sprite = RefCard.TypeArt;
        ClassArt.sprite = RefCard.Art;
        CardStat = RefCard.CardType;
    }
}
