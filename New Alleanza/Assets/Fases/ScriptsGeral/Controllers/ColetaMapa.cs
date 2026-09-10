using UnityEngine;

public class ColetaMapa : MonoBehaviour
{
    // Método para ser chamado no clique do botão (UI)
    public void ColetarMapa()
    {
        PlayerPrefs.SetInt("tem_Mapa", 1);
        PlayerPrefs.Save();

        Debug.Log("Mapa coletado!");

        // Esconde o item da tela após pegar
        gameObject.SetActive(false);
    }
}