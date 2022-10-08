using System.Collections.Generic;
using UnityEngine;

public abstract class GenericPool<T> : MonoBehaviour where T : Component
{
    [SerializeField] T[] prefabs;
    [SerializeField] int countloop = 5;

    // ilk giren ilk cikar
    Queue<T> _poolPrefabs = new Queue<T>();

    private void Awake()
    {
        SingletonObject();
    }

    private void Start()
    {
        GrowPoolPrefab();
    }

    protected abstract void SingletonObject();

    public T Get()
    {
        if (_poolPrefabs.Count == 0)
        {
            GrowPoolPrefab();
        }

        return _poolPrefabs.Dequeue();
    }

    private void GrowPoolPrefab()
    {
        for (int i = 0; i < countloop; i++)
        {
            T newPrefab = Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
            newPrefab.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(newPrefab);
        }
    }

    public void Set(T poolObject)
    {
        poolObject.gameObject.SetActive(false);
        _poolPrefabs.Enqueue(poolObject);
    }
}
