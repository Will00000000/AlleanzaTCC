using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD_Quarto : MonoBehaviour
{
    //SISTEMA DE FERRAMENTAS
    [SerializeField] GameObject mapaMenu;
    [SerializeField] GameObject inventarioMenu;
    [SerializeField] GameObject UI;

    //COLETA DE FERRAMENTAS
    public GameObject inventarioButton, mapaButton;
    public GameObject MochilaCenario, MapaCenario; //todo o Canvas, não só o sprite

    private void Awake()
    {
        mapaMenu.SetActive(false);
        inventarioMenu.SetActive(false);
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
        inventarioMenu.SetActive(true);
        UI.SetActive(false);
    }

    public void InventarioFecha()
    {
        inventarioMenu.SetActive(false);
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

    public void Sair ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuPrincipal");
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