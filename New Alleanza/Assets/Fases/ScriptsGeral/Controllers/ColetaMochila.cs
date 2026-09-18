using UnityEngine;

public class ColetaMochila : MonoBehaviour
{
    // Método para ser chamado no clique do botão (UI)
    public void ColetarMochila()
    {
        PlayerPrefs.SetInt("tem_Mochila", 1);
        PlayerPrefs.Save();

        Debug.Log("Mochila coletada!");

        // Esconde o item da tela após pegar
        gameObject.SetActive(false);
    }
}