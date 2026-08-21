using UnityEngine;

public class Lixos : MonoBehaviour
{
    public float velocidade;
    Rigidbody2D rig;

    public SistemaVida sistemaVida; //variável que recebe o objeto com o sistema de vidas anexado

    void Start ()
    {
        rig = GetComponent <Rigidbody2D> ();
    }

    void Update()
    {
        transform.position = new Vector2 (transform.position.x - velocidade * Time.deltaTime, transform.position.y);

        sistemaVida = GameObject.Find("GerenciadorVida").GetComponent<SistemaVida>();
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "projetil")
        {
            Destroy(gameObject);
            ControllerLixos.pontuação += 1;
        }

        if (col.gameObject.tag == "limite")
        {
            Destroy (gameObject);

            sistemaVida.TomarDano();
        }
    }
}