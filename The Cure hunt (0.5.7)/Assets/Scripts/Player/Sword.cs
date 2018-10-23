using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sword : MonoBehaviour {

    public int Sword_CurrentDamage;
    public Sprite[] Swords;
    public int[] Sword_Damage;
    public Button[] Espadas;
    public int Sword_Current;
    public Button[] EspadasBorrada;
    public Image[] Cadeado;

    public float[] SwordCriticoChance;
    public float SwordCurrentCriticoChance;


    // Use this for initialization
    void Start () {
        //Swords[0] = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // Essa void, serve para o jogador poder escolher qual espada ele quer jogar dar 4 opçoes, cada uma com seu dano diferente (podemos colocar o alcance maior em cada uma tambem) //
    public void SwordEscolhida(string Sword)
    {
        if (Sword == "Sword1")
        {
            Sword_CurrentDamage = Sword_Damage[0];
            Sword_Current = 0;
            print(Sword_CurrentDamage);
            SwordCurrentCriticoChance = SwordCriticoChance[0];
        }
        if (Sword == "Sword2")
        {
            Sword_CurrentDamage = Sword_Damage[1];
            Sword_Current = 1;
            print(Sword_CurrentDamage);
            SwordCurrentCriticoChance = SwordCriticoChance[1];
        }
        if (Sword == "Sword3")
        {
            Sword_CurrentDamage = Sword_Damage[2];
            Sword_Current = 2;
            print(Sword_CurrentDamage);
            SwordCurrentCriticoChance = SwordCriticoChance[2];
        }
        if (Sword == "Sword4")
        {
            Sword_CurrentDamage = Sword_Damage[3];
            Sword_Current = 3;
            print(Sword_CurrentDamage);
            SwordCurrentCriticoChance = SwordCriticoChance[3];
        }
    }
    public void SwordBorrada(string Borrada)
    {

    }
}
