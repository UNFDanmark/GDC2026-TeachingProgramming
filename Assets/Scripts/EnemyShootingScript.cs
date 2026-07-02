using UnityEngine;

public class EnemyShootingScript : MonoBehaviour
{
    public float cooldown;
    public float bulletSpeed;
    public GameObject bullet;

    float cooldownLeft = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldownLeft -= Time.deltaTime;
        if (cooldownLeft <= 0)
        {
            cooldownLeft += cooldown;
            GameObject bul = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody bulrb = bul.GetComponent<Rigidbody>();
            bulrb.linearVelocity = transform.forward * bulletSpeed;
        }
    }
}
