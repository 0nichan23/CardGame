using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Hero[] Party;
    public static Hero SelectedHero;
    void Start()
    {
        StartCoroutine("StartGame");
        SelectedHero = null;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Hero")
                {
                    SelectedHero = hit.collider.gameObject.GetComponent<Hero>();
                    HandSystem.Instance.FilterCards();
                }
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SelectedHero = null;
            HandSystem.Instance.FilterCards();
        }


    }



    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(1);
        CombatManager.Instance.StartCombat();

    }
}
