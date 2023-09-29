using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class EndPoint : MonoBehaviour
{
    public bool _endPointCollisionCheck = false;
    
    private bool OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _endPointCollisionCheck = true;
        }
        
        /*if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("Конец игры!");
            _collisionCheck = true;
        }*/

        return _endPointCollisionCheck;
    }
}
