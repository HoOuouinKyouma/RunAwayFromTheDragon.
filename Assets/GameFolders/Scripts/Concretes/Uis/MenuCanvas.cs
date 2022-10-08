using GameFolders.Scripts.GameManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvas : MonoBehaviour
{
    public void ExitButtonClick()
    {
        GameManager.Instance.ExitGame();
    }

    public void StartButtonClick()
    {
        GameManager.Instance.StartGame();
    }
}
