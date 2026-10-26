using System.Collections;
using UnityEngine;

public class LifePickupPool : MonoBehaviour
{
    [SerializeField] GameObject lifePickupPrefab;
    [SerializeField] float spawnInterval = 10f;
    [SerializeField] float spawnY = 6f;
    [SerializeField] float minX = -2f;
    [SerializeField] float maxX = 2f;

    void Start()
    {
        StartCoroutine(SpawnPickups());
    }

    IEnumerator SpawnPickups()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            float randomX = Random.Range(minX, maxX);

            Instantiate(
                lifePickupPrefab,
                new Vector3(randomX, spawnY, 0f),
                Quaternion.identity
            );
        }
    }
}
