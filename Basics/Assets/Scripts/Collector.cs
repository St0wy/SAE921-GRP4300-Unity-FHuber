using System;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] private float speed = 17;

    private ScoreBehaviour scoreBehaviour;
    private Rigidbody2D rb;

    private void Awake()
    {
        scoreBehaviour = GetComponent<ScoreBehaviour>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movement *= speed * Time.deltaTime;
        rb.velocity = movement;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Check that we collide with an item
        if (!col.gameObject.CompareTag("item")) return;
        
        scoreBehaviour.IncrementScore();
        Destroy(col.gameObject);
    }
}