using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador2D_Terra : MonoBehaviour
{
    public bool Is_Rua1 = false, Is_Rua2 = false, Is_Rua3 = false;

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

    [Header("Animação")]
    Animator anima;
    float xMove, yMove;

    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();

        nameScene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        Mover();

        if (DashAtivado)
        {
            DashAtaque();
        }

        anima.SetFloat("SideMove", Mathf.Abs (xMove));
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

    //REPAGINAR ISSO AQUI
    /*void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "area ataque")
        {
            DashAtivado = true;
            destino = col.transform.position;
            destinoCam = new Vector3(col.transform.position.x, col.transform.position.y, -10);

            CamSeguindo = false;
        }
    

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "area ataque")
        {
            DashAtivado = false;
            CamSeguindo = true;
        }
    }*/

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