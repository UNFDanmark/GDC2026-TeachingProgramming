using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int health = 100;
    public float cooldown;
    
    // type variabelNavn = værdi;


     string MitNavn = "hej larve";
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(MitNavn);
    }
}
