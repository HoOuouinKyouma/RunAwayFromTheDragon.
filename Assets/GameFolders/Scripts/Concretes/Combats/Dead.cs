using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    [SerializeField] bool _isDead;
    public bool IsDead => _isDead;
    public event System.Action OnDead;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "Finish")
        {
            _isDead = true;
            OnDead?.Invoke();
            Time.timeScale = 0f;
        }
        
    }

}
