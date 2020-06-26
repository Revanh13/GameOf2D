using System;
using UnityEngine;

namespace First_2D_Game
{
    public class Slime : MonoBehaviour
    {
        private PlayerController _player;

        private void Awake()
        {
            _player = GameObject.FindObjectOfType<PlayerController>();
        }
        
        private void OnTriggerEnter2D(Collider2D other)      // Смерть монстра
        {
            if (other.CompareTag("Player"))
            {
                gameObject.SetActive(false);
            }
        }

        private void OnCollisionEnter2D(Collision2D other)   // Смерть игрока
        {
            _player.RestartLevel();
        }
    }
}