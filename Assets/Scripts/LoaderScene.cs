using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace First_2D_Game
{
    public class LoaderScene : MonoBehaviour
    {
        public GameObject PauseMenu;
        
        private bool _isPause = false;

        private void Awake()
        {
            PauseMenu.SetActive(false);
        }

        public void NextLevel()
        {
            HelperIvan.LoadScene();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape)) PauseGame();
        }

        public void PauseGame()
        {
            if (_isPause == false)
            {
                _isPause = true;
                Time.timeScale = 0.0f;      // Почему работает только с 0.0?
                PauseMenu.SetActive(true);
            }
            else
            {
                _isPause = false;
                Time.timeScale = 1.0f;
                PauseMenu.SetActive(false);
            }
        }

        public void GoToMenu()
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }

        public void ExitButton()
        {
            Application.Quit();
        }
    }
}