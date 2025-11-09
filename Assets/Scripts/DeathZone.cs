using UnityEngine;

public class DeathZone : MonoBehaviour
{
	// компонент для учета здоровья игрока
	public PlayerHealthDisplay PlayerHealth;

	void OnTriggerEnter(Collider other)
	{
		// Проверяем, что это игрок
		if (other.TryGetComponent<PlayerController>(out var player))
		{
			// уменьшаем здоровье игрока
			PlayerHealth.CurrentHealth -= 1;

			// телепортируем в начало уровня
			player.transform.position = new Vector3(0, 1, 0);
		}
	}
}
