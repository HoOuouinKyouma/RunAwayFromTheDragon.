using UnityEngine;
using GameFolders.Scripts.Controller;
using GameFolders.Scripts.Abstracts;

namespace GameFolders.Scripts.Spawners
{
    public class ObsticleSpawner : BaseSpawner
    {

        [SerializeField] private EnemyController[] enemy;

        protected override void Spawn()
        {
            int enemyIndex = Random.Range(0, enemy.Length);
            Instantiate(enemy[enemyIndex], this.transform);
        }


    }
}

