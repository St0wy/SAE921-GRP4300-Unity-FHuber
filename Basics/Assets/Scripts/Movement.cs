using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 300;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movement *= speed * Time.deltaTime;
        rb.velocity = movement;
    }
}
