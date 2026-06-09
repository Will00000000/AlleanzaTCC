using UnityEngine;
using UnityEngine.UI;

public class BotaoItem : MonoBehaviour
{
    public DadosItem meusDados;
    public GerenciadorDescricao gerenciadorDescricao;

    void Start()
    {
        gerenciadorDescricao = FindFirstObjectByType<GerenciadorDescricao>();

        Button botao = GetComponent<Button>();

        botao.onClick.AddListener (AoClicarNoItem);
    }

    void AoClicarNoItem()
    {
        if (gerenciadorDescricao != null)
        {
            //gerenciadorDescricao.ExibirDetalhes(meusDados);
        }
    }
}
