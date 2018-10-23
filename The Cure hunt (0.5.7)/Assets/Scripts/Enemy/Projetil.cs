using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour {

    public float Damage;

    public HealthBar HB;

	// Use this for initialization
	void Start () {
        Invoke("DestroyProjetil", 3);
        HB = GameObject.FindGameObjectWithTag("Content").GetComponent<HealthBar>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(HB.HP_Current);
            HB.HP_Current -= Damage;
            DestroyProjetil();
        }

    }
    void DestroyProjetil()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
