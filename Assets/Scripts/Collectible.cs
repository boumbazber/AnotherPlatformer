using UnityEngine;

public class Collectible : MonoBehaviour
{
	// компонент для подсчета монет
	public ScoreDisplay CoinDisplay;

	void OnTriggerEnter(Collider other)
	{
		// Проверяем, что это игрок
		if (other.TryGetComponent<PlayerController>(out var player))
		{
			// увеличиваем счетчик монет
			CoinDisplay.CurrentScore += 1;

			// Уничтожаем текущий объект
			Destroy(gameObject);
		}
	}
}