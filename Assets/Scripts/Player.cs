using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [HideInInspector] public bool _collisionCheck = false;
    [SerializeField] private UnityEvent _hit;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.collider.TryGetComponent(out Block block))
        {
           _hit?.Invoke();     //инициализируем событие
        }*/
        
        if (collision.collider.tag == "13")
        {
            Debug.Log("Конец игры!");
            _collisionCheck = true;
        }
    }
}
