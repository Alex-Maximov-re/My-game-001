using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [HideInInspector] public bool _collisionCheck = false;
    [SerializeField] private UnityEvent _hit;
    [SerializeField] private int _healthPoint;
    
    public event UnityAction Hit
    {
        add => _hit.AddListener(value);
        remove => _hit.RemoveListener(value);
    }
    
    public bool IsHit { get; private set; }

    public int HealthPoint => _healthPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsHit)
        {
            return;
        }
        
        if (collision.collider.TryGetComponent(out Block block))
        {
            IsHit = true;
            _hit?.Invoke();     //инициализируем событие
        }
    }

    public void LostHealthPoint()
    {
        _healthPoint--;
    }
}
