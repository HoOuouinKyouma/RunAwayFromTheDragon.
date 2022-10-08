using GameFolders.Scripts.GameManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    public void YesButtonClick()
    {
        GameManager.Instance.StartGame();
    }

    public void NoButtonClick()
    {
        GameManager.Instance.ReturnMenu();
    }
}
