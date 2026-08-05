using UnityEngine;

public class Bola : MonoBehaviour
{
	public float velocidade = 10f;

	private Rigidbody2D rb;

	public void ReiniciarBola()
	{
		transform.position = Vector3.zero;
		rb.linearVelocity = Vector2.zero;
		Vector2 direcao = new Vector2(
			Random.Range(-1f, 1f),
			Random.Range(-1f, 1f)
			).normalized;
		rb.linearVelocity = direcao * velocidade;
	
	}

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

		Vector2 direcao = new Vector2(1, Random.Range(-1f, 1f)).normalized;
		rb.linearVelocity = direcao * velocidade;
	}

	void Update()
	{
		Vector2 vel = rb.linearVelocity;

		if (vel.magnitude > 0.1f)
		{
			float angulo = Mathf.Atan2(vel.y, vel.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler(0, 0, angulo + 180f);
		}
	}
}
