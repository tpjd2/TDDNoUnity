using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private List<Image> imagens;
    [SerializeField] private int quantidade;
    [SerializeField] private Image img;

    private Container container;
    //private Coracao cor;

    // Start is called before the first frame update
    void Start()
    {
        //cor = new Coracao(img);
        container =
            new Container(imagens.Select(img => new Coracao(img)).ToList());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            container.Recarregar(quantidade);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            container.Descarregar(quantidade);
        }
    }
}
