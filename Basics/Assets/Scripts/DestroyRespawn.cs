using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class DestroyRespawn : MonoBehaviour
{
    private const float MIN_POS_X = -9;
    private const float MIN_POS_Y = 5;
    private const float MAX_POS_X = 9;
    private const float MAX_POS_Y = -5;

    public GameObject cubePrefab;

    private void OnMouseDown()
    {
        var newPos = new Vector2(Random.Range(MIN_POS_X, MAX_POS_X), Random.Range(MIN_POS_Y, MAX_POS_Y));
        var instance = Instantiate(cubePrefab, newPos, Quaternion.identity);
        var cubeBehaviour = instance.GetComponent<DestroyRespawn>();
        cubeBehaviour.cubePrefab = cubePrefab;
        Destroy(gameObject);
    }
}