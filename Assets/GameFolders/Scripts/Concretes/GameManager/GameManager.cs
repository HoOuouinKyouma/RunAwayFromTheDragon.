using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameFolders.Scripts.GameManager
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private int score;
        public static GameManager Instance { get; private set; }

        public event System.Action<int> OnScoreChanged;

        private void Awake() => SingletonThisGameObject();

        private void SingletonThisGameObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void IncreaseScore()
        {
            score += 10;
            OnScoreChanged?.Invoke(score);
        }

        public void StartGame()
        {
            score = 0;
            Time.timeScale = 1f;
            StartCoroutine(StartGameAsync());
        }

        public void ExitGame()
        {
            Application.Quit();
        }

        private IEnumerator StartGameAsync()
        {
            yield return SceneManager.LoadSceneAsync("Game");
        }

        public void ReturnMenu()
        {
            StartCoroutine(ReturnMenuAsync());
        }

        public IEnumerator ReturnMenuAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }
    }
}
