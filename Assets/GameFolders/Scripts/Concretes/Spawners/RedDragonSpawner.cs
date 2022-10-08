using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Controller;
using GameFolders.Scripts.Abstracts;
using UnityEngine;

namespace GameFolders.Scripts.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        [SerializeField] private EnemyController enemy;
        protected override void Spawn()
        {
            Instantiate(enemy, this.transform);
        }

    }
}

