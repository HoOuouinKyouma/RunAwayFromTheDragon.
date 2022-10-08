using UnityEngine;

public class PersistentObject : MonoBehaviour
{
    [SerializeField] GameObject persistenPrefab;

    static bool _isFirstTime = true;
    private void Start()
    {
        if (_isFirstTime)
        {
            SpawnPersitentObjects();
            _isFirstTime = false;
        }
    }

    private void SpawnPersitentObjects()
    {
        GameObject newObject = Instantiate(persistenPrefab);
        DontDestroyOnLoad(newObject);
    }
}
