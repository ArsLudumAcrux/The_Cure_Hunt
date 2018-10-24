﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour {

    public Statistics stat;//variavel referente ao script Statistics
    Image experiencia_img;
    public float expCur;
    //Slime_Stats slime_stats;

    public void Start()
    {
        stat = FindObjectOfType<Statistics>();//pegando o script Statistics
        experiencia_img = GetComponent<Image>();// Pegando a imagem pra utilizar o fillAmount   
        //experiencia_img.fillAmount = 0;
    }
    public void Update()
    {
        experiencia_img.fillAmount = stat.XPToNextLevel / stat.ExpAtual ;

        //if (experiencia_img.fillAmount == 1)
        //{
        //    experiencia_img.fillAmount = 0;
        //}

        if (stat.ExpAtual >= stat.XPToNextLevel)//caso a experiencia atual seja igual xp necessario para o proximo nivel execulta as ações abaixo
        {        
            stat.Level = stat.Level + 1;//level atual +1
            stat.XPToNextLevel = Mathf.Round(stat.XPToNextLevel + (stat.XPToNextLevel * 1.63f));//xp necessario para o proximo nivel aumenta
            stat.HP_Max = Mathf.Round(stat.HP_Max * 1.05f);//Vida maxima aumenta 5% a cada nivel do player
            //source.PlayOneShot(LevelUp, 1.0f);
            stat.LevelText.text = stat.Level.ToString();//text do cavas atualiza a cada nivel e mostra o nivel atual
            //stat.ExpAtual = 0;
            experiencia_img.fillAmount = 0f;
            //Printa o level e vida maxima do player
            PlayerPrefs.SetInt("LevelDoPlayer", stat.Level);
            //Debug.Log("LevelDoPlayer" + stat.Level);
            Debug.Log("Vida maxima atual: " + stat.HP_Max);
            if (experiencia_img.fillAmount == 1)
            {
                experiencia_img.fillAmount = 0;
            }
        }
    }
    public void Experiencia(int xpMin, int xpMax)
    {
        int Exp = Random.Range(xpMin, xpMax);
        stat.ExpAtual += Exp;
        //experiencia_img.fillAmount = stat.ExpAtual / stat.ExpAtual;
        Debug.Log("Experiencia Ganha:" + Exp);
        Debug.Log("Experiencia atual:" + stat.ExpAtual);
    }
}
