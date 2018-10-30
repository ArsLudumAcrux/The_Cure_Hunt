using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropCoin : MonoBehaviour {

    public GameObject Coin;

    private void Start()
    {
        //stats.GetComponent<Statistics>();
    }
    public void DroparMoeda()
    {
      int Drop = Random.Range(1, 5);
        print("Drop: "+ Drop);
        Instantiate(Coin,transform.position,transform.rotation);

    }
}
