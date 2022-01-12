using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    private const float MIN_POS_X = -9;
    private const float MIN_POS_Y = 5;
    private const float MAX_POS_X = 9;
    private const float MAX_POS_Y = -5;


    public GameObject itemPrefab;

    [SerializeField] private int itemsToSpawn = 20;

    // Start is called before the first frame update
    private void Start()
    {
        for (var i = 0; i < itemsToSpawn; i++)
        {
            var newPos = new Vector2(Random.Range(MIN_POS_X, MAX_POS_X), Random.Range(MIN_POS_Y, MAX_POS_Y));
            var item = Instantiate(itemPrefab, newPos, Quaternion.identity);
            item.tag = "item";
        }
    }
}