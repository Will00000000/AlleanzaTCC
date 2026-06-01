using TMPro;
using UnityEngine;

public class GerenciadorDescricao : MonoBehaviour
{
    public TextMeshProUGUI campoTitulo;
    public TextMeshProUGUI campoTipo;
    public TextMeshProUGUI campoDescricao;

    void Start()
    {
        LimparDescricao();
    }

    public void ExibirDetalhes(DadosItem item)
    {
        campoTitulo.text = item.titulo;
        campoTipo.text = item.tipo;
        campoDescricao.text = item.descricao;
    }

    public void LimparDescricao()
    {
        campoTitulo.text = "";
        campoTipo.text = "";
        campoDescricao.text = "Selecione um item...";
    }
}
