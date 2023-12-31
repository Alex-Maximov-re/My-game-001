using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPoint : MonoBehaviour
{
    [HideInInspector] public bool _finalPointCollisionCheck = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _finalPointCollisionCheck = true;
        }
    }
}
