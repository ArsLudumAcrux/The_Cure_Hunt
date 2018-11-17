using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBoss : MonoBehaviour {

    public bool DanoNoBoss;
    public bool idleattack;

    public float Damage;
    public float Life;
    public Transform Teletransporte;

    public int rand;
    public Transform positionplayer;

    PlayerScript player;

    Animator anim;

	// Use this for initialization
	void Start () {
        DanoNoBoss = false;
        idleattack = false;
        //anim.SetBool("Boss_Idle",true);

        player = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerScript>();

    }
	
	// Update is called once per frame
	void Update () {

	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(ComecarCoroutine());
        }
    }


    public void IddleBoss()
    {

    }
    public void AttackingBoss()
    {

    }
    public void FindPlayer()
    {
        Teletransporte.transform.position = new Vector3(positionplayer.transform.position.x, positionplayer.transform.position.y + 30.0f);
        print(Teletransporte);
    }


   public IEnumerator ComecarCoroutine()
    {
        yield return new WaitForSeconds(6f);
        if(idleattack == false)
        {
            FindPlayer();
        }else
        {
            IddleBoss();
        }
                   
    }

}
