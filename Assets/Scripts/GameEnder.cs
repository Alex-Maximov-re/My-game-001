using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;


public class GameEnder : MonoBehaviour
{
   [SerializeField] private Movement _movement;
   [SerializeField] private float _levelRestartDelay = 2f;
   [SerializeField] private Transform _playerPosition;
   [SerializeField] private Player _player;
   [SerializeField] private CoinCollectingTrigger _coinTrigger;
   [SerializeField] private FinalPoint _finalPoint;

   private void EndGame()
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

      if (_finalPoint._finalPointCollisionCheck)
      {
         Debug.Log("Ура! Вы выйграли!");
         EndGame();
      }

      if (_coinTrigger.AllCoinsCollected)
      {
         Debug.Log("Ура! Вы собрали все монетки!");
      }
   }
}
