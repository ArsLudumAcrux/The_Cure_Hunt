using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBoss : MonoBehaviour {

    public bool IdleAttack;
    public float Damage;
    public float Life;
    public Transform Teletransporte;
    public bool attacking;
    public int rand;
    public CircleCollider2D attackCollider;
    public Slider sliderlife;

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
        sliderlife.maxValue = Life;
        sliderlife.value = Life;

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
            if (PlaybackTime > 0.2f && PlaybackTime < 0.7f)
            {

                attackCollider.enabled = true;
            }
            else
            {
                attackCollider.enabled = false;

            }
        }
        if (Life >= 0)
        {
            sliderlife.value = Life;
        }

        if(Life <= 0)
        {
            anim.SetTrigger("die");
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
        anim.SetTrigger("idle");
        IdleAttack = false;
        StartCoroutine(ComecarCoroutine());
    }
    public void AttackingBoss()
    {
        anim.SetTrigger("attack");
        IdleAttack = true;
        attacking = !attacking;
        StartCoroutine(ComecarCoroutine());
    }
    public void FindPlayer(Vector3 pos)
    {
        
        pos += offset;
        transform.position = pos;
        AttackingBoss();
    }
   
    public void dead()
    {
        Destroy(gameObject);
    }

   public IEnumerator ComecarCoroutine()
    {
        yield return new WaitForSeconds(4.5f);
        if(IdleAttack == false)
        {
            player.BossPosition();
        }
        else
        {
            IddleBoss();
        }
                   
    }

}
