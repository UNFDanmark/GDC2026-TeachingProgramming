using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{

    public float sørensSpeed;
    int SørensHealth;

    Rigidbody rb;
    public InputAction moveAction;


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
        moveAction.Enable();
        rb = GetComponent<Rigidbody>();
        print(SørensNavn);
    }

    // hewleijfwelkrlsefeljfnwrg
    // Update is called once per frame
    void Update()
    {

        Vector2 inputValue = moveAction.ReadValue<Vector2>();
        
        // copy
        Vector3 newVelocity = rb.linearVelocity;
        
        newVelocity.x = inputValue.x * sørensSpeed;
        newVelocity.z = inputValue.y * sørensSpeed;
        
        rb.linearVelocity = newVelocity;
        
        
        if (sørensSpeed > 8)
        {
            print("wow du er mega hurtig... søren");
        }else print("du er sku lidt langsom");
        
        
        
        print("hej Søren");
        print(SørensNavn);
        
    }
}
