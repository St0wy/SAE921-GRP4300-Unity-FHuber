using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class ShootMovement : MonoBehaviour
{
    public Camera cam;

    [SerializeField] private int rotationOffset = 0;
    [SerializeField] private float speed = 300;
    private Rigidbody2D rb;
    private Vector2 mousePosition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get the position of the mouse in world point
        mousePosition = cam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
    }

    public void Move(InputAction.CallbackContext context)
    {
        var movement = context.action.ReadValue<Vector2>();
        movement *= speed * Time.deltaTime;
        rb.velocity = movement;
    }

    
    private void FixedUpdate()
    {
        // Rotates the player to the mouse position
        rb.rotation = mousePosition.AngleToPoint(rb.position) + rotationOffset;
    }
}