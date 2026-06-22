using UnityEngine;

public class InteracaoBotao : MonoBehaviour
{
    public Dialogo dialogo;
    
    [Tooltip("Dê um nome único para este diálogo para o jogo lembrar que ele já foi lido.")]
    public string idDoDialogo; 

    // Esta função precisa ser 'public' para o Botão conseguir enxergá-la
    public void ClicarNoBotaoDialogo()
    {
        // Verifica se o diálogo já foi assistido antes
        if (PlayerPrefs.GetInt(idDoDialogo, 0) == 0)
        {
            dialogo.IniciarDialogo();

            // Salva permanentemente que este diálogo já foi usado
            PlayerPrefs.SetInt(idDoDialogo, 1);
            PlayerPrefs.Save();
            
            // Opcional: Você pode desativar o botão logo após o clique para o jogador ver que sumiu
            // gameObject.SetActive(false); 
        }
        else
        {
            Debug.Log("Este diálogo já foi visto e não vai iniciar de novo.");
        }
    }
}