using UnityEngine;

public class JogadorOceano : MonoBehaviour
{
    Rigidbody2D rig; //variável que recebe o componente de física do jogador

    [Range (0, 10)] public int velocidade; //velocidade do jogador

    Vector2 posicaoMouse; //variável que pega a posição do mouse
    float anguloMira;

    public GameObject projetil; //variável para o prefab do projétil
    public Transform disparo; //local de onde o projétil será atirado

    [SerializeField] private float tempoDeRecarga = 0.5f;
    private float proximoTiroDisponível = 0f;

    void Start ()
    {
        rig = GetComponent <Rigidbody2D> (); //rig pega o componente de física que está no objeto do jogador
    }

    void Update ()
    {
        posicaoMouse = Camera.main.ScreenToWorldPoint (Input.mousePosition); //variável recebe a localização do cursor do mouse na tela
        Vector2 distancia = posicaoMouse - rig.position; //cria uma variável para calcular a distância entre o cursor do mouse e o jogador

        Disparar ();
        Mover ();
    }

    void Mover ()
    {
        rig.velocity = new Vector2 (rig.velocity.x, Input.GetAxisRaw ("Vertical") * velocidade); //movimento apenas no eixo y
    }

    private void Disparar () //função para os tiros
    {
        if (Input.GetButtonDown ("Fire1") && Time.time >= proximoTiroDisponível) //se apertar o botão padrão para atirar...
        {
            Instantiate (projetil, disparo.position, disparo.rotation); //instancia o projetil
            proximoTiroDisponível = Time.time + tempoDeRecarga;
        }
    }
}