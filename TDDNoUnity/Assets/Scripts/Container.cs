using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Container
{
    private List<Coracao> list;

    public Container(List<Coracao> list)
    {
        this.list = list;
    }

    public void Recarregar(int pedacos)
    {
        int pedacosRecarregar;

        foreach (Coracao temp in list)
        {
            if (pedacos < temp.pedacosVazios)
                pedacosRecarregar = pedacos;
            else
                pedacosRecarregar = temp.pedacosVazios;
            pedacos -= temp.pedacosVazios;
            temp.Recarregar(pedacosRecarregar);

            if (pedacos <= 0) break;
        }
    }

    public void Descarregar(int pedacos)
    {
        int pedacosDescarregar;

        foreach (Coracao temp in list.AsEnumerable().Reverse())
        {
            if (pedacos < temp.pedacosPreenchidos)
                pedacosDescarregar = pedacos;
            else
                pedacosDescarregar = temp.pedacosPreenchidos;
            pedacos -= temp.pedacosPreenchidos;
            temp.Descarregar(pedacosDescarregar);

            if (pedacos <= 0) break;
        }
    }
}
