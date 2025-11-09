using UnityEngine;

public class Bouncer : MonoBehaviour
{
	public float BounceForce = 500f;

	private void OnCollisionEnter(Collision collision)
	{
		// Проверяем, что это игрок
		if (collision.gameObject.TryGetComponent<PlayerController>(out var player))
		{
			// подбрасываем игрока вверх
			player.GetComponent<Rigidbody>().AddForce(Vector3.up * BounceForce);
		}
	}
}
