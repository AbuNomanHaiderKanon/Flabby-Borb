using UnityEngine;

public class HorizontalSpawnScript : MonoBehaviour
{
    public GameObject HorizontalObstacle;
    public float spawnInterval = 2.0f; // Time in seconds between spawns
    public float spawnTimer = 0.0f; // Timer to track spawn intervals
    public float heightOffset = 10.0f; // Offset for the spawn position


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnObstacle(); // Initial spawn at the start
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer < spawnInterval)
        {           
            spawnTimer += Time.deltaTime;
        }
        else
        {
            SpawnObstacle();
            spawnTimer = 0.0f; // Reset the timer after spawning
        }

    }

    void SpawnObstacle ()
    {
        float lowestpoint = transform.position.y - heightOffset;
        float highestpoint = transform.position.y + heightOffset;

        Instantiate(HorizontalObstacle, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0 ), transform.rotation);
    }
}
