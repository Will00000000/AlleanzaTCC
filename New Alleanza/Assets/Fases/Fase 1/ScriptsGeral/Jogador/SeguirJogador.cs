using UnityEngine;

public class SeguirJogador : MonoBehaviour
{
    [Header("Configurações de Movimento")]
    public Transform jogador;
    public float velocidade = 3f;
    public float distanciaMinima = 1.5f;

    [Header("Controle")]
    public bool deveSeguir = false; // Começa falso, vira true após o diálogo

    void Update()
    {
        // Se ela ainda não deve seguir ou se o jogador não foi definido, não faz nada
        if (!deveSeguir || jogador == null) return;

        // Calcula a distância entre a Mellory e o Morgan
        float distancia = Vector2.Distance(transform.position, jogador.position);

        // Se ela estiver longe do Morgan, ela anda na direção dele
        if (distancia > distanciaMinima)
        {
            Vector2 posicaoAlvo = new Vector2(jogador.position.x, transform.position.y); 

            transform.position = Vector2.MoveTowards(transform.position, posicaoAlvo, velocidade * Time.deltaTime);

            // Opcional: Virar o sprite para o lado que está andando
            if (jogador.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            else
            {
                transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
        }
    }

    public void ComeçarASeguir()
    {
        deveSeguir = true;
    }
}