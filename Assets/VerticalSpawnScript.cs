using UnityEngine;

public class VerticalSpawnScript : MonoBehaviour
{
    public GameObject VerticalObstacle;
    public float spawnInterval = 2.0f; // Time in seconds between spawns
    public float spawnTimer = 0.0f; // Timer to track spawn intervals
    public float widthOffset = 10.0f; // Offset for the spawn position (horizontal range)

    void Start()
    {
        SpawnObstacle(); // Initial spawn at the start
    }

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

    void SpawnObstacle()
    {
        float leftmost = transform.position.x - widthOffset;
        float rightmost = transform.position.x + widthOffset;

        // Spawn at a random X, fixed Y (top of the screen)
        Instantiate(
            VerticalObstacle,
            new Vector3(Random.Range(leftmost, rightmost), transform.position.y, 0),
            transform.rotation
        );
    }
}
