using System;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinScript : MonoBehaviour
{
    public float rotSpeed;
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotSpeed, Space.World);
    }
}
