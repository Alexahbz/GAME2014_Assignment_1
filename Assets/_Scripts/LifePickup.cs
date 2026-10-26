using UnityEngine;

public class LifePickup : MonoBehaviour
{
    [SerializeField] float fallSpeed = 3f;

    void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

        if (transform.position.y < -6f)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            if (player != null)
            {
                player.AddLife();
                gameObject.SetActive(false);
            }
        }
    }
}
