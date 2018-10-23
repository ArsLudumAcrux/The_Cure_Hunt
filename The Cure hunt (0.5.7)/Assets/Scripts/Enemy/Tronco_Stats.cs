﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tronco_Stats : MonoBehaviour {

    public int Life_Tronco;
    Animator anim;
    public bool morreu;
    public int xpMin, xpMax;
    public EnemyTronco inimigo;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        inimigo = GetComponent<EnemyTronco>();
    }
	
	// Update is called once per frame
	void Update () {
        anim.SetBool("Morrer", morreu);
        if (morreu)
        {
            velocidade(0);
        }
    }
    void velocidade(float speed)
    {

        inimigo.speed = speed;

    }
    void DestroyObject()
    {
        Destroy(gameObject);
    }
}

