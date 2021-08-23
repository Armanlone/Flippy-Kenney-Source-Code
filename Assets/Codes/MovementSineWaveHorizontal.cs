using UnityEngine;
using Game;

public class MovementSineWaveHorizontal : MonoBehaviour
{

	[Tooltip("Attach the Rigidbody2D reference here.")]
	[SerializeField]
	private Rigidbody2D rb2D = null;

	[Tooltip("The number of times it curves up and down.")]
	[SerializeField]
	private float frequency = 0.5f;

	[Tooltip("The height of the curve in up and down motion.")]
	[SerializeField]
	private float amplitude = 0.25f;

	private void Update()
	{

		if (rb2D == null || GameManager.getIsGamePause())
			return;

		float x = Mathf.Cos(Time.time * frequency) * amplitude;
		float y = Mathf.Sin(3.14f * 2f * Time.time * frequency) * amplitude;
		//x = rb2D.velocity.x;
		//y = Mathf.Sin(Time.time * frequency) * amplitude;
		rb2D.velocity = new Vector2(x, y);

	}

}