using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab;

    public InputAction shootAction;

    public float cooldown;
    
    public GameObject shootingPoint;

    public float bulletSpeed;

    float cooldownLeft = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        cooldownLeft -= Time.deltaTime;
        if (shootAction.IsPressed() && cooldownLeft <= 0)
        {
            cooldownLeft = cooldown;
            GameObject bullet = Instantiate(bulletPrefab, shootingPoint.transform.position, Quaternion.identity);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.linearVelocity = transform.forward * bulletSpeed;
        }
        
    }
}
