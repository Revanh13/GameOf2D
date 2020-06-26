using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

namespace First_2D_Game
{
    public class MenuLoadScene : MonoBehaviour
    {
        public GameObject MainMenu;
        public GameObject LoaderVideoEA;
        public GameObject LoaderVideoCE;
        public GameObject MusicMenu;
        public GameObject Slider;

        public VideoClip EA;
        public VideoClip CE;
        
        private void Start()
        {
            Time.timeScale = 1;
            LoaderVideoEA.SetActive(true);
            LoaderVideoCE.SetActive(false);
            StartCoroutine(Loader());
        }

        IEnumerator Loader()
        {
            yield return new WaitForSeconds((float)EA.length);
            LoaderVideoEA.SetActive(false);
            LoaderVideoCE.SetActive(true);
            yield return new WaitForSeconds((float)CE.length);
            LoaderVideoCE.SetActive(false);
            MainMenu.SetActive(true);
            MusicMenu.SetActive(true);
        }

        private void Update()
        {
            MusicMenu.GetComponent<AudioSource>().volume = Slider.GetComponent<Slider>().value;
        }

        public void LoadScene()
        {
            HelperIvan.LoadScene();
        }

        public void ExitButton()
        {
            Application.Quit();
        }
    }
}