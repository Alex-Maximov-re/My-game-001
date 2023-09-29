using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _hit;

    public bool _collisionCheck = false;
    
    private bool OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.collider.TryGetComponent(out Block block))
        {
           _hit?.Invoke();     //инициализируем событие
        }*/
        
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("Конец игры!");
            _collisionCheck = true;
        }

        return _collisionCheck;
    }
}
