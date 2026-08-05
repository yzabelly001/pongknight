using JetBrains.Annotations;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public static AudioManager instancia;

	[Header("Audio Source")]
	public AudioSource efeitoSource;

	[Header("Sons")]
	public AudioClip somBatida;
	public AudioClip somPonto;
	public AudioClip somBotao;

	private void Awake()
	{
		if (instancia == null)
		{
			instancia = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}
	public void TocarBatida()
	{
		efeitoSource.PlayOneShot(somBatida);
	}
	public void TocarPonto()
	{
		efeitoSource.PlayOneShot(somPonto);
	}
	public void TocarBotao()
	{
		efeitoSource.PlayOneShot(somBotao);
	}
}