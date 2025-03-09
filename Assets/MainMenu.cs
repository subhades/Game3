using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartSinglePlayer()
    {
        GameManage.Instance.SetPlayers(1);
    }

    public void StartTwoPlayer()
    {
        GameManage.Instance.SetPlayers(2);
    }
}
