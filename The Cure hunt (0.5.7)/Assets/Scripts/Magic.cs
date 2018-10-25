using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magic : MonoBehaviour {

    [Header ("Gemas")]
    public Button GemaFloresta;
    public Button GemaFogo;
    [Header("Gema Atual")]
    public Image GemaAtual;
    public Sprite GemaVerde;
    public Sprite GemaVerm;
    [Header("Gemas Bloqueadas")]
    public Button[] GemasBloqueadas;
    public Text[] Text;

    // Use this for initialization





    public void Start()
    {
        GemaFloresta.gameObject.SetActive(false);
        GemaFogo.gameObject.SetActive(false);
        GemasBloqueadas[0].gameObject.SetActive(true);
        GemasBloqueadas[1].gameObject.SetActive(true);
    }
    public void Update()
    {

    }
    public void GemasBloq(string name)
    {
        if(name == "Bloq1")
        {
        }
        if (name == "Bloq2")
        {
        }
        if (name == "Bloq3")
        {
        }
        if (name == "Bloq4")
        {
        }
        if (name == "Bloq5")
        {
        }
        if (name == "Bloq6")
        {
        }
    }

    public void MagiaAtual(string name)
    {
        if(name == "Floresta")
        {
            GemaAtual.GetComponent<Image>().sprite = GemaVerde;
            print("GEMA VERDE " + name);
        }
        if (name == "Fogo")
        {
            GemaAtual.GetComponent<Image>().sprite = GemaVerm;
        }
    }

}
