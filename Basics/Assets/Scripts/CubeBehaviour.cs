using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    private const float MIN_POS_X = -9;
    private const float MIN_POS_Y = 5;
    private const float MAX_POS_X = 9;
    private const float MAX_POS_Y = -5;

    public GameObject cubePrefab;

    private void OnMouseOver()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        var newPos = new Vector2(Random.Range(MIN_POS_X, MAX_POS_X), Random.Range(MIN_POS_Y, MAX_POS_Y));
        var instance = Instantiate(cubePrefab, newPos, Quaternion.identity);
        var cubeBehaviour = instance.GetComponent<CubeBehaviour>();
        cubeBehaviour.cubePrefab = cubePrefab;
        Destroy(gameObject);
    }
}