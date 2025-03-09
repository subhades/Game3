using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    GameObject lbound;
    GameObject rbound;
    GameObject ubound;
    GameObject bbound;
    GameObject player;
    GameObject spawner;
    private float moveChance = 0.90f;
    private Vector3 targetPosition;
    private bool isMoving = false;
    private float moveSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        lbound = GameObject.Find("lbound");
        rbound = GameObject.Find("rbound");
        ubound = GameObject.Find("ubound");
        bbound = GameObject.Find("bbound");
        player = GameObject.Find("heroShip");
        spawner = GameObject.Find("Spawner");

        targetPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float randomVal = Random.Range(0.0f, 1.0f);
        this.transform.position -= new Vector3(0, 0, 0.08f);

        if (!isMoving && randomVal <= moveChance)
        {
            PickNewTarget();
        }
        if (isMoving)
        {
            MoveToTarget();
        }
        if (this.transform.position.z < player.transform.position.z)
        {
            spawner.GetComponent<Spawner>().currentShips -= 1;
            Destroy(this.gameObject);
        }
    }
    void PickNewTarget()
    {
        float targetX = Random.Range(lbound.transform.position.x, rbound.transform.position.x);
        float targetY = Random.Range(bbound.transform.position.y, ubound.transform.position.y);
        targetPosition = new Vector3(targetX, targetY, 0);

        isMoving = true;
    }
    void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            isMoving = false;
        }
    }
}
