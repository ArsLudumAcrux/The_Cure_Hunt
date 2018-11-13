using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSword : MonoBehaviour {

    public Sword sword;
    public Statistics stats;
    public float critico;
    //ExpBar expBar;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Slime"))
        {
            critico = Random.Range(1, 101);
            Slime_Stats Slime = collision.GetComponent<Slime_Stats>();
            if (Slime.morreu == false)
            {
                DropCoin drop = collision.GetComponent<DropCoin>();

                if (critico <= sword.SwordCurrentCriticoChance)
                {
                    Slime.Life_Slime -= sword.Sword_CurrentDamage * 2;
                    print("critico" + sword.Sword_CurrentDamage);
                }
                else
                    Slime.Life_Slime -= sword.Sword_CurrentDamage;


                if (Slime.Life_Slime <= 0)
                {
                    Slime.morreu = true;
                    ExpBar expBar = collision.GetComponent<ExpBar>();
                    drop.ChanceCoinPotion();
                    //expBar.Experiencia();
                    GameManager gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                    gamemanager.monstrosMortos++;
                    gamemanager.monstrosMortos2++;
                    gamemanager.monstrosMortos3++;
                    print("Matou" + gamemanager.monstrosMortos + "montros");

                }
                else
                {
                    Slime.gameObject.GetComponent<Animator>().SetTrigger("Hit");
                }
            }
        }

        if (collision.CompareTag("Tronco"))
        {
            critico = Random.Range(1, 101);
            Tronco_Stats Tronco = collision.GetComponent<Tronco_Stats>();
            if (Tronco.morreu == false)
            {
                DropCoin drop = collision.GetComponent<DropCoin>();

                if (critico <= sword.SwordCurrentCriticoChance)
                {
                    Tronco.Life_Tronco -= sword.Sword_CurrentDamage * 2;
                    print("critico" + sword.Sword_CurrentDamage);
                }
                else
                    Tronco.Life_Tronco -= sword.Sword_CurrentDamage;


                if (Tronco.Life_Tronco <= 0)
                {
                    Tronco.morreu = true;
                    drop.ChanceCoinPotion();
                    //expBar.Experiencia(Tronco.xpMin, Tronco.xpMax);
                    GameManager gamemanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
                    gamemanager.monstrosMortos++;
                    gamemanager.monstrosMortos2++;
                    gamemanager.monstrosMortos3++;
                    print("Matou" + gamemanager.monstrosMortos + "montros");

                }
                else
                {
                    Tronco.gameObject.GetComponent<Animator>().SetTrigger("Hit");
                }
            }
        }
    }
}
