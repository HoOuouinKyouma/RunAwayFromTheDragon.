using UnityEngine;

public abstract class LifeCycleController : MonoBehaviour
{
    [SerializeField] private float maxLifeTime = 5f;

    private float _currtentTime;

    private void Update()
    {
        _currtentTime += Time.deltaTime;
        if (_currtentTime > maxLifeTime)
        {
            Destroy(this.gameObject);
        }
    }
}
