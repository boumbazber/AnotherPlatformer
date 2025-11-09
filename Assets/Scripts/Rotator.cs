using UnityEngine;

public class Rotator : MonoBehaviour
{
	// скорость вращения
	public float RotationSpeed = 50f;

	void Update()
	{
		// вращение
		transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
	}
}
