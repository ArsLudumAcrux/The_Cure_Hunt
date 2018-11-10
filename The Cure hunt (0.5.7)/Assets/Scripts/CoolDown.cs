using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoolDown : MonoBehaviour {

    public Image cooldown;
    public float TempoCoolDown;
    public bool PodeUsar;


    PlayerScript playerscript;

	// Use this for initialization
	void Start () {

        playerscript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        TempoCoolDown = 7.0f;
        PodeUsar = true;
        cooldown.fillAmount = 0.0f;

	}
    public void Update()
    {
        if (cooldown.fillAmount <= 0.0f)
        {
            PodeUsar = true;
        }
        else
            PodeUsar = false;
    }
    // Update is called once per frame
    public void CoolDownMagia()
    {

        cooldown.fillAmount = 1.0f;
        PodeUsar = false;
        TempoCoolDown -= Time.deltaTime;
        cooldown.fillAmount = TempoCoolDown; 
        print("c");

    }
}
