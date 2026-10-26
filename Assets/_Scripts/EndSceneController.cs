using UnityEngine;
using TMPro;

public class EndSceneController : MonoBehaviour
{
    [SerializeField] TMP_Text finalScoreText;

    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);
        finalScoreText.text = "Final Score: " + finalScore;
    }
}
