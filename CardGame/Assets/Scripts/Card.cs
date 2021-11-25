using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card")]
public class Card : ScriptableObject
{
    public string Name;
    public string Description;
    //public Sprite ClassArt;
    public Sprite TypeArt;
    public Stat CardType;
    public Sprite Art;

    
    public void Play()
    {
        Debug.Log(Description);
    }
}
