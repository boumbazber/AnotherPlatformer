using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
	// скорость движения
	public float Speed = 2f;
	// расстояние движения
	public float Distance = 3f;

	// начальная позиция платформы
	private float _initialPosition;

	private void Start()
	{
		// сохранение начальной позиции платформы
		_initialPosition = transform.position.x;
	}

	void Update()
	{
		// Движение вперед-назад по синусоиде
		float movement = Mathf.Sin(Time.time * Speed) * Distance + _initialPosition;
		transform.position = new Vector3(movement, transform.position.y, transform.position.z);
	}
}
