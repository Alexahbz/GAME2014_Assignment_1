using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Play");
    }
}
