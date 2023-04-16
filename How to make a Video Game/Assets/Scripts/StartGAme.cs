using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGAme : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
