using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    GameObject enemyship1;
    GameObject lbound;
    GameObject rbound;
    GameObject ubound;
    GameObject bbound;
    List<GameObject> enemyships = new List<GameObject>();
    //TODO: Add variable for shooter 
    public int startingShips = 10;
    public int currentShips;

    // Start is called before the first frame update
    void Start()
    {
        currentShips = startingShips;
        enemyship1 = GameObject.Find("enemy4");
        lbound = GameObject.Find("lbound");
        rbound = GameObject.Find("rbound");
        ubound = GameObject.Find("ubound");
        bbound = GameObject.Find("bbound");

        for (int i = 0; i < startingShips; ++i)
        {
            GameObject newShip = Instantiate(enemyship1);
            newShip.GetComponent<EnemyShip>().enabled = true;
            newShip.transform.position = new Vector3(Random.Range(lbound.transform.position.x, rbound.transform.position.x), Random.Range(ubound.transform.position.y, bbound.transform.position.y), Random.Range(50, 150));
            enemyships.Add(newShip);
        }
    }

    // Update is called once per frame
    void Update()
    { 
        if (currentShips < 10)
        {
            for (int i = 0; i < enemyships.Count; ++i)
            {
                if (enemyships[i] == null)
                {
                    GameObject newenemy = Instantiate(enemyship1);
                    newenemy.GetComponent<EnemyShip>().enabled = true;
                    newenemy.transform.position = new Vector3(Random.Range(lbound.transform.position.x, rbound.transform.position.x), Random.Range(ubound.transform.position.y, bbound.transform.position.y), Random.Range(50, 150));
                    enemyships[i] = newenemy;
                }
            }
        }
    }
}
