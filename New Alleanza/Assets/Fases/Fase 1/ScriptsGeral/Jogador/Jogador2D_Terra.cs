using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador2D_Terra : MonoBehaviour
{
    private Rigidbody2D rig;
    private Camera visaoAtaque;

    bool CamSeguindo;
    Vector3 destinoCam;

    string nameScene;

    [Header("Movimento")]
    [SerializeField] int velocidade;
    [SerializeField] float velocidadeDash, pulo;
    [SerializeField] Vector2 destino;
    [SerializeField] Vector2 move;
    [SerializeField] bool DashAtivado = false;

    //CONTROLE DE MOVIMENTO (para diálogo)
    public bool podeMover = true;

    [Header("Animação")]
    //Animator anima;
    float xMove, yMove;

    private void Start()
    {
        //anima = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();

        nameScene = SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        //se não puder mover (diálogo ativo)
        if (!podeMover)
        {
            rig.velocity = Vector2.zero; // para o movimento

            //anima.SetFloat("SideMove", 0);

            return; // impede qualquer outro movimento
        }

        Mover();

        if (DashAtivado)
        {
            DashAtaque();
        }

        //anima.SetFloat("SideMove", Mathf.Abs(xMove));
    }

    private void Mover()
    {
        rig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * velocidade, yMove * velocidade);
        xMove = Input.GetAxisRaw("Horizontal");

        if (xMove < 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        else if (xMove > 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
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