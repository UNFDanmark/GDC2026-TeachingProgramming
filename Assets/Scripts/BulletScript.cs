using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletCooldown;
    float bulletCooldownLeft;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletCooldownLeft = bulletCooldown;
    }

    void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject);
        }
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
