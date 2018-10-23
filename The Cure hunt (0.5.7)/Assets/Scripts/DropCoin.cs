using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropCoin : MonoBehaviour {

    public GameObject Coin;

    public void DroparMoeda()
    {
      int Drop = Random.Range(1, 5);
        print("Drop: "+ Drop);
        Instantiate(Coin,transform.position,transform.rotation);

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {



        }
    }

}
