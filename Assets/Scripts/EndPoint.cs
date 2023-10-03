using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class EndPoint : MonoBehaviour
{
    [HideInInspector] public bool _endPointCollisionCheck = false;
    [SerializeField] private UnityEvent _coinCollected;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _endPointCollisionCheck = true;
            _coinCollected?.Invoke();
        }
    }
}
