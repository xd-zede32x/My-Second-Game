using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GamehaseEndel = false;
    public float restartDelete = 1f;

    public GameObject ComleteLevelUI;

    public void CompleteLevel()
    {
        ComleteLevelUI.SetActive(true); 
    }

    public void EndGame()
    {
        if (GamehaseEndel == false)
        {
            GamehaseEndel = true;
            Debug.Log("GameOver");
            Invoke("RestartGame", restartDelete);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
