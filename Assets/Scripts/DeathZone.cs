using UnityEngine;

public class DeathZone : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		// Проверяем, что это игрок
		if (other.TryGetComponent<PlayerController>(out var player))
		{
			// телепортируем в начало уровня
			player.transform.position = new Vector3(0, 1, 0);
		}
	}
}
