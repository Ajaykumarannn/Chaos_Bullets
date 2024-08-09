using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 movementValues = Vector2.zero;
    public float FrameDistance = 5f;
    
    public void IAAccelerate(InputAction.CallbackContext context)
    {
        movementValues = context.ReadValue<Vector2>();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
      transform.Translate(movementValues.x * FrameDistance *Time.deltaTime, 0, movementValues.y * FrameDistance*Time.deltaTime);
      
    
    }

    
}
