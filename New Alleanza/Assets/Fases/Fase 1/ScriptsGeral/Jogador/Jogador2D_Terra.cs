using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador2D_Terra : MonoBehaviour
{
    private Rigidbody2D rig;

    public bool CamSeguindo = true;
    public Vector3 destinoCam;

    [Header("Movimento")]
    [SerializeField] int velocidade;
    [SerializeField] float velocidadeDash, pulo;
    [SerializeField] Vector2 destino;
    [SerializeField] Vector2 move;
    [SerializeField] bool DashAtivado = false;

    //CONTROLE DE MOVIMENTO (para diálogo)
    public bool podeMover = true;

    [Header("Animação")]
    Animator anima;
    float xMove, yMove;

    void Start()
    {
        anima = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Mover();

        //se não puder mover (diálogo ativo)
        if (!podeMover)
        {
            rig.velocity = Vector2.zero; // para o movimento

            // Alteração: Verificação de segurança para o erro parar
            if (anima != null)
            {
                anima.SetFloat("SideMove", 0);
            }

            return; // impede qualquer outro movimento
        }

        if (anima != null)
        {
            anima.SetFloat("SideMove", Mathf.Abs(xMove));
        }

        if (DashAtivado)
        {
            DashAtaque();
        }
    }

    void Mover()
    {
        rig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * velocidade, yMove * velocidade);
        xMove = Input.GetAxisRaw("Horizontal");

        if (xMove > 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        else if (xMove < 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
    }

    private void DashAtaque()
    {
        if (Input.GetMouseButtonDown(0))
        {
            destino = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        transform.position = Vector2.MoveTowards(transform.position, destino, velocidadeDash * Time.deltaTime);
    }
}