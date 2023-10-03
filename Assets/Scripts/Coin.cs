using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Coin : MonoBehaviour
{
    [SerializeField] private UnityEvent _coinCollected;
    
    public event UnityAction Reached
    {
        add => _coinCollected.AddListener(value);
        remove => _coinCollected.RemoveListener(value);
    }
    
    public bool IsCollected { get; private set; }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsCollected)
        {
            return;
        }
        
        if (collision.TryGetComponent(out Player player))
        {
            IsCollected = true;
            _coinCollected?.Invoke();
        }
    }
}
