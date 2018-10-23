using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour {

    Statistics stat;
    public Image experiencia_img;
    Slime_Stats slime_stats;

    public void Start()
    {
        experiencia_img = GetComponent<Image>();
    }
    public void Update()
    {
        experiencia_img.fillAmount = stat.ExpAtual / stat.ExpAtual;

        if (stat.ExpAtual >= stat.XPToNextLevel)
        {
            stat.Level = stat.Level + 1;
            stat.XPToNextLevel = Mathf.Round(stat.XPToNextLevel + (stat.XPToNextLevel * 1.63f));
            stat.HP_Max = Mathf.Round(stat.HP_Max * 1.05f);
            //source.PlayOneShot(LevelUp, 1.0f);
            stat.LevelText.text = stat.Level.ToString();
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
        print("Experiencia Ganha:" + Exp);
        print("Experiencia atual:" + stat.ExpAtual);
    }
}
