using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    int SørensHealth;

    float Søren2 = 2.17f;


    bool ErSørenSur;
    // type variabelNavn værdi
    
    Vector3 SørensLokation;
    public GameObject SørensGameObject;
    Transform SørensTransform;
    string SørensNavn = "søren";
    PlayerScript sørensPlayerScript;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        print(SørensNavn);
    }

    // hewleijfwelkrlsefeljfnwrg
    // Update is called once per frame
    void Update()
    {
        print("hej Søren");
        print(SørensNavn);
        
    }
}
