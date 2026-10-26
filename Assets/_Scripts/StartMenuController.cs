using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void OpenInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Play");
    }
}
