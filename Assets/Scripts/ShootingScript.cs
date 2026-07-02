using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingScript : MonoBehaviour
{
    public GameObject bullet;
    public InputAction shootingInput;
    public float cooldown;
    public float bulletSpeed;

    float cooldownLeft = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootingInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        cooldownLeft -= Time.deltaTime; //Forklar -=
        if (shootingInput.WasPressedThisFrame() && cooldownLeft <= 0)
        {
            cooldownLeft = cooldown;
            GameObject bul = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody bulRb = bul.GetComponent<Rigidbody>();
            bulRb.linearVelocity = transform.forward * bulletSpeed;
        }
    }
}
