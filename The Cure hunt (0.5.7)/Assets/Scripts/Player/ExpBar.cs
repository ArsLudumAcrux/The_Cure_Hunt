using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour {

    public Statistics stat;
    public Image experiencia_img;
    public float expCur;
    //Slime_Stats slime_stats;

    public void Start()
    {
        stat = FindObjectOfType<Statistics>();
        experiencia_img = GetComponent<Image>();
    }
    public void Update()
    {
        expCur = stat.ExpAtual / stat.XPToNextLevel;
        experiencia_img.fillAmount = expCur;

        //if (stat.ExpAtual == stat.XPToNextLevel) { 
        //    stat.ExpAtual = 0;
        //}

        if (stat.ExpAtual >= stat.XPToNextLevel)
        {
            stat.Level = stat.Level + 1;
            stat.XPToNextLevel = Mathf.Round(stat.XPToNextLevel + (stat.XPToNextLevel * 1.63f));
            stat.HP_Max = Mathf.Round(stat.HP_Max * 1.05f);
            //source.PlayOneShot(LevelUp, 1.0f);
            stat.LevelText.text = stat.Level.ToString();
            //stat.ExpAtual = 0;
            experiencia_img.fillAmount = 0f;
            PlayerPrefs.SetInt("LevelDoPlayer", stat.Level);
            Debug.Log("LevelDoPlayer" + stat.Level);
            Debug.Log("Vida maxima atual: " + stat.HP_Max);
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
