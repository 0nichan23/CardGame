using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour
{
    public static Party Instance { get; private set; }
    public Hero[] Heros;
    //value can be anything u want it to be.
    private void Awake()
    {
        Heros = new Hero[3];
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

    //change hero 
    
}
