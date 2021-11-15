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
    public Type CardType;
    public Sprite StrArt;
    public Sprite DexArt;
    public Sprite FaithArt;
    public Sprite IntArt;
    public Sprite BlankArt;
    public enum Type
    {
        Str,
        Dex,
        Faith,
        Int,
        Normal
    }
    public void Play()
    {
        Debug.Log(Description);
    }
}
