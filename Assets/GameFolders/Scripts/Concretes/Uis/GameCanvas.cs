using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;

    private void Awake()
    {

    }

    private void Start()
    {
        Dead dead = FindObjectOfType<Dead>();
        dead.OnDead += HandleOnDead;
    }

    private void HandleOnDead()
    {
        gameOverPanel.SetActive(true);
    }
}
