using System;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float rotateSpeed;

    void OnTriggerEnter(Collider other)
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
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }
}
