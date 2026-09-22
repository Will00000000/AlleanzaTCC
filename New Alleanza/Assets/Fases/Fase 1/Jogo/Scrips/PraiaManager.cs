using UnityEngine;

public class PraiaManager : MonoBehaviour
{
	public static bool pegouPoema;

	private void Update ()
	{
		VerificarPegouPoema ();
	}

	private void VerificarPegouPoema ()
	{
		if (PlayerPrefs.GetInt ("Pegou o poema", 0) == 1)
		{
			pegouPoema = true;
		}
		else
		{
			pegouPoema = false;
		}
	}
}