using UnityEngine;

public class Interacao : MonoBehaviour
{
    public Dialogo dialogo;
    
    // Agora é uma variável comum. Ela começa falsa toda vez que o jogo inicia.
    private bool jaFoiAtivadoNestaSessao = false; 

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            // Só ativa se ainda não tiver sido usado nesta sessão de jogo
            if (!jaFoiAtivadoNestaSessao)
            {
                Debug.Log("Iniciando diálogo pela primeira vez nesta sessão.");
                
                dialogo.IniciarDialogo();

                // Marca como verdadeiro. Enquanto o jogo estiver aberto, não repete.
                jaFoiAtivadoNestaSessao = true; 
            }
            else
            {
                Debug.Log("Diálogo já aconteceu desde que o jogo foi aberto. Ignorando.");
            }
        }
    }
}