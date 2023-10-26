using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLoser : MonoBehaviour
{
    [SerializeField] private Player _playerHealth;

    public void Change()
    {
        _playerHealth.LostHealthPoint();
    }
}
