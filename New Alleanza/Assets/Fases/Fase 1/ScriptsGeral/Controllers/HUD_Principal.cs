using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD_Principal : MonoBehaviour
{
    //SISTEMA DE FERRAMENTAS
    [SerializeField] GameObject mapaMenu;
    [SerializeField] GameObject inventarioMenu;
    [SerializeField] GameObject UI;

    //COLETA DE FERRAMENTAS
    public GameObject inventarioButton, mapaButton;
    public GameObject MochilaCenario, MapaCenario; //todo o Canvas, não só o sprite

    float offMin_x;
    float offMax_y;

    private void Awake()
    {
        mapaMenu.SetActive(false);

        /*if (SceneManager.GetActiveScene().name == "MorganHouse")
        {
            offMin_x = 2000;
            offMax_y = -2000;
        }
        else if (SceneManager.GetActiveScene().name == "Praia")
        {
            offMin_x = 2000;
            offMax_y = -2000;
        }
        else if (SceneManager.GetActiveScene().name == "Escadaria")
        {
            offMin_x = 2000;
            offMax_y = -2000;
        }*/

        inventarioMenu.GetComponent<RectTransform>().offsetMin = new Vector2(2000, inventarioMenu.GetComponent<RectTransform>().offsetMin.y);
        inventarioMenu.GetComponent<RectTransform>().offsetMax = new Vector2 (inventarioMenu.GetComponent<RectTransform>().offsetMax.x, -2000);

        UI.SetActive(true);
    }

    public void MapaAbre()
    {
        mapaMenu.SetActive(true);
        UI.SetActive(false);
    }

    public void MapaFecha()
    {
        mapaMenu.SetActive(false);
        UI.SetActive(true);
    }

    public void InventarioAbre()
    {
        inventarioMenu.GetComponent<RectTransform>().offsetMin = new Vector2 (500, 190);
        inventarioMenu.GetComponent<RectTransform>().offsetMax = new Vector2 (-500, -50);

        UI.SetActive(false);
    }

    public void InventarioFecha()
    {
        inventarioMenu.GetComponent<RectTransform>().offsetMin = new Vector2 (2000, inventarioMenu.GetComponent<RectTransform>().offsetMin.y);
        inventarioMenu.GetComponent<RectTransform>().offsetMax = new Vector2 (inventarioMenu.GetComponent<RectTransform>().offsetMin.x, -2000);

        UI.SetActive(true);
    }

    //SISTEMA PAUSE
    public GameObject PauseMenu;
    public GameObject ConfigMenu;
    public bool isPause;

    void Start()
    {
        PauseMenu.SetActive(false);
    }

    public void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;

        UI.SetActive(false);
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;

        UI.SetActive(true);
    }

    public void AbrirMenuConfig ()
    {
        ConfigMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void FechaManuConfig ()
    {
        ConfigMenu.SetActive (false);
        PauseMenu.SetActive (true);
    }

    //SISTEMA DE COLETA DE FERRAMENTAS
    public void HabilitarInventario ()
    {
        inventarioButton.SetActive (true);
        MochilaCenario.SetActive (false);
    }

    public void HabilitarMapa ()
    {
        mapaButton.SetActive (true);
        MapaCenario.SetActive (false);
    }
}