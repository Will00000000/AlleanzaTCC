using UnityEngine;

public class Interacao : MonoBehaviour
{
    public Dialogo dialogo;
    
    [Tooltip("Dê um nome único para este diálogo para o jogo lembrar que ele já foi lido.")]
    public string idDoDialogo; 

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            // Verifica se o PlayerPrefs já tem o registro de que este diálogo foi ativado
            // O padrão é 0 (falso), e mudamos para 1 (verdadeiro) quando ativado
            if (PlayerPrefs.GetInt(idDoDialogo, 0) == 0)
            {
                dialogo.IniciarDialogo();

                // Salva permanentemente que este diálogo já foi usado
                PlayerPrefs.SetInt(idDoDialogo, 1);
                PlayerPrefs.Save(); // Garante que o dado foi gravado no disco
            }
        }
    }
}