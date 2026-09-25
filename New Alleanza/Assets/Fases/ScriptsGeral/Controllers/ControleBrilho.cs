using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControleBrilho : MonoBehaviour
{
    public static ControleBrilho Instance;

    [Header("Componente do Filtro de Brilho")]
    public Image painelEscuro;

    [Header("Nome/Tag da Busca do Slider")]
    [Tooltip("Nome exato do Slider na Hierarquia para vincular automaticamente ao carregar a cena")]
    public string nomeDoSlider = "SliderLum";

    [Header("Limite do Escurecimento")]
    [Range(0.1f, 1f)]
    [Tooltip("Define a opacidade máxima (Alpha) do preto quando o slider estiver no mínimo. Ex: 0.6 = 60% preto.")]
    public float escurecimentoMaximo = 0.6f; 

    private Slider sliderAtual;

    private void Awake()
    {
        // Padrão Singleton: Impede que o Canvas de Brilho se duplique ao trocar de cena
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mantém o filtro ativo em todas as cenas
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Start()
    {
        CarregarEAplicarBrilho();
        BuscarEVincularSlider();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        CarregarEAplicarBrilho();
        BuscarEVincularSlider();
    }

    private void CarregarEAplicarBrilho()
    {
        float brilhoSalvo = PlayerPrefs.GetFloat("Brilho", 1f);
        AplicarBrilho(brilhoSalvo);
    }

    public void AplicarBrilho(float valor)
    {
        if (painelEscuro != null)
        {
            // Define a cor como Preto puro (RGB = 0, 0, 0)
            Color corPreta = Color.black;
            
            // O Alpha varia de 0 (invisível) até o valor definido em 'escurecimentoMaximo'
            corPreta.a = (1f - valor) * escurecimentoMaximo; 
            
            painelEscuro.color = corPreta;
        }

        PlayerPrefs.SetFloat("Brilho", valor);
    }

    private void BuscarEVincularSlider()
    {
        GameObject sliderGO = GameObject.Find(nomeDoSlider);

        if (sliderGO != null)
        {
            sliderAtual = sliderGO.GetComponent<Slider>();

            if (sliderAtual != null)
            {
                sliderAtual.onValueChanged.RemoveAllListeners();

                sliderAtual.minValue = 0f;
                sliderAtual.maxValue = 1f;
                sliderAtual.value = PlayerPrefs.GetFloat("Brilho", 1f);

                sliderAtual.onValueChanged.AddListener(AplicarBrilho);
            }
        }
    }
}