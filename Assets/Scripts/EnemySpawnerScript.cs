using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    public float spawnCooldown;
    float currentSpawnTime;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentSpawnTime -= Time.deltaTime;
        if (currentSpawnTime <= 0)
        {
            Vector3 spawnPosition = transform.position;
            spawnPosition.x += Random.Range(-5f, 5f);
            spawnPosition.z += Random.Range(-5f, 5f);
            currentSpawnTime = spawnCooldown;
            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }
    }
}
