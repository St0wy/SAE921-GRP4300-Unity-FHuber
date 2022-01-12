using System;
using UnityEngine;

[RequireComponent(typeof(ScoreBehaviour))]
public class Collector : MonoBehaviour
{
    private ScoreBehaviour scoreBehaviour;

    private void Awake()
    {
        scoreBehaviour = GetComponent<ScoreBehaviour>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Check that we collide with an item
        if (!col.gameObject.CompareTag("item")) return;
        
        scoreBehaviour.IncrementScore();
        Destroy(col.gameObject);
    }
}