using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Image img;

    private Coracao cor;

    // Start is called before the first frame update
    void Start()
    {
        cor = new Coracao(img);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            cor.Recarregar(1);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            cor.Descarregar(1);
        }
    }
}
