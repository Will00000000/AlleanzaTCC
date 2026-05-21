using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD_Quarto : MonoBehaviour
{
    [Header("Menus (Janelas)")]
    [SerializeField] GameObject mapaMenu;
    [SerializeField] GameObject inventarioMenu;
    [SerializeField] GameObject UI;

    [Header("Botões da HUD (Os que clicamos para abrir)")]
    public GameObject inventarioButton; 
    public GameObject mapaButton;

    [Header("Objetos do Cenário (Os que coletamos)")]
    public GameObject MochilaCenario; 
    public GameObject MapaCenario;

    [Header("Sistema de Pause")]
    public GameObject PauseMenu;
    public GameObject ConfigMenu;

    // --- NOVO: REFERÊNCIA PARA O ANIMATOR DO MAPA ---
    // (Caso o seu 'animator' lá de baixo seja apenas do pause, criamos esse específico para o mapa)
    [Header("Animação do Mapa")]
    [SerializeField] private Animator mapaAnimator; 

    private void Awake()
    {
        // Garante que os menus comecem fechados
        if (mapaMenu != null) mapaMenu.SetActive(false);
        if (inventarioMenu != null) inventarioMenu.SetActive(false);
        if (UI != null) UI.SetActive(true);
    }

    void Start()
    {
        // VERIFICAÇÃO DA MOCHILA
        if (GameManager.MorganPegouMochila) {
            if (inventarioButton != null) inventarioButton.SetActive(true);
            if (MochilaCenario != null) MochilaCenario.SetActive(false);
        } else {
            if (inventarioButton != null) inventarioButton.SetActive(false);
            if (MochilaCenario != null) MochilaCenario.SetActive(true);
        }

        // VERIFICAÇÃO DO MAPA
        if (GameManager.MorganPegouMapa) {
            if (mapaButton != null) mapaButton.SetActive(true);
            if (MapaCenario != null) MapaCenario.SetActive(false);
        } else {
            if (mapaButton != null) mapaButton.SetActive(false);
            if (MapaCenario != null) MapaCenario.SetActive(true);
        }

        if (PauseMenu != null) PauseMenu.SetActive(false);
    }

    // MÉTODOS DE ABRIR/FECHAR
    public void MapaAbre()
    {
        mapaMenu.SetActive(true);
        UI.SetActive(false);

        // --- NOVO: FORÇA A ANIMAÇÃO DO MAPA A REINICIAR ---
        if (mapaAnimator != null)
        {
            // Substitua "NomeDaSuaAnimacao" pelo nome EXATO do clipe de animação de abertura do mapa
            mapaAnimator.Play("NomeDaSuaAnimacao", -1, 0f); 
        }
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

    // SISTEMA DE COLETA
    public void HabilitarInventario()
    {
        GameManager.MorganPegouMochila = true; 
        if (inventarioButton != null) inventarioButton.SetActive(true);      
        if (MochilaCenario != null) MochilaCenario.SetActive(false);      
    }

    public void HabilitarMapa()
    {
        GameManager.MorganPegouMapa = true;   
        if (mapaButton != null) mapaButton.SetActive(true);            
        if (MapaCenario != null) MapaCenario.SetActive(false);         
    }

    // PAUSE E SAIR
    public GameObject animator; // Mantido o seu original caso use em outro lugar
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

    public void Sair()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuPrincipal");
    }
}