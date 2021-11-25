using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Stat
{
    STR,
    DEX,
    INT,
    FTH,
    NRML
}
public class Hero : MonoBehaviour
{
    //equipment 
    //levelups
    protected string Name;

    public List<Stat> PlayerClass = new List<Stat>();
}

   
        


