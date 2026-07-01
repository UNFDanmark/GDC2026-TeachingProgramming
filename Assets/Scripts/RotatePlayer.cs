using UnityEngine;
using UnityEngine.InputSystem;

public class RotatePlayer : MonoBehaviour
{
    
    public InputAction rotateAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotateAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateAction.ReadValue<float>() > 0)
        {
            transform.Rotate(0, 5, 0);    
        }
        else if (rotateAction.ReadValue<float>() < 0)
        {
            transform.Rotate(0, -5, 0);
        }
        
        
        
    }
}
