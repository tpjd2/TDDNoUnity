using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coracao
{
    private const float preenchimentoPedaco = 0.25f;
    private readonly Image image;

    public Coracao(Image image)
    {
        this.image = image;
    }

    public float getPedacos() { return image.fillAmount * 4; }

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
