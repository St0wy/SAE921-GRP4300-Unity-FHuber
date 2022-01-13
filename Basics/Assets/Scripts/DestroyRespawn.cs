using UnityEngine;
using Random = UnityEngine.Random;

public class DestroyRespawn : MonoBehaviour
{
	private const float MinPosX = -9;
	private const float MinPosY = 5;
	private const float MaxPosX = 9;
	private const float MaxPosY = -5;

	public GameObject cubePrefab;

	private void OnMouseDown()
	{
		var newPos = new Vector2(Random.Range(MinPosX, MaxPosX), Random.Range(MinPosY, MaxPosY));
		var instance = Instantiate(cubePrefab, newPos, Quaternion.identity);
		var cubeBehaviour = instance.GetComponent<DestroyRespawn>();
		cubeBehaviour.cubePrefab = cubePrefab;
		Destroy(gameObject);
	}
}
