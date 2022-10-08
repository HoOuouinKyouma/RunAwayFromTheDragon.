using UnityEngine;

namespace GameFolders.Scripts.Abstracts
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField]
        float maxSpawnTime = 3f;
        [Range(0.3f, 1.5f)]
        [SerializeField]
        private float minSpawnTime = 1f;

        private float _currentSpawnTime;
        private float _timeBoundary;
        private void Start()
        {
            TimeReset();
        }
        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _timeBoundary)
            {
                Spawn();
                TimeReset();
            }
        }
        protected abstract void Spawn();
        private void TimeReset()
        {
            _currentSpawnTime = 0;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}
