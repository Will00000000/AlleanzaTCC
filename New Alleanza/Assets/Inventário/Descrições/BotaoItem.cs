using UnityEngine;
using UnityEngine.UI;

public class BotaoItem : MonoBehaviour
{
    public DadosItem meusDados;

    private GerenciadorDescricao gerenciadorDescricao;

    void Start()
    {
        gerenciadorDescricao = FindFirstObjectByType<GerenciadorDescricao>();

        Button botao = GetComponent<Button>();

        if (botao != null)
        {
            botao.onClick.AddListener(AoClicarNoItem);
        }
    }

    void AoClicarNoItem()
    {
        if (gerenciadorDescricao != null)
        {
            gerenciadorDescricao.ExibirDetalhes(meusDados);
        }
    }
}
