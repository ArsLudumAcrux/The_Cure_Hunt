using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour {

    public Statistics stat;//variavel referente ao script Statistics
    public Image experiencia_img;
    public float expCur;
    Slime_Stats slime_stats;
    PlayerScript playerScript;

    public void Start()
    {
        //experiencia_img.fillAmount = 0;
        stat = FindObjectOfType<Statistics>();//pegando o script Statistics
        playerScript = FindObjectOfType<PlayerScript>();
        experiencia_img = GetComponent<Image>();// Pegando a imagem pra utilizar o fillAmount   
    }
    public void Update()
    {
        experiencia_img.fillAmount = stat.ExpAtual / stat.XPToNextLevel ;


        if (stat.ExpAtual >= stat.XPToNextLevel)//caso a experiencia atual seja igual xp necessario para o proximo nivel execulta as ações abaixo
        {        
            stat.Level = stat.Level + 1;//level atual +1

            stat.XPToNextLevel = Mathf.Round(stat.XPToNextLevel + (stat.XPToNextLevel * 1.20f));//xp necessario para o proximo nivel aumenta

            stat.HP_Max = Mathf.Round(stat.HP_Max * 1.05f);//Vida maxima aumenta 5% a cada nivel do player

            stat.strongh = Mathf.Round(stat.strongh * 1.02f);

            playerScript.speed= Mathf.Round(stat.strongh * 1.01f);

            //source.PlayOneShot(LevelUp, 1.0f);

            stat.LevelText.text = stat.Level.ToString();//text do cavas atualiza a cada nivel e mostra o nivel atual

            stat.ExpAtual = 0; 

            //Printa o level e vida maxima do player

            PlayerPrefs.SetInt("LevelDoPlayer", stat.Level);

            //Debug.Log("LevelDoPlayer" + stat.Level);

            Debug.Log("Vida maxima atual: " + stat.HP_Max);
            Debug.Log("Força atual do player : " + stat.strongh);
            Debug.Log("Velocidade atual do player : " + playerScript.speed);
        }
    }
    public void Experiencia()
    {
        int Exp = Random.Range(slime_stats.xpMin, slime_stats.xpMax);
        stat.ExpAtual += Exp;
        //experiencia_img.fillAmount = stat.ExpAtual / stat.ExpAtual;
        Debug.Log("Experiencia Ganha:" + Exp);
        Debug.Log("Experiencia atual:" + stat.ExpAtual);
    }
}
