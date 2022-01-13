using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
	[SerializeField] private float speed = 300;
	private Rigidbody2D rb;
	private Vector2 movement;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	[UsedImplicitly]
	private void OnMove(InputValue value)
	{
		movement = value.Get<Vector2>();
	}

	private void FixedUpdate()
	{
		Vector2 newMove = movement * (speed * Time.deltaTime);
		rb.velocity = newMove;
	}
}
