using UnityEngine.SceneManagement;

namespace First_2D_Game
{
    public static class HelperIvan
    {
        public static bool BlueKey = false;
        
        public static void LoadScene()
        {
            int A = SceneManager.GetActiveScene().buildIndex;
            A++;
            SceneManager.LoadScene(A, LoadSceneMode.Single);
        }
    }
}