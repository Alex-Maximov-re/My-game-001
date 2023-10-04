using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HitTrigger : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    public bool AllHealthLost { get; private set; } = false;
    
    private void OnEnable()
    {
        //_coins = GameObject.FindObjectsOfType<Coin>();
        //_coins = gameObject.GetComponentsInChildren<Coin>();

        _player.Hit += OnPlayerHit;
    }
    
    private void OnDisable()
    {
        _player.Hit -= OnPlayerHit;
    }

    private void OnPlayerHit()
    {
        if (_player.HealthPoint != 0)
        {
            AllHealthLost = false;
            return;
        }
        else
        {
            AllHealthLost = true;
        }
            
        Debug.Log("о нет, у вас кончились очки здоровья!");
    }
}
