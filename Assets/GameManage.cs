using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
   public static GameManage Instance { get; private set; }
   public int playerCount;

    public void Awake()
    {
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
    public void SetPlayers(int count)
    {
        Debug.Log(count);
        playerCount = count;
        SceneManager.LoadScene("SampleScene");
    }
}
