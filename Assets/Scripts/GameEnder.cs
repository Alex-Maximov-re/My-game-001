using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class GameEnder : MonoBehaviour
{
   [SerializeField] private Movement _movement;
   [SerializeField] private float _levelRestartDelay = 2f;
   [SerializeField] private Transform _playerPosition;
   [SerializeField] private UnityEvent _hit;
   [SerializeField] private Player _player;
   [SerializeField] private EndPoint _endPoint;
   

   public void EndGame()
   {
      _movement.enabled = false;
      
      Invoke("RestartLevel", _levelRestartDelay);
   }

   private void RestartLevel()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   private void Update()
   {
      if (_playerPosition.transform.position.y < -5f)
      {
         Debug.Log("Вы упали и умерли! Игра окончена!");
         EndGame();
      }

      if (_player._collisionCheck)
      {
         Debug.Log("Вы ударились! Игра окончена!");
         EndGame();
      }

      if (_endPoint._endPointCollisionCheck)
      {
         Debug.Log("Ура! Вы выйграли!");
         EndGame();
      }
   }
}
