using System;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public float sightDistance;
    public Transform eyes;
    RaycastHit hit;
    bool hitSomething;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnDrawGizmos()
    {
        if (hitSomething && hit.transform.CompareTag("Player"))
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }
        Gizmos.DrawRay(eyes.position, eyes.forward * sightDistance);
    }

    // Update is called once per frame
    void Update()
    {
        hitSomething = Physics.Raycast(eyes.position, eyes.forward, out hit, sightDistance);

        if (hitSomething)
        {
            if (hit.transform.CompareTag("Player"))
            {
                print("Du bliver kigget på O_O");
            }
        }
        
    }
}
