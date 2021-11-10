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
        ClassArt.sprite = RefCard.ClassArt;
        TypeArt.sprite = RefCard.TypeArt;
    }
}
