using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed;
    Rigidbody rb;
    public InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveAction.Enable();
    }

   


    // Update is called once per frame
    void Update()
    {
        print("Hello world");


        if (playerSpeed > 15)
        {
            print("Du er mega hurtig");
        }
        else
        {
            print("Du er mega langsom");
        }
        
        //læser inputtet
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        
        // laver en kopi af spillerens hastighed i x-aksen
        Vector3 newVelocity = rb.linearVelocity;
        
        // vi ændrer kopiens hastighed 
        newVelocity.x = moveInput.x * playerSpeed;
        
        // vi ændrer kopiens hastighed
        newVelocity.z = moveInput.y * playerSpeed;
        
        //vi opdatere den rigtige hastighed
        rb.linearVelocity = newVelocity;
        
        
    }
}
