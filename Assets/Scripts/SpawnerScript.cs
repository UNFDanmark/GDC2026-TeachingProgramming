using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject toSpawn;
    public float spawnCooldown;
    public float spawnArea;
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
            spawnPosition.x += Random.Range(-spawnArea, spawnArea);
            spawnPosition.z += Random.Range(-spawnArea, spawnArea);
            currentSpawnTime = spawnCooldown;
            Instantiate(toSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
