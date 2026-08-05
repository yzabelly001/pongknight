using UnityEngine;
using TMPro;

public class PontuacaoJogador : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI placar;
    public GameObject gol1;
    public GameObject gol2;

    private int ptsJ1;
    private int ptsJ2;

    private void Start()
    {
        ptsJ1 = 0;
        ptsJ2 = 0;

        placar.text = (ptsJ1 + " x " + ptsJ2);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gol1"))
        {
            ptsJ2++;
            placar.text = (ptsJ1 + " x " + ptsJ2);
            
        }
        if (other.CompareTag("Gol2"))
        {
            ptsJ1++;
            placar.text = (ptsJ1 + " x " + ptsJ2);
			
		}
    }
}

