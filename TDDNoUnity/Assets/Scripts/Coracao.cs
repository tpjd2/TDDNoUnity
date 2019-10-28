using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coracao
{
    public static readonly int pedacosPorCoracao = 4;
    private const float preenchimentoPedaco = 0.25f;
    private readonly Image image;
    public int pedacosPreenchidos{
        get { return CalculaQuantidadePedacos(); }
    }
    public int pedacosVazios
    {
        get { return pedacosPorCoracao - CalculaQuantidadePedacos(); }
    }


    public Coracao(Image image)
    {
        this.image = image;
    }

    public int CalculaQuantidadePedacos() { return (int)(image.fillAmount * pedacosPorCoracao); }

    public void Recarregar(int pedacos)
    {
        if (pedacos < 0)
            throw new ArgumentOutOfRangeException("O argumento deve ser um valor positivo", "pedacos");
        this.image.fillAmount += pedacos * preenchimentoPedaco;
    }

    public void Descarregar(int pedacos)
    {
        if (pedacos < 0)
            throw new ArgumentOutOfRangeException("O argumento deve ser um valor positivo", "pedacos");
        this.image.fillAmount -= pedacos * preenchimentoPedaco;
    }
}
