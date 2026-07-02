using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletCooldown;
    public float bulletCooldownLeft;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletCooldownLeft = bulletCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        bulletCooldownLeft -= Time.deltaTime;
        if (bulletCooldownLeft <= 0)
        {
            Destroy(gameObject);
        }
    }
}
