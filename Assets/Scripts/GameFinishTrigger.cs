using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishTrigger : MonoBehaviour
{
    [SerializeField] private EndPoint[] _endPoints;

    private void Awake()
    {
        //_endPoints = GameObject.FindObjectsOfType<EndPoint>();
        _endPoints = gameObject.GetComponentsInChildren<EndPoint>();
    }
}
