using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
	// Ётот метод можно вызвать через OnClick Events
	public void StartGame()
	{
		// загрузка файла уровн¤
		SceneManager.LoadScene("MainLevel");
	}

	// «вкрывает игру
	public void Quit()
	{
		// закрытие приложени¤
		Application.Quit();
	}
}

