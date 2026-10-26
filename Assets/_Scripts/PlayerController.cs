using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 8f;

    public int lives = 3;
    public TextMeshProUGUI livesText;

    void Start()
    {
        UpdateLivesText();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;

            transform.position = Vector3.MoveTowards(
                transform.position,
                mousePosition,
                moveSpeed * Time.deltaTime
            );
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            TakeDamage();
            other.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            TakeDamage();
            other.gameObject.SetActive(false);
        }
    }

    void TakeDamage()
    {
        lives--;

        UpdateLivesText();

        if (lives <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }

    void UpdateLivesText()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }
    }
}
