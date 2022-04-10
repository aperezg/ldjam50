using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Configuration")]
    public float speed;

    [Header("Dependencies")]
    public Rigidbody2D body;

    #region private
    private Vector2 _movementInput;
    private int _fps;
    #endregion

    public void Update()
    {
        _fps = (int)(1f / Time.deltaTime);        
    }

    public void FixedUpdate()
    {
        body.velocity = _movementInput * speed * _fps * Time.fixedDeltaTime;
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        _movementInput = value.ReadValue<Vector2>();
    }
}
