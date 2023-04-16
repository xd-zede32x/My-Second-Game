using UnityEngine;
using UnityEngine.SceneManagement;

public class LEVELCOMPLETE : MonoBehaviour
{
    public void LoadNeXtLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
