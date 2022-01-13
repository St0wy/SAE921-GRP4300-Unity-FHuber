using UnityEngine;

[RequireComponent(typeof(ScoreBehaviour))]
public class Collector : MonoBehaviour
{
    private ScoreBehaviour scoreBehaviour;

    private void Awake()
    {
        scoreBehaviour = GetComponent<ScoreBehaviour>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // Check that we collide with an item
        var item = col.gameObject;
        
        if (!item.CompareTag("item")) return;
        
        scoreBehaviour.IncrementScore();
        Destroy(item);
    }
}