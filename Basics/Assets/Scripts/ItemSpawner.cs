using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    private const float MinPosX = -9;
    private const float MinPosY = 5;
    private const float MaxPosX = 9;
    private const float MaxPosY = -5;

    public GameObject itemPrefab;

    [SerializeField] private int itemsToSpawn = 20;

    // Start is called before the first frame update
    private void Start()
    {
        for (var i = 0; i < itemsToSpawn; i++)
        {
            var newPos = new Vector2(Random.Range(MinPosX, MaxPosX), Random.Range(MinPosY, MaxPosY));
            GameObject item = Instantiate(itemPrefab, newPos, Quaternion.identity);
            item.tag = "item";
        }
    }
}