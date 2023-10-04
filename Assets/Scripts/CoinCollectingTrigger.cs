using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

public class CoinCollectingTrigger : MonoBehaviour
{
    [SerializeField] private Coin[] _coins;
    public bool AllCoinsCollected { get; private set; } = false;

    private void OnEnable()
    {
        //_coins = GameObject.FindObjectsOfType<Coin>();
        //_coins = gameObject.GetComponentsInChildren<Coin>();

        foreach (var coin in _coins)
        {
            coin.Reached += OnCoinCollected;
        }
    }

    private void OnDisable()
    {
        foreach (var coin in _coins)
        {
            coin.Reached -= OnCoinCollected;
        }
    }

    private void OnCoinCollected()
    {
        foreach (var coin in _coins)
        {
            if (coin.IsCollected == false)
            {
                AllCoinsCollected = false;
                return;
            }
            else
            {
                AllCoinsCollected = true;
            }
            
            Debug.Log("Ура вы собрали все монетки!");
        }
    }
}
