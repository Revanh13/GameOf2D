using System;
using UnityEngine;

namespace First_2D_Game
{
    /// <summary>
    /// Описание препятствий в игре
    /// </summary>
    public class Enemy : MonoBehaviour
    {
        private PlayerController _player;

        private void Awake()
        {
            _player = GameObject.FindObjectOfType<PlayerController>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _player.RestartLevel();
            }
        }
    }
}