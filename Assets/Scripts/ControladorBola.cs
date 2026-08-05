using UnityEngine;
using UnityEngine.Rendering;

public class ControladorBola : MonoBehaviour
{
    public float velocidade = 2f;
    private Rigidbody2D rb;
    private Vector2 posicaoInicial;
    private float velocidadeGiro = 2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posicaoInicial = transform.position;
        launch();
    }

    private void launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.linearVelocity = new Vector2(velocidade * x, velocidade * y);


        float direcaoGiro = Random.Range(0, 2) == 0 ? -1f : 1f;
        rb.angularVelocity = velocidadeGiro * direcaoGiro;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 novaVelocidade = rb.linearVelocity;
        novaVelocidade *= 1.05f;
        rb.linearVelocity = novaVelocidade;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gol1") || other.CompareTag("Gol2"))
        {
            ResetarBola();
        }
    }

    void ResetarBola()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = posicaoInicial;
        Invoke("launch", 1f);
    }
}