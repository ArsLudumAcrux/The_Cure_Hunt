using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBoss : MonoBehaviour {

    public bool IdleAttack;
    public float Damage;
    public float Life;
    public Transform Teletransporte;
    public bool attacking;
    public int rand;
    public CircleCollider2D attackCollider;

    public Vector3 offset;

    PlayerScript player;
    HealthBar HB;
    public Transform playerposition;
  

    Animator anim;

	// Use this for initialization
	void Start () {
        IdleAttack = false;
        offset = new Vector3(0, 3f);
        anim = gameObject.GetComponent<Animator>();
        attacking = false;
        attackCollider = transform.GetChild(0).GetComponent<CircleCollider2D>();
        attackCollider.enabled = false;

        player = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerScript>();
        HB = GameObject.FindGameObjectWithTag("Content").gameObject.GetComponent<HealthBar>();


    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        bool attacking = stateInfo.IsName("Attack");

        if (attacking == true)
        {

            float PlaybackTime = stateInfo.normalizedTime;
            if (PlaybackTime > 0.2 && PlaybackTime < 0.7)
            {

                attackCollider.enabled = true;
            }
            else
            {
                attackCollider.enabled = false;

            }
        }
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HB.HP_Current -= Mathf.RoundToInt(Damage * player.ShieldPotionMult);
        }
    }


    public void IddleBoss()
    {
        anim.SetTrigger("Boss_Idle");
        IdleAttack = false;
        StartCoroutine(ComecarCoroutine());
    }
    public void AttackingBoss()
    {
        anim.SetTrigger("Attack");
        IdleAttack = true;
        attacking = !attacking;
        StartCoroutine(ComecarCoroutine());
    }
    public void FindPlayer(Vector3 pos)
    {
        player.BossPosition();
        pos += offset;
        transform.position = pos;
        AttackingBoss();
    }
   


   public IEnumerator ComecarCoroutine()
    {
        yield return new WaitForSeconds(7.5f);
        if(IdleAttack == false)
        {
            FindPlayer(transform.position);
        }else
        {
            IddleBoss();
        }
                   
    }

}
