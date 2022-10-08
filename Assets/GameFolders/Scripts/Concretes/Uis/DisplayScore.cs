using GameFolders.Scripts.GameManager;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    TextMeshProUGUI _ScoreText;

    private void Awake()
    {
        _ScoreText = gameObject.GetComponent<TextMeshProUGUI>();

    }

    private void Start()
    {
        GameManager.Instance.OnScoreChanged += HandleOnScoreChanged;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged;
    }

    private void HandleOnScoreChanged(int score = 0)
    {
        _ScoreText.text = $"Score:{score}";
    }
}
