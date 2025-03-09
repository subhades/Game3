using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerPrefab; 
    public Transform player1Spawn;
    public Transform player2Spawn; 

    void Start()
    {
        //https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Quaternion.html
        GameObject player1 = Instantiate(playerPrefab, player1Spawn.position, Quaternion.identity);
        player1.name = "Player1";
        player1.tag = "Player"; 


        if (GameManage.Instance.playerCount == 2)
        {
            GameObject player2 = Instantiate(playerPrefab, player2Spawn.position, Quaternion.identity);
            player2.name = "Player2";
            player2.tag = "Player2";
        }
    }
}
