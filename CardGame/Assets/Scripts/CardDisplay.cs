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
  


    void Start()
    {
        Name.text = RefCard.Name;
        Description.text = RefCard.Description;
        //ClassArt.sprite = RefCard.ClassArt;
        TypeArt.sprite = RefCard.TypeArt;
        switch (RefCard.CardType)
        {
            case Card.Type.Str:
                ClassArt.sprite = RefCard.StrArt;
                break;
            case Card.Type.Dex:
                ClassArt.sprite = RefCard.DexArt;
                break;
            case Card.Type.Faith:
                ClassArt.sprite = RefCard.FaithArt;
                break;
            case Card.Type.Int:
                ClassArt.sprite = RefCard.IntArt;
                break;
            default:
                ClassArt.sprite = RefCard.BlankArt;
                break;
        }
    }
}
