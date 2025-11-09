using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreDisplay : MonoBehaviour
{
	// текст TextMeshPro для вывода текста
	public TextMeshProUGUI ScoreText;
	// текущие очки
	public int CurrentScore = 0;

	void Update()
	{
		// Каждый кадр обновляем текст на экране
		ScoreText.text = $"Монеты: {CurrentScore} / 10";

		// если собраны все монеты, загружаем сцену главного меню
		if (CurrentScore == 10)
		{
			SceneManager.LoadScene("MainLevel");
		}
	}
}
