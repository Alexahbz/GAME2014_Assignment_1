using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    float speed = 3f;

    [SerializeField]
    float bottomBoundary = -6f;

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if (transform.position.y < bottomBoundary)
        {
            gameObject.SetActive(false);
        }
    }
}
