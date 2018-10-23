using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    //public float HP_Max = 100f;
    public float HP_Current;
    public Image HP_Bar;
    public Statistics stats;
    

    // Use this for initialization
    void Start () {
        HP_Bar = GetComponent<Image>();


        HP_Current = stats.HP_Max;
    }
	
	// Update is called once per frame
	void Update () {
        HP_Bar.fillAmount = HP_Current / stats.HP_Max;
   
        //if (HP_Current == 0)
        //{
            
        //    Debug.Log("Player is DEAD!!!");
        //}
       
    }
    
}
