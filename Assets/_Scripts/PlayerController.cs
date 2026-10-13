using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float moveSpeed = 8f;

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
}
