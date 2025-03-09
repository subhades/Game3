using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class PlayerShip : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ScoreKeeper;
    public int EnemyDeath = 0;
    GameObject leftbound;
    GameObject rightbound;
    GameObject upperbound;
    GameObject lowerbound;
    GameObject basicprojectile;
    private KeyCode up;
    private KeyCode down;
    private KeyCode left;
    private KeyCode right;
    private KeyCode shoot;




    void Start()
    {
        ScoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<Text>();
        leftbound = GameObject.Find("lbound");
        rightbound = GameObject.Find("rbound");
        upperbound = GameObject.Find("ubound");
        lowerbound = GameObject.Find("bbound");
        basicprojectile = GameObject.Find("Projectile");
        if (this.tag == "Player2")
        {
            up = KeyCode.UpArrow;
            down = KeyCode.DownArrow;
            left = KeyCode.LeftArrow;
            right = KeyCode.RightArrow;
            shoot = KeyCode.Return;
        }
        else
        {
            up = KeyCode.W;
            down = KeyCode.S;
            left = KeyCode.A;
            right = KeyCode.D;
            shoot = KeyCode.Space;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(left))
        {
            //move left
            if (this.transform.position.x > leftbound.transform.position.x)
            {
                this.transform.position -= new Vector3(0.01f, 0f, 0f);
            }
        }
        else if (Input.GetKey(right))
        {
            //move right
            if (this.transform.position.x < rightbound.transform.position.x)
            {
                this.transform.position += new Vector3(0.01f, 0f, 0f);
            }
        }
        else if (Input.GetKey(up))
        {
            //move right
            if (this.transform.position.y < upperbound.transform.position.y)
            {
                this.transform.position += new Vector3(0f, 0.05f, 0f);
            }

        }
        else if (Input.GetKey(down))
        {
            //move right
            if (this.transform.position.y > lowerbound.transform.position.y)
            {
                this.transform.position -= new Vector3(0f, 0.05f, 0f);
            }

        }

        if (Input.GetKeyDown(shoot))
        {
            GameObject newprojectile = Instantiate(basicprojectile);
            newprojectile.transform.position = this.transform.position + new Vector3(0, 0, 5f);
        }

    }

    public void PlayerScore()
    {
        EnemyDeath += 1;
        ScoreKeeper.text = "Score: " + EnemyDeath;
    }
}
