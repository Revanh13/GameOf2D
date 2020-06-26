using System;
using UnityEngine;

namespace First_2D_Game
{
    public class KeyController : MonoBehaviour
    {
        public GameObject Particle;
        private Animator _animator;
        private GameObject _hudBlueKey;

        private void Awake()
        {
            _hudBlueKey = GameObject.Find("KeyImage");
            _hudBlueKey.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                gameObject.SetActive(false);
                _hudBlueKey.SetActive(true);
                HelperIvan.BlueKey = true;
                Particle.SetActive(false);
            }
        }
    }
}