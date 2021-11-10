using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    int x;
    void Start()
    {
        x = 0;
        CombatManager.Instance.StartCombat();
    }
    // Update is called once per frame
    void Update()
    {
        playcard();
    }

    void playcard()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (x <= 4)
            {
                CombatManager.Instance.PlayCard(HandSystem.Instance.PlayerHand[x]);
                x++;
            }
            else
            {
                Debug.Log("u aint got any moe carsds");
            }

                
           

        }
       


    }
}
