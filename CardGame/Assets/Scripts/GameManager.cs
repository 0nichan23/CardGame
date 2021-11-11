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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playcard();
        }
    }

    public void playcard()
    {
        if (HandSystem.Instance.PlayerHand[0])
        {
            CombatManager.Instance.PlayCard(HandSystem.Instance.PlayerHand[0]);
        }
        else
        {
            Debug.LogError("u aint got anymoe cards");
        }
    }
}
