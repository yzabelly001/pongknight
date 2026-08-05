using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class ControleDoMenu : MonoBehaviour
{


    public void IniciarJogo()
    {
        SceneManager.LoadScene("CenaJogo");
    }

    public void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("O jogo fechou!");
    }

    public void ReiniciarPartida()
    {
        SceneManager.LoadScene("CenaJogo");
    }

    public void IrParaOMenu()
    {
        SceneManager.LoadScene("MenuInicial");
    }
}