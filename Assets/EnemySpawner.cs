using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f; // How often enemies spawn
    public float spawnAreaWidth = 8f;
    public float spawnAreaHeight = 5f; 

    private void Start()
    {
        // Start spawning enemies
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Generate a random spawn position for enemies
        float randomX = Random.Range(-spawnAreaWidth, spawnAreaWidth);
        float randomY = spawnAreaHeight; // Spawn at the top of the screen
        Instantiate(enemyPrefab, new Vector2(randomX, randomY), Quaternion.identity);
    }
}