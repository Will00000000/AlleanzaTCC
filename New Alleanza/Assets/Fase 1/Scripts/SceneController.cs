using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : Singleton<SceneController>
{
    public bool is_Rua = false, was_Rua = false;
    public bool is_Museu = false, was_Museu = false;

    public bool is_Escadaria;

    public GameObject player;
    public Button botao;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += QuandoCenaCarregar;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= QuandoCenaCarregar;
    }

    private void Start()
    {
        ConfigurarBotoesDaCena();
    }


    public void GoCasa()
    {
        SceneManager.LoadScene("MorganHouse");
    }

    public void GoEscadaria()
    {
        SceneManager.LoadScene("Escadaria");
    }

    public void GoCidade()
    {
        SceneManager.LoadScene("Cidade");
    }

    public void GoRua()
    {
        SceneManager.LoadScene("Rua");
    }

    public void GoMuseu()
    {
        SceneManager.LoadScene("Museu");

        if (player != null)
        {
            player.transform.position = new Vector2(17, -2);
        }
    }

    public void GoQuebraCabeca()
    {
        SceneManager.LoadScene("Minigame");
    }

    public void Pocoes()
    {
        SceneManager.LoadScene("MinigamePoção");
    }
    private void QuandoCenaCarregar(Scene cena, LoadSceneMode modo)
    {
        ConfigurarBotoesDaCena();
    }

    void ConfigurarBotoesDaCena()
    {
        GameObject[] botoesEncontrados = GameObject.FindGameObjectsWithTag("IR");
        player=GameObject.Find ("Jogador");

        if (botoesEncontrados.Length == 0)
        {
            return;
        }

        foreach (GameObject botaoEncontrar in botoesEncontrados)
        {
            Button botaoAtual = botaoEncontrar.GetComponent<Button>();

            if (botaoAtual == null)
            {
                continue;
            }

            string nomeDoBotao = botaoEncontrar.name;

            botaoAtual.onClick.RemoveAllListeners();
            botaoAtual.onClick.AddListener(() => ChamarFuncaoDoBotao(nomeDoBotao));
        }
    }

    private void ChamarFuncaoDoBotao(string nomeFuncao)
    {
        switch (nomeFuncao)
        {
            case "GoCasa":
                GoCasa();
                break;

            case "GoEscadaria":
                GoEscadaria();
                break;

            case "GoCidade":
                GoCidade();
                break;

            case "GoRua":
                GoRua();
                break;

            case "GoMuseu":
                GoMuseu();
                break;

            case "GoQuebraCabeca":
                GoQuebraCabeca();
                break;

            case "Pocoes":
                Pocoes();
                break;

            default:
                break;
        }
    }
}