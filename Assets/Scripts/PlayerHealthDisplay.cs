using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthDisplay : MonoBehaviour
{
	// текст TextMeshPro для вывода текста
	public TextMeshProUGUI HealthText;
	// текущее здоровье
	public int CurrentHealth = 3;

	void Update()
	{
		// Каждый кадр обновляем текст на экране
		HealthText.text = new string('♥', CurrentHealth);

		// если здоровье опустилось до нуля, загружаем сцену главного меню
		if (CurrentHealth <= 0)
		{
			SceneManager.LoadScene("MainLevel");
		}
	}
}
