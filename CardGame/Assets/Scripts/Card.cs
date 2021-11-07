using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card")]
public class Card : ScriptableObject
{
    public string Name;
    public string Description;
    public Sprite ClassArt;
    public Sprite TypeArt;
    public Type CardType;

    public enum Type
    {
        Str,
        Dex,
        Faith,
        Int
    }

}
