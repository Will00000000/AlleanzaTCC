using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador2D_Terra : MonoBehaviour
{
    public bool Is_Rua1, Is_Rua2, Is_Rua3;

    private Rigidbody2D rig;
    private Camera visaoAtaque;

    public bool CamSeguindo = true;
    public Vector3 destinoCam;

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
    Animator anima;
    float xMove, yMove;

    void Start()
    {
        anima = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();

        nameScene = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        //se não puder mover (diálogo ativo)
        if (!podeMover)
        {
            rig.velocity = Vector2.zero; // para o movimento

            // força animação parada
            anima.SetFloat("SideMove", 0);

            return; // impede qualquer outro movimento
        }

        Mover();

        if (DashAtivado)
        {
            DashAtaque();
        }

        anima.SetFloat("SideMove", Mathf.Abs(xMove));
    }

    void Mover()
    {
        rig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * velocidade, yMove * velocidade);
        xMove = Input.GetAxisRaw("Horizontal");

        if (xMove < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        else
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

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "detectorRua1")
        {
            Is_Rua1 = true;
        }

        if (col.gameObject.tag == "detectorRua2")
        {
            Is_Rua2 = true;
        }

        if (col.gameObject.tag == "detectorRua3")
        {
            Is_Rua3 = true;
        }
    }
}