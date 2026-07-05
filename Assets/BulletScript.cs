using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float cooldown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
            Destroy(gameObject);
        }
    }
}
