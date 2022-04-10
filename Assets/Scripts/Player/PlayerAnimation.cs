using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimation : MonoBehaviour
{
    [Header("Dependencies")]
    public Animator animator;

    public void OnMovement(InputAction.CallbackContext value)
    {
        float movementInput = value.ReadValue<Vector2>().magnitude;
        animator.SetBool("IsRunning", movementInput > 0f);
    
    }

}
