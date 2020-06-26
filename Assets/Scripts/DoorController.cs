using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace First_2D_Game
{
    public class DoorController : MonoBehaviour
    {
        public GameObject Thank;
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player") && !gameObject.CompareTag("Exit"))
            {
                if (HelperIvan.BlueKey == true)
                {
                    gameObject.SetActive(false);
                }
            }
            else if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Exit"))
            {
                if (SceneManager.GetActiveScene().buildIndex == 2)
                {
                    Time.timeScale = 0.0f;
                    Thank.SetActive(true);
                }
                HelperIvan.LoadScene();
            }
        }
    }
}