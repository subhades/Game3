using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    PlayerShip player;

    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("heroShip").GetComponent<PlayerShip>();
        Debug.Log(player);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, 0, 0.05f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        Debug.Log(other.gameObject.tag);


        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            player.PlayerScore();
            
        }
        
        
    }
}
