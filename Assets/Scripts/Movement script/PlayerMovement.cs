using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 movementValues = Vector2.zero;
    Vector2 lookingValues = Vector2.zero;
    public float MovementSpeed = 100f;
    public float TurnSpeed = 0.1f;

    
    public void IAAccelerate(InputAction.CallbackContext context)
    {
        movementValues = context.ReadValue<Vector2>();
    }

    public void IALooking(InputAction.CallbackContext context)
    {
        lookingValues =context.ReadValue<Vector2>();

        transform.Rotate(transform.up, lookingValues.x * Time.deltaTime* TurnSpeed);


    }

    void Start()
    {
        
    }

    
    void Update()
    {
      transform.Translate(movementValues.x * MovementSpeed *Time.deltaTime, 0, movementValues.y * MovementSpeed*Time.deltaTime);
      
    
    }

    
}
