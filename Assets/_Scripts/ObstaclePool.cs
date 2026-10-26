using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePool : MonoBehaviour
{
    [SerializeField]
    GameObject rockPrefab;
    [SerializeField]
    int poolSize = 5;
    [SerializeField]
    float spawnInterval = 3f;
    [SerializeField]
    float spawnY = 6f;
    [SerializeField]
    float minX = -2f;
    [SerializeField]
    float maxX = 2f;
    List<GameObject> rocks = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject rock = Instantiate(rockPrefab);
            rock.SetActive(false);
            rocks.Add(rock);
        }

        StartCoroutine(SpawnRocks());
    }

    IEnumerator SpawnRocks()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            foreach (GameObject rock in rocks)
            {
                if (!rock.activeInHierarchy)
                {
                    float randomX = Random.Range(minX, maxX);

                    rock.transform.position = new Vector3(
                        randomX, spawnY, 0f
                    );

                    rock.SetActive(true);
                    break;
                }
            }
        }
    }
}
