using GameFolders.Scripts.Controller;
using GameFolders.Scripts.GameManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileController : LifeCycleController
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyController enemy = collision.GetComponent<EnemyController>();

        if (enemy != null && collision.gameObject.tag == "enemy")
        {
            Destroy(enemy.gameObject);
            Destroy(this.gameObject);
            GameManager.Instance.IncreaseScore();
        }
    }
}
