using GameFolders.Scripts.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticlePool : GenericPool<EnemyController>
{

    public static ObsticlePool Instance { get; private set; }
    protected override void SingletonObject()
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
}
