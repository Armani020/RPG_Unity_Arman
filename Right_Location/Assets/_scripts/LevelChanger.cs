using UnityEngine;
using UnityEngine.SceneManagement;

namespace _scripts
{
    public class LevelChanger : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void QuitGame()
        {
            Debug.Log("QUIT!");
        }
    }
}