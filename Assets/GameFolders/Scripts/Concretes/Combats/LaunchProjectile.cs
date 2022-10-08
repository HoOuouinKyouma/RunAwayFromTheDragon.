using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    [SerializeField] private ProjectileController projectilePrefab;
    [SerializeField] private Transform projectileTransform;
    [SerializeField] private float delayProjectile = 1f;

    [SerializeField] GameObject projectileParent;

    float _currentDelayTime = 0f;
    bool _canLaunch = false;


    private void Update()
    {
        _currentDelayTime += Time.deltaTime;

        if (_currentDelayTime >= delayProjectile)
        {
            _canLaunch = true;
            _currentDelayTime = 0f;
        }
    }

    public void LaunchAction()
    {
        if (_canLaunch)
        {
            ProjectileController newProjectile = Instantiate(projectilePrefab, projectileTransform.position, projectileTransform.rotation);

            newProjectile.transform.parent = projectileParent.transform;
            _canLaunch = false;
        }
    }
}
